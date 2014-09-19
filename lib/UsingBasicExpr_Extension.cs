using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;





namespace nilnul.proposition
{
	static public class BinaryOpExpr_Extension
	{
		/// <summary>
		/// every proposition can be expressed using Not, Conjunction and Disjunction.
		/// </summary>
		/// <param name="expr"></param>
		/// <returns></returns>
		
		static public PropositionI UsingBasicOps(this PropositionI expr) {
			if (expr is ImplyExprI)
			{
				ImplyExprI ex = (ImplyExprI)expr;
				return new DisjunctExpr(
					new NotExpr(ex.left.UsingBasicOps())
					,
					ex.right.UsingBasicOps()
				);
			}
			else if (expr is EquivExprI)
			{
				return new ConjunctExpr(
					new ImplyExpr(
						((EquivExprI)expr).left.UsingBasicOps()
						,
						((EquivExprI)expr).right.UsingBasicOps()
					).UsingBasicOps()
					,
					new ImplyExpr(
						((EquivExprI)expr).right.UsingBasicOps()
						,
						((EquivExprI)expr).left.UsingBasicOps()

					).UsingBasicOps()

				);

			}

			else if (expr is PropositionBinaryOpExprI)
			{
				return PropositionBinaryOpExpr.CreateInstance(
					((PropositionBinaryOpExprI)expr).op
					,
					((PropositionBinaryOpExprI)expr).left.UsingBasicOps()
					,
					((PropositionBinaryOpExprI)expr).right.UsingBasicOps()
				);
			}
				
			else if(expr is NotExprI)
			{
				return new NotExpr(
					((NotExprI)expr).operand.UsingBasicOps()
					);

			}
			else {
				return expr;
			}
			
		
		}


	}
}
