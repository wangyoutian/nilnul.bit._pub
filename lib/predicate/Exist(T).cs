using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.element.collection.set;

namespace nilnul.logic.predicate
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Exist<T>
	{
		nilnul.element.collection.set.SetI<T> _domain2;
		HashSet<T> _domain;
		Func<T, bool> _func;

		public Exist(nilnul.element.collection.set.SetI<T> domain2,Func<T,bool> func)
		{

		}
					


	}
}
