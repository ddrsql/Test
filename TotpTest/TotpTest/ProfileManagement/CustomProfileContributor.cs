using Microsoft.Extensions.Localization;
using TotpTest.Localization;
using TotpTest.Pages.Account.Components.ProfileManagementGroup.Password;
using TotpTest.Pages.Account.Components.ProfileManagementGroup.PersonalInfo;
using TotpTest.Pages.Account.Components.ProfileManagementGroup.TwoFactorAuthentication;
using Volo.Abp.Account.Localization;
//using Volo.Abp.Account.Web.Pages.Account.Components.ProfileManagementGroup.Password;
//using Volo.Abp.Account.Web.Pages.Account.Components.ProfileManagementGroup.PersonalInfo;
using Volo.Abp.Account.Web.ProfileManagement;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace TotpTest.ProfileManagement;

public class CustomProfileContributor : IProfileManagementPageContributor
{
    public async Task ConfigureAsync(ProfileManagementPageCreationContext context)
    {
        context.Groups.Clear(); //移除默认

        var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<AccountResource>>();

        if (await IsPasswordChangeEnabled(context))
        {
            context.Groups.Add(
                new ProfileManagementPageGroup(
                    "Volo.Abp.Account.Password",
                    l["ProfileTab:Password"],
                    typeof(AccountProfilePasswordManagementGroupViewComponent)
                )
            );
        }

        context.Groups.Add(
            new ProfileManagementPageGroup(
                "Volo.Abp.Account.PersonalInfo",
                l["ProfileTab:PersonalInfo"],
                typeof(AccountProfilePersonalInfoManagementGroupViewComponent)
            )
        );

        var tL = context.ServiceProvider.GetRequiredService<IStringLocalizer<TotpTestResource>>();
        context.Groups.Add(
            new ProfileManagementPageGroup(
                "TotpTest.Account.TwoFactorAuthentication",
                tL["ProfileTab:TwoFactorAuthentication"],
                typeof(TwoFactorAuthenticationManagementGroupViewComponent)
            )
        );
    }

    protected virtual async Task<bool> IsPasswordChangeEnabled(ProfileManagementPageCreationContext context)
    {
        var userManager = context.ServiceProvider.GetRequiredService<IdentityUserManager>();
        var currentUser = context.ServiceProvider.GetRequiredService<ICurrentUser>();

        var user = await userManager.GetByIdAsync(currentUser.GetId());

        return !user.IsExternal;
    }
}
