using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic
{

    /// <summary>
    /// this is the inner 
    /// </summary>
	public partial class Expr
	{
		

		public Expr(bool val)
			:base(val)
			
		{
			
		}

		static public implicit operator Expr(bool val){
			return new Expr(val);

		}
		static public implicit operator bool(Expr val)
		{
			return val.val;
		}
					
	}
}
