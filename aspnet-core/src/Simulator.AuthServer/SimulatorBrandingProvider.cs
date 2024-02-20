using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Simulator;

[Dependency(ReplaceServices = true)]
public class SimulatorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Simulator";
}
