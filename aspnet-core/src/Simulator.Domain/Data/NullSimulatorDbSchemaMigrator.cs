using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Simulator.Data;

/* This is used if database provider does't define
 * ISimulatorDbSchemaMigrator implementation.
 */
public class NullSimulatorDbSchemaMigrator : ISimulatorDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
