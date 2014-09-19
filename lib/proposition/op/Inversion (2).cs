using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic.proposition.op
{
	/// <summary>
	/// this is the class to generate an instance that:
	///		is the relation between two propostions. It's commutive.
	/// </summary>
	public partial class Inversion
	{

		static private readonly Inversion _Instance = new Inversion();
		static public Inversion Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Inversion()
		{
		}
		
		
	}
}
