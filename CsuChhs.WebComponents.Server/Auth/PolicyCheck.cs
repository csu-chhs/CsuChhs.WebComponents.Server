using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace CsuChhs.WebComponents.Server.Auth;

public class PolicyCheck : IPolicyCheck
{
    private readonly IAuthorizationService _authorizationService;

    public PolicyCheck(IAuthorizationService authorizationService)
    {
        _authorizationService = authorizationService;
    }

    public async Task<bool> UserHasClaim(ClaimsPrincipal user,
        string policy)
    {
        var authorizationResult = await _authorizationService.AuthorizeAsync(user, policy);
        return authorizationResult.Succeeded;
    }
}