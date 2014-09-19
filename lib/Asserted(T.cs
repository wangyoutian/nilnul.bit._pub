﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Asserted<T>
	{
		public Asserted(T value, Func<T, bool> be)
		{
			nilnul.bit.Assertion.True(be(value));

			this.val = value;
			this._be = be;

		}


		static public void Assert(T val, Func<T,bool> func) {
			nilnul.bit.Assertion.True(func(val));
		}


		private T _val;
		public T val
		{
			get { return _val; }
			set
			{

				_val = value;
			}
		}

		private Func<T, bool> _be;

		public Func<T, bool> be
		{
			get { return _be; }
			set { _be = value; }
		}


		static public Asserted<T> Create_froDualFunc(T val,Func<T,bool> be) {

			return new Asserted<T>(val, c=>!be(c));
		
		}

	}
}
