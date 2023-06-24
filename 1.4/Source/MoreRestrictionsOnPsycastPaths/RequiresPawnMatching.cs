using Verse;

namespace MoreRestrictionsOnPsycastPaths
{
	public abstract class RequiresPawnMatching : DefModExtension
	{
		public abstract bool Matches(Pawn pawn);
	}
}
