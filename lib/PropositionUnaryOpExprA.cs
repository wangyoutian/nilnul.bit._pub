using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;







namespace nilnul.proposition
{
	public abstract partial class PropositionUnaryOpExprA
		:
		UnaryOpExprA<PropositionI, PropositionI,PropositionI>
		,
		PropositionI
	{
		public PropositionUnaryOpExprA(PropositionI left)
			:base(left)
		{
			
			
		}

		public override string ToString()
		{
			
			
			return this.Prior(operand)>0?
					"(" +operand.ToString() +")"
					:operand.ToString();
				
		}


		//public override IBinaryOp<IProposition, IProposition, IProposition> op
		//{
		//    get
		//    ;
		//    set;
		//}


	}
}
