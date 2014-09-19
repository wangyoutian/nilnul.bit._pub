using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition.predicate
{

	/// <summary>
	/// A wff is said to be satisfiable if there exists an interpretation that makes it true, that is if there are a universe, specific predicates assigned to the predicate variables, and an assignment of values to the free variables that make the wff true. 
	/// For example, x N(x), where N(x) means that x is non-negative, is satisfiable. For if the universe is the set of natural numbers, the assertion x N(x) is true, because all natural numbers are non-negative. Similarly x N(x) is also satisfiable.
	/// </summary>
	public partial interface SatisfiableI
		:AdjectiveI<WellFormedFormulaI>
	{

	}
}
