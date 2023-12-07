using BooksStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BooksStore.Permissions;

public class BooksStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BooksStorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BooksStorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BooksStoreResource>(name);
    }
}
