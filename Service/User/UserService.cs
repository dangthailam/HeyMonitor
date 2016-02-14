using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNet.Identity.EntityFramework;
using DTO;

namespace Service.User
{
    public class UserService : IDisposable
    {
        private HeyMonitorContext _ctx;

        private UserManager<ApplicationUser> _userManager;

        public UserService()
        {
            _ctx = new HeyMonitorContext();
            _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(UserDTO userDto)
        {
            var user = new ApplicationUser
            {
                UserName = userDto.Email,
                Email = userDto.Email
            };

            var result = await _userManager.CreateAsync(user, userDto.Password);

            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);

            return user;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();
        }
    }
}
