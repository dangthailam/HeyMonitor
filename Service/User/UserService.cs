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

        private UserManager<ApplicationUser, long> _userManager;

        public UserService()
        {
            _ctx = new HeyMonitorContext();
            _userManager = new UserManager<ApplicationUser, long>(new CustomUserStore(_ctx));
        }

        public IdentityResult RegisterUser(UserDTO userDto)
        {
            var user = new ApplicationUser
            {
                UserName = userDto.Email,
                Email = userDto.Email
            };

            var result = _userManager.CreateAsync(user, userDto.Password).Result;

            return result;
        }

        public async Task<UserDTO> FindUser(string userName, string password)
        {
            ApplicationUser user = await _userManager.FindAsync(userName, password);

            return new UserDTO(user);
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();
        }
    }
}
