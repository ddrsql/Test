using TotpTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace TotpTest.Permissions;

public class TotpTestPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TotpTestPermissions.GroupName);

        
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TotpTestPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TotpTestResource>(name);
    }
}
