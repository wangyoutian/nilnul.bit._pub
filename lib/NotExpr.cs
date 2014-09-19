using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.proposition
{
	/// <summary>
	/// 否定式
	/// </summary>
	public partial class NotExpr
		:
		PropositionUnaryOpExprA
		,
		NotExprI

	{
		public NotExpr(PropositionI operand):base(operand)
		{
		}










	

		public  override UnaryOpI<PropositionI, PropositionI> op
		{
			get { 
				return Not.Instance;
			}

			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
