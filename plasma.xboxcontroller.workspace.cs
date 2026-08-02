// #pl-version 1

using PlasmaBuild.Core.Configuration;
using PlasmaBuild.Core.Rules;

public class PlasmaXBoxControllerWorkspace : WorkspaceRules
{
    public PlasmaXBoxControllerWorkspace(BuildContext context) : base(context)
    {
        TargetNames.Add("XBoxControllerPlugin");
    }
}
