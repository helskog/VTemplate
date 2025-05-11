using ProjectM.Network;
using Stunlock.Network;

using Unity.Entities;
using HarmonyLib;
using ProjectM;

namespace VTemplate.Patches;

[HarmonyPatch(typeof(ServerBootstrapSystem), nameof(ServerBootstrapSystem.ApproveClient))]
public static class ExamplePatch
{
	private static bool Prefix(
			NetConnectionId netConnection,
			int version,
			ulong platformId,
			string eosIdString,
			bool isReconnect,
			bool connectedAsAdmin,
			ref User user,
			Entity userEntity,
			ConnectAddress primaryAddress,
			ConnectAddress secondaryAddress
	)
	{
		
		return false;
	}
}