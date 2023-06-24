using System.Collections.Generic;
using RimWorld;
using Verse;

namespace MoreRestrictionsOnPsycastPaths;

public class RequiresPawnWithXenoType : RequiresPawnMatching
{
	public List<XenotypeDef> xenoTypes;

	public override bool Matches(Pawn pawn) => xenoTypes.NullOrEmpty() || xenoTypes.Contains(pawn.genes.Xenotype);
}
