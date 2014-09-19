using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic.predicate
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Exist<T>
		:ExistI<T>
	{




		#region ExistI<T> Members

		public HashSet<T> domain
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public Func<T, bool> func
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#endregion
	}
}
