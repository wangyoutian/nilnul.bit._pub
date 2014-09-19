using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.logic.proposition.expr;

namespace nilnul.logic.proposition
{
	/// <summary>
	///  
	/// </summary>
	public partial class Inversion
	{

		

		static public IfThen Eval(IfThen ifThen) {
			return new IfThen(ifThen.premise.Not(), ifThen.inference.Not());
		}
	}


}
