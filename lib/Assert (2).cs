using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic
{
	public partial class Assert
	{

		static private readonly Assert _Instance = new Assert();
		static public Assert Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Assert()
		{
		}
		public void eval(bool a)
		{
			if (!a)
			{
				throw new AssertFailException();
			}
		}
		public void eval(bool? a)
		{
			if (a.HasValue)
			{
				eval(a.Value);
				
			}
			else
			{
				throw new AssertFailException();
			}
		}
		static public void Eval(bool a)
		{
			Instance.eval(a);
		}
		static public void Eval(bool? a)
		{
			Instance.eval(a);
		}
		
				
	}
	static public partial class AssertX
	{
		static public void Assert(this bool? a)
		{
			logic.Assert.Instance.eval(a);
		}
	}
}
