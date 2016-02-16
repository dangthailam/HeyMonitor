using DAL;
using System;

namespace DTO
{
    public class UserDTO
    {
        public UserDTO()
        {

        }

        public UserDTO(ApplicationUser user)
        {
            ID = user.Id;
            Email = user.Email;
            UserName = user.UserName;
            FirstName = user.FirstName;
            LastName = user.LastName;
            DoB = user.DoB;
            PhoneNumber = user.PhoneNumber;
            Address = user.Address;
            Genre = user.Genre;
        }

        public long ID { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DoB { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public UserGenreEnum Genre { get; set; }
    }
}
