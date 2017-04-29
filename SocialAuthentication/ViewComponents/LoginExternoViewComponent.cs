using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialAuthentication.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SocialAuthentication.ViewComponents
{
    public class LoginExternoViewComponent : ViewComponent
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public LoginExternoViewComponent(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var providers = await Task.FromResult(_signInManager.GetExternalAuthenticationSchemes().ToList());
            return View(providers);
        }
    }
}
