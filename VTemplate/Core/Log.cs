using BepInEx.Logging;

namespace VTemplate.Core;

public static class Log
{
	private static ManualLogSource? LogSource { get; set; }

	public static void Initialize(ManualLogSource? logSource)
	{
		LogSource = logSource;

		LogSource?.LogInfo($"[Log] LogSource Initialized");
	}

	public static void Info(string context, string message)
	{
		LogSource?.LogInfo($"[{context}] {message}");
	}

	public static void Message(string context, string message)
	{
		LogSource?.LogMessage($"[{context}] {message}");
	}

	public static void Warning(string context, string message)
	{
		LogSource?.LogWarning($"[{context}] {message}");
	}

	public static void Error(string context, string message)
	{
		LogSource?.LogError($"[{context}] {message}");
	}
}
