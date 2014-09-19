﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	public partial class NonImply:BinaryI
	{
		public const char Unicode = '\u219b';	//↛

		static public bool Eval(bool x, bool y)
		{
			return !(ImplyX.Eval_byExpr(x, y));

		}



		public NonImply()
		{
		}
				

		public bool exec(bool a, bool b)
		{
			return Eval(a, b);
		}

		public class Singleton
			:SingletonByDefaultNew<NonImply>
		{


		}
	}
}
