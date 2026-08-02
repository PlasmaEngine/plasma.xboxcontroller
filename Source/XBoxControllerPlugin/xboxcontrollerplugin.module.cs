using PlasmaBuild.Core.Configuration;
using PlasmaBuild.Core.Rules;

public class XBoxControllerPluginModule : ModuleRules
{
    public XBoxControllerPluginModule(BuildContext context) : base(context)
    {
        PlasmaPackageSdk.ConfigurePackageModule(this, context, "Source/XBoxControllerPlugin",
            "XBoxControllerPluginPCH.h", "BUILDSYSTEM_BUILDING_XBOXCONTROLLERPLUGIN_LIB");

        // This plugin does not use the shared PCH.
        PCHUsage = PCHUsage.None;
        SharedPCHHeaderFile = null;

        ConfigureForPlatform(TargetPlatform.Windows, () => { PublicSystemLibraries.Add("XINPUT9_1_0"); });
    }
}
