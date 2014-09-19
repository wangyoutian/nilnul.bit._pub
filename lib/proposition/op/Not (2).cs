using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic.proposition
{
	public partial class Not
	{
		static public NotExpr Call(PropositionI p) {

			return new NotExpr(p);
		}


	}

	static public partial class NotX {

		static public NotExpr Not(this PropositionI p) {

			return new NotExpr(p);
		
		}
		
	}

	public partial class NotExpr
		:PropositionI
	{
		public PropositionI proposition { get; set; }

		public NotExpr(PropositionI p)
		{
			this.proposition = p;

		}
					
	}
}
