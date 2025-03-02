namespace Storage.Models
{
    public interface IUserModel
    {
        string Login { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}
