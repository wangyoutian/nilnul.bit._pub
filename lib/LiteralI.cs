using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	/// <summary>
	/// 命题变项及其否定统称作文字。
	/// </summary>
	public partial interface LiteralI :
		nilnul.obj.LiteralI<bool>
		,
		nilnul.bit.ExprI
	{
	}
}
