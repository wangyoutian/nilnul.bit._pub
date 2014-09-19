using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	/// <summary>
	/// 
	/// 由于简单命题是真值唯一确定的命题逻辑中最基本的研究单位，所以也称简单命题为命题常项或命题常元。
	/// 
	/// 
	/// </summary>
	/// <remarks>
	/// Each propositional constant (i.e. specific proposition), and each propositional variable (i.e. a variable representing propositions) are wffs. 
/// 
	/// 
	/// </remarks>
	public partial interface ConstI
		: VarI, WellFormedFormulaI
	{
	}
}
