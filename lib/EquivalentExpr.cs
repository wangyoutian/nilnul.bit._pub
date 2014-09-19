using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.proposition
{
	public partial class EquivalentExpr
		:
		PropositionBinaryOpExprA
		,
		EquivalentExprI
	{
		public EquivalentExpr(PropositionI left, PropositionI right):base(left,right)
		{

		}

		public override BinaryOpI<PropositionI, PropositionI, PropositionI> op
		{
			get
			{
				return Equivalent.Instance;
			}
			set
			{
				throw new NotImplementedException();
			}
		}



	}
}
