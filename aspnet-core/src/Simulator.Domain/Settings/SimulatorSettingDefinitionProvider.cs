using Volo.Abp.Settings;

namespace Simulator.Settings;

public class SimulatorSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SimulatorSettings.MySetting1));
    }
}
