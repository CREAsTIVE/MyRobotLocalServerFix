using MelonLoader;
using System;

namespace MyRobotLocalServerFix
{
	[HarmonyLib.HarmonyPatch(typeof(Game), nameof(Game.SetClient))]
	public class SetClientPatch
	{
		static void Prefix(ref MyRobotClient _session)
		{
			_session.oobaServerPath = "http://127.0.0.1:5000";
		}
	}

	public class MyRobotLocalServerFixMod : MelonMod
	{

	}
}
											   