using System.Collections.Generic;
using RimWorld;
using Verse;

namespace XenoRestrictedPsycasting;

public class RequiresPawnWithXenoType : RequiresPawnMatching
{
	public List<XenotypeDef> xenoTypes;

	public override bool Matches(Pawn pawn) => xenoTypes.NullOrEmpty() || xenoTypes.Contains(pawn.genes.Xenotype);
}