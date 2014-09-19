using System;
namespace nilnul.proposition
{
	public partial interface DisjunctExprI 
		:

		PropositionI, OpOnSetExprI<PropositionI, PropositionI, PropositionI>, PropositionBinaryOpExprI, BasicExprI
	{
		
	}
}
