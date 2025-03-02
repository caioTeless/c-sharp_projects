namespace Storage.Models
{
    public class UserModel : IUserModel
    {
        //To use the App
        public int Id { get; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Employe's data
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public bool Enabled { get; set; }
        public DateTime CreationTime { get; set; }
        public CompanyModel Company { get; set; }

        public UserModel(string Name, string Login, string Email, string Password, string PhoneNumber, bool Enabled, CompanyModel Company)
        {
            this.Name = Name;
            this.Login = Login;
            this.Email = Email;
            this.Password = Password;
            this.PhoneNumber = PhoneNumber;
            this.Enabled = Enabled;
            this.CreationTime = DateTime.Now;
            this.Company = Company;
        }
    }
}
