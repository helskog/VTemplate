using BepInEx.Configuration;

namespace VTemplate.Core;

public class Config
{
	internal static ConfigEntry<bool>? example;
	internal static void Initialize(ConfigFile config)
	{
		config.SaveOnConfigSet = true;
		
		example = config.Bind("Options", "example", false, "An example configuration");

		Log.Info("Config", "Config Initialized");
	}
}