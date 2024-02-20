using Simulator.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Simulator.Permissions;

public class SimulatorPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SimulatorPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SimulatorPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SimulatorResource>(name);
    }
}
