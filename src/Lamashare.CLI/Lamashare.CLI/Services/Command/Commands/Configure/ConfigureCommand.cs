using Lamashare.CLI.Const;
using Lamashare.CLI.Db.Enums;
using Lamashare.CLI.Services.SystemSetting;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Lamashare.CLI.Services.Command.Commands.Configure;

public class ConfigureCommand(ISystemSettingService settings, ILoggerService logger) : ICommand
{
    public string GetName()
    {
        return "config";
    }

    public async Task<int> Execute(string[] args)
    {
        var result = Parser.Default.ParseArguments<ConfigureOptions>(args);
        if (result.Errors.Any()) return 1;

        if (result.Value.List)
        {
            var list = await settings.GetAllSystemSettingsAsync();
            logger.LogInfo(JsonSerializer.Serialize(list));
            return ExitCodes.Success;
        }

        if (!string.IsNullOrEmpty(result.Value.DefaultDirectory))
            await settings.SetSettingAsync(ESystemSetting.DEFAULT_LIBRARY_DIRECTORY, result.Value.DefaultDirectory);
        if (!string.IsNullOrEmpty(result.Value.DefaultRemote))
            await settings.SetSettingAsync(ESystemSetting.REMOTE_ADDRESS, result.Value.DefaultRemote);

        return 0;
    }
}