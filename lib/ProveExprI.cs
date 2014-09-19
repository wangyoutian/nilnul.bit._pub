using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	public partial interface ProveExprI
	{
		PropositionI Left
		{
			get;
			set;
		}

		PropositionI Right
		{
			get;
			set;
		}
	}
}
