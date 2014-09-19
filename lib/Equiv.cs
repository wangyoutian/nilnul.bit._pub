using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	public sealed partial class Equiv
		:
		//AbstractSingleSignPropositionOp
		//, 
		EquivI
	{

		static private readonly Equiv _Instance = new Equiv();
		static public Equiv Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Equiv()
		{
		}

		public override string ToString()
		{
				
				return "=";
			
		}
	}
}
