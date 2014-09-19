using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic.proposition.expr
{
	/// <summary>
	/// an instance that
	///		is a proposition in the form of an inference
	/// </summary>
	public partial class IfThen
	{
		public PropositionI premise { get; set; }
		public PropositionI inference { get; set; }

		public IfThen(PropositionI premise, PropositionI inference)
		{
			this.premise = premise;
			this.inference = inference;
		}
					

	}
}
