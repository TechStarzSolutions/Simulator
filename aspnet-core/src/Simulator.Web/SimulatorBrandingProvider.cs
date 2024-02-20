using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Simulator.Web;

[Dependency(ReplaceServices = true)]
public class SimulatorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Simulator";
}
