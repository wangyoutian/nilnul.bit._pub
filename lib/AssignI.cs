using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{

	interface AssignI
	{
		VarI PropositionVarI
		{
			get;
			set;
		}

		PropositionI PropositionI
		{
			get;
			set;
		}
	}
}
