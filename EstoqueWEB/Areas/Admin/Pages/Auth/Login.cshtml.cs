using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EstoqueWEB.Areas.Admin.Models.FormModel;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace EstoqueWEB.Areas.Admin.Pages.Auth
{
    public class LoginModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/Pages/Index");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(
            [FromForm] LoginFormModel loginForm)
        {
            if (loginForm.Username != "admin" && loginForm.Password != "1234")
            {
                ViewData["Fail"] = true;
                return Page();
            }

            var user = new
            {
                Id = Guid.NewGuid(),
                Name = "Administrador"
            };

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
            };

            var identity = new ClaimsIdentity(claims,
                CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, 
                principal, 
                new AuthenticationProperties
            {
                IsPersistent = loginForm.RememberMe
            });

            if (!String.IsNullOrWhiteSpace(loginForm.ReturnUrl))
            {
                return Redirect(loginForm.ReturnUrl);
            }

            return RedirectToPage("/Pages/Index");
        }
    }
}
