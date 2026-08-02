using PlasmaBuild.Core.Configuration;
using PlasmaBuild.Core.Rules;

public class XBoxControllerPluginTarget : TargetRules
{
    public XBoxControllerPluginTarget(BuildContext context) : base(context)
    {
        Type = TargetType.SharedLibrary;
        OutputName = "plXBoxControllerPlugin";
        OutputDirectory = PlasmaPackageSdk.PackageBinaryDirectory(context);
        UsePCHFiles = false;
        UseUnityBuild = true;
        UseAdaptiveUnityBuild = true;
        UseIncrementalLinking = true;
        ExtraModules.Add("XBoxControllerPluginModule");
    }
}
