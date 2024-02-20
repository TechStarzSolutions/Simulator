using Volo.Abp.Modularity;

namespace Simulator;

[DependsOn(
    typeof(SimulatorApplicationModule),
    typeof(SimulatorDomainTestModule)
)]
public class SimulatorApplicationTestModule : AbpModule
{

}
