using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	public partial class Statement
		:
		StatementI
	{
		public string content
		{
			get;
			set;
		}


		public Statement(string content)
		{
			this.content = content;
		}
					
	}
}
