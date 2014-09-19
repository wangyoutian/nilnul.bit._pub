using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	public partial interface BasicExprI : FormulaI, ExprI
	{

	}

	static public partial class X
	{
		static public bool IsBasicClause(PropositionI p) {

			if (p is VarI)
			{
				return true;
			}

			else if (p is )
			{
				
			}
				
			throw new Exception();
		
		}
		
	}
}
