namespace Storage.Models
{
    public class CompanyModel : IUserModel
    {
        //To use the App
        public int Id { get; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password{get; set;}

        //Company's data
        public string? Name { get; set; }
        public string? CNPJ { get; set; }
        public string? StateRegistration { get; set; }
        public DateTime OpeningDate { get; set; }
        public string? WebSite { get; set; }
        public string? CEP { get; set; }
        public string? Address { get; set; }
        public int? Number { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public char? State { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Field { get; set; }
     
        public CompanyModel (string Login, string Email, string Password, string Name, string CNPJ, string StateRegistration, 
            DateTime OpeningDate, string WebSite, string CEP, string Address, int Number, string District, 
            string City, char State, string PhoneNumber, string Field) 
        {
            this.Login = Login;
            this.Email = Email;
            this.Password = Password;
            this.Name = Name;
            this.CNPJ = CNPJ;
            this.StateRegistration = StateRegistration;
            this.OpeningDate = OpeningDate;
            this.WebSite = WebSite;
            this.CEP = CEP;
            this.Address = Address;
            this.Number = Number;
            this.District = District;
            this.City = City;
            this.State = State;
            this.PhoneNumber = PhoneNumber;
            this.Field = Field;
        }
     }
}
