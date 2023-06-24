using Verse;

namespace XenoRestrictedPsycasting
{
	public abstract class RequiresPawnMatching : DefModExtension
	{
		public abstract bool Matches(Pawn pawn);
	}
}
