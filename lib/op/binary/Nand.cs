﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	public partial class Nand:BinaryI
	{
		public const char Up_Arrow = '↑';
		public bool exec(bool a, bool b)
		{
			return !(a&&b);
		}


	}
}
