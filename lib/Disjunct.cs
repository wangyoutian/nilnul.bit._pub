using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.proposition
{
	public partial class Disjunct
		: 
		
		//AbstractSingleSignPropositionOp
		
		
		//, 
		DisjunctI
		
	{

		static private readonly Disjunct _Instance = new Disjunct();
		static public Disjunct Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Disjunct()
		{
		}
				

		#region IOp Members

		public override string ToString()
		{
			
				return "+"; //'\u8745'; 
			
		}

		#endregion

		
	}
}
