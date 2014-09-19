using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.proposition
{
	public partial class DisjunctExpr
		:
		OpOnSetExprA<
			PropositionI
			,
			PropositionI
			,
			PropositionI
		>
		,
		DisjunctExprI
	{
		public DisjunctExpr(params PropositionI[] operands)
			:base(operands)
		{
		}

		public override OpOnSetI<PropositionI, PropositionI> op
		{
			get
			{
				return Disjunct.Instance;
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
