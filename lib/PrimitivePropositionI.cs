using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	/// <summary>
	/// 2是偶素数； 2或4是素数； 如果2是素数，则3也是素数； 2是素数当且仅当3也是素数。 全是命题。     上述命题都是通过诸如“或”，“如果……，则……”等连词联结而成，这样命题，称为复合命题。相对地，构成复合命题的命题称为简单命题。 


	/// </summary>
	public partial interface PrimitivePropositionI
		: FormulaI
	{
	}
}
