using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    public async Task SignOut()
    {
        // Note: To sign out the current user and delete their cookie, call SignOutAsync

        // 1. Initiate signout for cookie based authentication scheme
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        // 2. Initiate signout for OpenID authentication scheme
        await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
    }

    public ActionResult SignOutSuccessful()
    {
        return View();
    }
}
