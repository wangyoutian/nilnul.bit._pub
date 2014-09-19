using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	/// <summary>
	/// something known to be true.
	/// </summary>
	public partial interface KnowledgeI
	{
		void add(ProveExprI proveExpr);
	}
}
