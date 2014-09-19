using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial interface PredicateI2<T>:PredicateI
	{
		bool be(T obj);
	}
}
