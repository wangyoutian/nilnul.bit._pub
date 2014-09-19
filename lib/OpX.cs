using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.proposition
{
	static public partial class E
	{
		static public PropositionI Conjunct(this PropositionI a, PropositionI b)
		{
			return new ConjunctExpr(a, b);
		}

		static public PropositionI Disjunct(this PropositionI a, PropositionI b)
		{
			return new DisjunctExpr(a, b);
		}
		static public PropositionI Imply(this PropositionI a, PropositionI b)
		{
			return new ImplyExpr(a, b);
		}
		static public PropositionI Not(this PropositionI a)
		{
			return new NotExpr(a);
		}
		static public PropositionI Equiv(this PropositionI a, PropositionI b)
		{
			return new EquivExpr(a, b);
		}
	}

}
