using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	public interface ConjunctFormulaI
		:
		PropositionI,

		OpOnSetExprI<PropositionI, PropositionI, LiteralI>
	{
		
	}
}
