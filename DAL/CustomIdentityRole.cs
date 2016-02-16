using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL
{
    public class CustomIdentityRole : IdentityRole<long, CustomIdentityUserRole>
    {
        public CustomIdentityRole() { }
        public CustomIdentityRole(string name) { Name = name; }
    }
}