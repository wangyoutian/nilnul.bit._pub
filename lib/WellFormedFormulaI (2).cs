using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{

	/// <summary>
	/// (1)单个命题变项是合式公式，并称为原子命题公式。 
	/// (2)若A是合式公式，则(┐A)也是合式公式。 
	/// (3)若A，B是合式公式，则(A∧B)，(A∨B)，(A→B)，(AB)也是合式公式。 
	/// (4)只有有限次地应用(1)～(3)形式的符号串才是合式公式。 
	/// </summary>
	/// <remarks>
	/// 定义给出的合式公式的定义方式称为归纳定义方式，下文中还将多次出现这种定义方式。 
	/// </remarks>
	public partial interface WellFormedFormulaI
	{
		
	}
}
