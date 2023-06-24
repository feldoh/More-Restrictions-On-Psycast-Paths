using System.Linq;
using HarmonyLib;
using VanillaPsycastsExpanded;
using Verse;

namespace MoreRestrictionsOnPsycastPaths
{
	[HarmonyPatch(typeof(PsycasterPathDef), nameof(PsycasterPathDef.CanPawnUnlock))]
	public static class ExtraPsycastRestrictions
	{
		[HarmonyPostfix]
		public static bool Postfix(bool result, Pawn pawn, PsycasterPathDef __instance)
		{
			return result && (__instance.modExtensions?.All(e => e is not RequiresPawnMatching || (e is RequiresPawnMatching r && r.Matches(pawn))) ?? true);
		}
	}
}
