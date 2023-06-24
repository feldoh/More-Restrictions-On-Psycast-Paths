using HarmonyLib;
using UnityEngine;
using Verse;

namespace MoreRestrictionsOnPsycastPaths
{
	public class Mod : Verse.Mod
	{
		public static Settings settings;

		public Mod(ModContentPack content) : base(content)
		{
			// initialize settings
			// settings = GetSettings<Settings>();

#if DEBUG
			Harmony.DEBUG = true;
#endif

			Harmony harmony = new Harmony("Taggerung.rimworld.MoreRestrictionsOnPsycastPaths.main");
			harmony.PatchAll();
		}

		public override void DoSettingsWindowContents(Rect inRect)
		{
			base.DoSettingsWindowContents(inRect);
			settings.DoWindowContents(inRect);
		}
		//
		// public override string SettingsCategory()
		// {
		// 	return "MoreRestrictionsOnPsycastPaths";
		// }
	}
}
