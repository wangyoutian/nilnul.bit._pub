using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{

	/// <summary>
	/// A disjunction of literals. Expressed as C
	/// Example: p + !p + q, L1 + L2 + L3
	/// </summary>
	public interface ClauseI 
		: 
		DisjunctExprI
		,
		OpOnSetExprI<PropositionI,PropositionI,LiteralI>
	{
	}
}
