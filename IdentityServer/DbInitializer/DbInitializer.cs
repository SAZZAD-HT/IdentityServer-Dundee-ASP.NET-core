using IdentityModel;
using IdentityServer.Data;
using IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace IdentityServer.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Initialize()
        {
            if (_roleManager.FindByNameAsync(SD.AdminEndUser).Result==null)
            {
                _roleManager.CreateAsync(new IdentityRole(SD.AdminEndUser)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.CustomerEndUser)).GetAwaiter().GetResult();
            }
            else
            {
                return;
            }
            var iden = new IdentityOptions();
         
            ApplicationUser user = new ApplicationUser
            {
                UserName = "01",
                Email = "kk@gmail.com",
                Name= "Test1" ,
                PasswordHash = "P@ssw0rd"

            };
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, user.PasswordHash);
           
            var dt =  _userManager.CreateAsync(user, SD.AdminEndUser).GetAwaiter().GetResult();
            var data = dt.Errors;
             
            _userManager.AddToRoleAsync(user,SD.AdminEndUser).GetAwaiter().GetResult();

            var claims = new Claim[]
              {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, SD.AdminEndUser),
               // new Claim("" ,""),
              };

            _userManager.AddClaimsAsync(user, claims).GetAwaiter().GetResult();
            ApplicationUser Coustomer = new ApplicationUser
            {
                UserName = "01",
                Email = "kk@gmail.com",
                PasswordHash = "W@#Ew23e"
            };
            _userManager.CreateAsync(Coustomer, SD.CustomerEndUser).GetAwaiter().GetResult();
            _userManager.AddToRoleAsync(Coustomer, SD.CustomerEndUser).GetAwaiter().GetResult();

            var claimsc = new Claim[]
              {
                new Claim(ClaimTypes.Name, Coustomer.UserName),
                new Claim(ClaimTypes.Email, Coustomer.Email),
                new Claim(ClaimTypes.Role, SD.CustomerEndUser),
               // new Claim("" ,""),
              };

            _userManager.AddClaimsAsync(Coustomer, claimsc).GetAwaiter().GetResult();

        }
    }
}
