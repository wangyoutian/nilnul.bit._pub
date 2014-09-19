using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{

	/// <summary>
	/// The process of deriving new valid clauses from a CNF is called resolution. 
	/// 
	/// Any two clauses in a valid CNF with one set of complementing literals can be disjoined together to create a new clause. 
	/// 
	/// Within the new clause duplicate literals can combined to simplify it. 
	/// Example: C1*C2 <==> T 
	/// C1: !a+b+c+d
	/// C2: a+b+c+e
	/// --------------------
	/// C3: b+b+c+c+d+e (by resolution)
	/// C3: b+c+d+e
	/// Thus C1*C2*C3 <==> T 
	/// 
	/// Note that resolving two clauses with more than one set of complementing literels is not useful. 
	/// </summary>
	public partial interface ResolutionI
	{
	}
}
