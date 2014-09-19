using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic.proposition
{
	/// <summary>
	/// This is the class to init an instance which wraps an object as propostion.
	/// </summary>
	public partial class PropositionObject
		:PropositionI
	{
		public object obj { get; set; }



		public PropositionObject(object obj)
		{
			if (PropositionDefinition.Instance.isProposition(obj))
			{
				this.obj = obj;
			}
		}

		
		
					
				
	}
}
