using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Account;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Users;
using Volo.Abp.Validation;
using IdentityUser = Volo.Abp.Identity.IdentityUser;

namespace TotpTest.Pages.Account.Components.ProfileManagementGroup.TwoFactorAuthentication;

public class TwoFactorAuthenticationManagementGroupViewComponent : AbpViewComponent
{
    protected IProfileAppService ProfileAppService { get; }
    private readonly IdentityUserManager _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    public TwoFactorAuthenticationManagementGroupViewComponent(
        IProfileAppService profileAppService,
        IdentityUserManager userManager,
        SignInManager<IdentityUser> signInManager)
    {
        ProfileAppService = profileAppService;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        
        var user = await ProfileAppService.GetAsync();

        var model = new TwoFactorAuthenticationModel()
        {

        };
        var identityUser = await _userManager.GetUserAsync(HttpContext?.User!);
        var authenticatorKey = await _userManager.GetAuthenticatorKeyAsync(identityUser!);
        model.HasAuthenticator = authenticatorKey != null;
        model.Is2faEnabled = await _userManager.GetTwoFactorEnabledAsync(identityUser);
        model.IsMachineRemembered = await _signInManager.IsTwoFactorClientRememberedAsync(identityUser);
        model.RecoveryCodesLeft = await _userManager.CountRecoveryCodesAsync(identityUser);

        return View("~/Pages/Account/Components/ProfileManagementGroup/TwoFactorAuthentication/Default.cshtml", model);
    }

    public class TwoFactorAuthenticationModel
    {
        public bool HasAuthenticator { get; set; }

        public int RecoveryCodesLeft { get; set; }

        [BindProperty]
        public bool Is2faEnabled { get; set; }

        public bool IsMachineRemembered { get; set; }

        [TempData]
        public string StatusMessage { get; set; }
    }
}
