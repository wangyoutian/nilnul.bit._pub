using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	public partial interface DisjunctFormulaI
		:
		DisjunctExprI
		,
		OpOnSetExprI<PropositionI,PropositionI,LiteralI>
	{

	}
}
