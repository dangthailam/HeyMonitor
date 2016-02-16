using DAL;

namespace WebApplication7.Models
{
    public class UserModel
    {
        public long ID { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DoB { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public UserGenreEnum Genre { get; set; }
    }
}
