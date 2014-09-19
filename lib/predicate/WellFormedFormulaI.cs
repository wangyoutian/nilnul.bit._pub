using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition.predicate
{
	/// <summary>
	/// Wffs are constructed using the following rules: 
	///		True and False are wffs. 
	///		Each propositional constant (i.e. specific proposition), and each propositional variable (i.e. a variable representing propositions) are wffs. 
	///		Each atomic formula (i.e. a specific predicate with variables) is a wff. 
	///		If A, B, and C are wffs, then so are  A, (A  B), (A  B), (A  B), and (A  B). 
	///		If x is a variable (representing objects of the universe of discourse), and A is a wff, then so are  x A and  x A . 

	/// </summary>
	public partial interface WellFormedFormulaI
	{

	}
}
