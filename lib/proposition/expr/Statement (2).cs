using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic.proposition.expr
{
	/// <summary>
	/// 
	/// </summary>
	public partial class Statement
		:PropositionI
	{
		public string declarativeSentence { get; set; }

		public Statement(string declarative)
		{
			this.declarativeSentence = declarativeSentence;
		}
					
	}
}
