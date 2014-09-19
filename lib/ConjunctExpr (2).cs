using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.proposition
{
	public partial class ConjunctExpr
		:
		OpOnSetExprA<PropositionI,PropositionI,PropositionI>
		,
		ConjunctExprI
		
		
	{
		

		public ConjunctExpr(params PropositionI[] operands)
			:
			base(operands)
		{
			
		}




		

		public override OpOnSetI<PropositionI, PropositionI> op
		{
			get
			{
				 return Conjunct.Instance;
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
