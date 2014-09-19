using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.lang.op.binary;

namespace nilnul.proposition.op
{
	public partial interface IPropositionBinaryOp 
		: IPropositionOp
		, IBinaryOp<IProposition, IProposition,IProposition>
	{
	}
}
