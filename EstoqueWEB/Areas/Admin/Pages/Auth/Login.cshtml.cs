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
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(
            [FromForm] LoginFormModel loginform)
        {
            if (loginform.Username != "admin" && loginform.Password != "1234")
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
                IsPersistent = loginform.RememberMe
            });

            if (!String.IsNullOrWhiteSpace(loginform.ReturnUrl))
            {
                return Redirect(loginform.ReturnUrl);
            }

            return RedirectToPage("/Pages/Index");
        }
    }
}
