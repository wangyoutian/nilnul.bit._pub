using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.proposition
{

	/// <summary>
	/// 否定联结词
	/// </summary>
	public partial class Not
		:
		//AbstractSingleSignPropositionOp
		//,
		NotI
	{


		static private readonly Not _Instance = new Not();
		static public Not Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Not()
		{
		}

		public override string ToString()
		{
					return "-";	
			
			
		}


		

		
		
	}
}
