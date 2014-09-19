using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.obj_.op
{
	public partial class Eq
	{
		static public bool Eval(object a,object b) {
			return Same.Eval(a, b);
		}
	}
}
