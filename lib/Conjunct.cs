using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.proposition
{
	public class Conjunct 
		
		:
		//AbstractSingleSignPropositionOp
		
		//, 
		ConjunctI
		
	{

		static private readonly Conjunct _Instance = new Conjunct();
		static public Conjunct Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Conjunct()
		{
		}

		

		

		#region IOp Members

		public override string ToString()
		{
			
				return "*"; 
			
		}

		#endregion

		
	}
}
