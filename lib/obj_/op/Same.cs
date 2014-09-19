using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.obj_.op
{
	public partial class Same
	{
		static public bool Eval(object x, object y) {

			return object.Equals( x ,y);	//
		
		}
	}
}
