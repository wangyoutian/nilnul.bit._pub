using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	public partial class True
		:
		TrueI
	{

		static private readonly True _Instance = new True();
		static public True Instance
		{
			get
			{
				return _Instance;
			}
		}
		private True()
		{
		}
				
	}
}
