using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomRoleStore : RoleStore<CustomIdentityRole, long, CustomIdentityUserRole>
    {
        public CustomRoleStore(HeyMonitorContext context)
            : base(context)
        {
        }
    }
}
