using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{

	/// <summary>
	/// A proposition is valid if it is true for any interpretation G.
	/// Example: p+!p is Valid (p or not p)
	/// </summary>
	public partial interface ValidI
		:
		AdjectiveI<PropositionI>
	{
	}
}
