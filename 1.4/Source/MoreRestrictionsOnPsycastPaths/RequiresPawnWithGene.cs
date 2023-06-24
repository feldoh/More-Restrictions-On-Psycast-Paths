using System.Collections.Generic;
using Verse;

namespace MoreRestrictionsOnPsycastPaths;

public class RequiresPawnWithGene : RequiresPawnMatching
{
	public List<GeneDef> genes;

	public override bool Matches(Pawn pawn) => genes.NullOrEmpty() || genes.Any(pawn.genes.HasGene);
}
