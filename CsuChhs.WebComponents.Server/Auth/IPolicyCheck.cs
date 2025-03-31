using System.Security.Claims;

namespace CsuChhs.WebComponents.Server.Auth;
public interface IPolicyCheck
{
    /// <summary>
    /// Checks a given policy against 
    /// a given user.
    /// </summary>
    /// <param name="user"></param>
    /// <param name="policy"></param>
    /// <returns></returns>
    Task<bool> UserHasClaim(ClaimsPrincipal user, 
        string policy);
}