using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationUser : IdentityUser<long, CustomIdentityUserLogin, CustomIdentityUserRole, CustomIdentityUserClaim>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public UserGenreEnum Genre { get; set; }

        public string Address { get; set; }

        public DateTime? DoB { get; set; }
    }

    public enum UserGenreEnum
    {
        Man,
        Woman,
        Other
    }
}
