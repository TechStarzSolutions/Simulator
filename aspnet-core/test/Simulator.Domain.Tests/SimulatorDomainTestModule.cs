using Volo.Abp.Modularity;

namespace Simulator;

[DependsOn(
    typeof(SimulatorDomainModule),
    typeof(SimulatorTestBaseModule)
)]
public class SimulatorDomainTestModule : AbpModule
{

}
