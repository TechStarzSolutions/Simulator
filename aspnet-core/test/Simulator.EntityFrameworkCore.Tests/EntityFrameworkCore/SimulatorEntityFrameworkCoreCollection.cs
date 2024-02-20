using Xunit;

namespace Simulator.EntityFrameworkCore;

[CollectionDefinition(SimulatorTestConsts.CollectionDefinitionName)]
public class SimulatorEntityFrameworkCoreCollection : ICollectionFixture<SimulatorEntityFrameworkCoreFixture>
{

}
