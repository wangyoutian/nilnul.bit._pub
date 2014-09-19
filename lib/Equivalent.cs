using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	public sealed partial class Equivalent
		:
		//AbstractSingleSignPropositionOp
		//, 
		EquivalentI
	{

		static private readonly Equivalent _Instance = new Equivalent();
		static public Equivalent Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Equivalent()
		{
		}

		public override string ToString()
		{
				
				return "=";
			
		}
	}
}
