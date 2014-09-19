using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Assert<T,TBe>
		:
		be.Assert2<T>

		where TBe:BeI<T>,new()
		
	{
	
		

		public Assert()
			:base(SingletonByDefaultNew<TBe>.Instance)
		{
			
		}





	}
}
