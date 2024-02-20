using Simulator.Samples;
using Xunit;

namespace Simulator.EntityFrameworkCore.Applications;

[Collection(SimulatorTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SimulatorEntityFrameworkCoreTestModule>
{

}
