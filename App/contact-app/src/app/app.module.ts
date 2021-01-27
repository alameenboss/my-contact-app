import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NavigationComponent } from './component/navigation/navigation.component';
import { AddressComponent } from './component/address/address.component';
import { ListPersonComponent } from './component/list-person/list-person.component';
import { PersonTreeComponent } from './component/person-tree/person-tree.component';
import { PersonDropComponent } from './component/person-drop/person-drop.component';
import { CardComponent } from './component/card/card.component';
import { DashboardComponent } from './component/dashboard/dashboard.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { MaterialModule } from './shared-module/material/material.module';
import { LoginComponent } from './component/login/login.component';
import { ErrorInterceptor } from './authentication/error.interceptor';
import { JwtInterceptor } from './authentication/jwt.interceptor';
import { AdminComponent } from './component/admin/admin.component';
import { HomeComponent } from './component/home/home.component';
import { ApiKeyInterceptor } from './authentication/apikey.interceptor';
@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    AddressComponent,
    ListPersonComponent,
    PersonTreeComponent,
    PersonDropComponent,
    CardComponent,
    DashboardComponent,
    HomeComponent,
    AdminComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule
  ],
  providers: [
    //{ provide: HTTP_INTERCEPTORS, useClass: ApiKeyInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
],
  bootstrap: [AppComponent]
})
export class AppModule { }
