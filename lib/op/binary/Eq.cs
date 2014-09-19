using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	public partial class Eq:BinaryI
	{
		public const char Bidirected_Horizontal_Arrow = '↔';
		public bool exec(bool a, bool b)
		{
			return a==b;
		}
	}
}
