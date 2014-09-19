using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic.proposition
{
	/// <summary>
	/// This is the class to generate an instance that is the definition of Proposition.
	/// As a definition, the generated instance
		/// will determine whether an object is propostion;
		/// wrap the object as a propostion.
	/// </summary>
	public partial class PropositionDefinition
	{


		static private readonly PropositionDefinition _Instance = new PropositionDefinition();
		static public PropositionDefinition Instance
		{
			get
			{
				return _Instance;
			}
		}
		private PropositionDefinition()
		{
		}


		
		public bool isProposition(object o) {
			throw new Exception();
		}

		
					
				
	}
}
