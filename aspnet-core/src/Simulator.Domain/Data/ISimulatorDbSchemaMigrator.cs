using System.Threading.Tasks;

namespace Simulator.Data;

public interface ISimulatorDbSchemaMigrator
{
    Task MigrateAsync();
}
