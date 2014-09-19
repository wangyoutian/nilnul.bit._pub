using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{

	/// <summary>
	/// <![CDATA[
	///		[(P< Q) * (R< S)*  (P+  R)] => [Q+S]

	///	]]>
	/// </summary>
	public partial interface ConstructiveDilemmaI : InferenceRuleI
	{
	}
}
