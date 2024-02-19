using Simulator.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Simulator.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SimulatorController : AbpControllerBase
{
    protected SimulatorController()
    {
        LocalizationResource = typeof(SimulatorResource);
    }
}
