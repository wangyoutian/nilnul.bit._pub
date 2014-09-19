using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	public partial interface DualI
		:UnaryOpI<PropositionI,PropositionI>
	{

	}

	static public partial class X {

		static public PropositionI Dual(this PropositionI expr) {


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
			else
			{
				return expr;
			}
			
		
		}
	}
}
