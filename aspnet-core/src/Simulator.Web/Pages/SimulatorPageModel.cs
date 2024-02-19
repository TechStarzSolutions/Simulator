using Simulator.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Simulator.Web.Pages;

public abstract class SimulatorPageModel : AbpPageModel
{
    protected SimulatorPageModel()
    {
        LocalizationResourceType = typeof(SimulatorResource);
    }
}
