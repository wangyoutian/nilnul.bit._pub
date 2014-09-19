using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;

namespace nilnul.proposition
{
	public partial interface ImplyExprI
		:
		PropositionI
		,
		BinaryOpExprI<PropositionI, PropositionI, PropositionI, PropositionI, PropositionI>, FormulaI, PropositionBinaryOpExprI, ExprI
	{

	}
}
