using TryLogin.ServiceReference1;

namespace TryLogin.Models
{
    public class RegisterModel
    {
        
        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Mobile { get; set; }

        public int CountryID { get; set; }

        public int aID { get; set; }

        public string SignupIP { get; set; }

    }
}