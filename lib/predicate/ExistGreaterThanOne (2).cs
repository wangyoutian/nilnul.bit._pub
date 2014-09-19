using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.logic.predicate
{

	/// <summary>
	/// this is true.
	/// </summary>
	public partial class ExistGreaterThanOne
		:ExistI<BigInteger>
	{

		public bool proved
		{
			get
			{
				return true;
			}
			
		}



		#region ExistI<BigInteger> Members

		public Func<BigInteger, bool> func
		{
			get
			{
				return (BigInteger x)=>x>1;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#endregion

		#region ExistI<BigInteger> Members

		public HashSet<BigInteger> domain
		{
			get
			{
				return new HashSet<BigInteger>();
			}
		}

		#endregion
	}
}
