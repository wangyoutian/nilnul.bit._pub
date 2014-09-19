using System;
namespace nilnul.proposition
{
	/// <summary>
	/// 合取式
	/// </summary>
	public partial interface ConjunctExprI
		: 
		PropositionI
		,
		OpOnSetExprI<PropositionI, PropositionI, PropositionI>, PropositionBinaryOpExprI, BasicExprI
	{
		
	}
}
