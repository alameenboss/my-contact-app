using Dapper.WebAPI.Helpers;
using Dapper.WebAPI.Middleware;
using Dapper.WebAPI.Services;
using Dapper.WebAPI.Services.Interface;
using Dapper.WebAPI.Services.Queries;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using NSwag;
using NSwag.Generation.Processors.Security;
using System.Text;

namespace Dapper.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddTransient<ICommandText, CommandText>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<IPhoneRepository, PhoneRepository>();
            services.AddTransient<IEmailRepository, EmailRepository>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<ITvpConverterHelper, TvpConverterHelper>();
            services.AddScoped<IUserService, UserService>();

            services.AddMvc();
            services.AddOpenApiDocument(config =>
            {
                config.Title = "ASPNET CORE 3.1/WebAPI/Dapper Async/MSSQL Prototype";
                config.OperationProcessors.Add(new OperationSecurityScopeProcessor("ApiKey"));
                // Add custom document processors, etc.
                //config.DocumentProcessors.Add(new SecurityDefinitionAppender("ApiKey", new OpenApiSecurityScheme
                //{
                //    Type = OpenApiSecuritySchemeType.ApiKey,
                //    Name = "ApiKey",
                //    In = OpenApiSecurityApiKeyLocation.Header,
                //    Description = "Add your Api Key"
                //}));
            });
            
            


           
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseHttpsRedirection();

            app.UseRouting();
            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();


            //app.UseMiddleware<ApiKeyMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
