using System;
using System.Collections.Generic;
using System.Text;
using Simulator.Localization;
using Volo.Abp.Application.Services;

namespace Simulator;

/* Inherit your application services from this class.
 */
public abstract class SimulatorAppService : ApplicationService
{
    protected SimulatorAppService()
    {
        LocalizationResource = typeof(SimulatorResource);
    }
}
