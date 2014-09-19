using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{

	/// <summary>
	/// <![CDATA[
	///		[(P< Q) * (Q< R)] => [P<  R]
				
	///	]]>
	/// </summary>
	public partial interface HypotheticalSyllogismI : InferenceRuleI
	{
	}
}
