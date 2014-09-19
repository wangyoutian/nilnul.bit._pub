using System;


namespace nilnul.proposition
{
	/// <summary>
	/// 合取联结词
	/// </summary>
	public partial interface ConjunctI
		: 
		PropositionBinaryOpI
		, 
		OpOnSetI<PropositionI,PropositionI>
	{

	}

}
