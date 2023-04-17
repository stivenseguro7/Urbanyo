using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Urbanyo.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonimous = new ClaimsIdentity();
            var EstivenUser = new ClaimsIdentity(new List<Claim>
                {
                      new Claim("FirstName", "Estiven"),
                      new Claim("LastName", "Seguro"),
                      new Claim(ClaimTypes.Name, "stiven@yopmail.com"),
                      new Claim(ClaimTypes.Role, "Admin")
                },
            authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonimous)));
            //anonumous decrementa el contador y zuluUser lo aumenta y permite ver los paises
        }
    }
}

