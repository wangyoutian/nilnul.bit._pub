using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic
{
	public partial class False
		:
		FalseI
	{

		static private readonly False _Instance = new False();
		static public False Instance
		{
			get
			{
				return _Instance;
			}
		}
		private False()
		{
		}
				
	}
}
