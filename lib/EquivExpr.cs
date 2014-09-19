using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.proposition
{
	public partial class EquivExpr
		:
		PropositionBinaryOpExprA
		,
		EquivExprI
	{
		public EquivExpr(PropositionI left, PropositionI right):base(left,right)
		{

		}

		public override BinaryOpI<PropositionI, PropositionI, PropositionI> op
		{
			get
			{
				return Equiv.Instance;
			}
			set
			{
				throw new NotImplementedException();
			}
		}



	}
}
