using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic.predicate
{
	/// <summary>
	/// an existant predicate
	/// </summary>
	/// <typeparam name="T">the domain</typeparam>
	public partial interface ExistI<T>
	{

		HashSet<T> domain
		{
			get;
		}
		/// <summary>
		/// the expression, where the para of T is the var.
		/// </summary>
		Func<T,bool> func
		{
			get;
			set;
		}
	}
}
