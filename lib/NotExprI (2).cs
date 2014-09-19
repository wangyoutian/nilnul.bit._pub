using System;
using nilnul;


namespace nilnul.proposition
{
	/// <summary>
	/// 否定式
	/// </summary>
	public partial interface NotExprI
		: PropositionI
		, UnaryOpExprI<PropositionI, PropositionI, PropositionI>
	{
		
	}
}
