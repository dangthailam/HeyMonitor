using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomUserStore : UserStore<ApplicationUser, CustomIdentityRole, long, CustomIdentityUserLogin, CustomIdentityUserRole, CustomIdentityUserClaim>
    {
        public CustomUserStore(HeyMonitorContext context)
            : base(context)
        {
        }
    }
}
