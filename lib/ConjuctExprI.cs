using System;
namespace nilnul.proposition
{
	public partial interface ConjunctExprI
		: 
		PropositionI
		,
		OpOnSetExprI<PropositionI, PropositionI, PropositionI>, PropositionFormulaI
	{
		
	}
}
