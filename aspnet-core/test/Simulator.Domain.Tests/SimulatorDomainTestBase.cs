using Volo.Abp.Modularity;

namespace Simulator;

/* Inherit from this class for your domain layer tests. */
public abstract class SimulatorDomainTestBase<TStartupModule> : SimulatorTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
