namespace Dapper.WebAPI.Services
{
    public static class StoredProcedureConstants
    {
        public const string AddAddressByPersonId = "dbo.AddAddressByPersonId";
        public const string AddEmailByPersonId = "dbo.AddEmailByPersonId";
        public const string AddPerson = "dbo.AddPerson";
        public const string AddPhoneByPersonId = "dbo.AddPhoneByPersonId";
        public const string DeleteAddressById = "dbo.DeleteAddressById";
        public const string DeleteEmailById = "dbo.DeleteEmailById";
        public const string DeletePersonById = "dbo.DeletePersonById";
        public const string DeletePhoneById = "dbo.DeletePhoneById";
        public const string GetAddressByPersonId = "dbo.GetAddressByPersonId";
        public const string GetEmailByPersonId = "dbo.GetEmailByPersonId";
        public const string GetPersonById = "dbo.GetPersonById";
        public const string GetPersons = "dbo.GetPersons";
        public const string GetPhoneByPersonId = "dbo.GetPhoneByPersonId";
        public const string UpdateAddressById = "dbo.UpdateAddressById";
        public const string UpdateEmailById = "dbo.UpdateEmailById";
        public const string UpdatePerson = "dbo.UpdatePerson";
        public const string UpdatePhoneById = "dbo.UpdatePhoneById";
    }

    //Select 'public const string '+[name]+' = "dbo.'+name+'";' from sys.procedures order by 1
}
