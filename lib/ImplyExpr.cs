using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace nilnul.proposition
{
	public partial class ImplyExpr
		: PropositionBinaryOpExprA, ImplyExprI
		
	{
		

		public ImplyExpr(PropositionI left,PropositionI right):base(left,right) {
	
		
		}






		public override BinaryOpI<PropositionI, PropositionI, PropositionI> op
		{
			get
			{
				return Imply.Instance;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		
	}
}
