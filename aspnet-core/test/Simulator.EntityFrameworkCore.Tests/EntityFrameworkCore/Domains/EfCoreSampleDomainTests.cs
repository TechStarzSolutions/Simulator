using Simulator.Samples;
using Xunit;

namespace Simulator.EntityFrameworkCore.Domains;

[Collection(SimulatorTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SimulatorEntityFrameworkCoreTestModule>
{

}
