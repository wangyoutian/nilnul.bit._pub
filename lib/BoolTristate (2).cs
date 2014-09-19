using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	static public class BoolTristate
	{
		static public bool? And(this bool? a, bool? b) {
			if (a==true)
			{
				if (b==true)
				{
					return true;
					
				}

				else if (b==null)
				{
					return null;
					
				}
				else
				{
					return false;
				}
				
				
			}
			else
			{
				return And(b, a);
			}
			
		}

		static public bool? And(this bool a, bool? b) {
			return ((bool?)a).And(b);
		}
	}
}
