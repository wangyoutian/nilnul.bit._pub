using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.logic.proposition
{
	public partial class TwoGreaterThanOne

	{
		public Func<bool> func{
			get
			{
				return () => 2 > 1;
			}
		}
		
		
	}
}
