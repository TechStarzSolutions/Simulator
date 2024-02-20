using Volo.Abp.Modularity;

namespace Simulator;

public abstract class SimulatorApplicationTestBase<TStartupModule> : SimulatorTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
