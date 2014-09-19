using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.proposition
{
	public class PropositionVar 
		: Variable<PropositionI>
		, PropositionVarI
	{
		public PropositionVar(string name)
			:base(name)
		{

		}
	}
}
