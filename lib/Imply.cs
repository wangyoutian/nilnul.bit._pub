using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	public partial class Imply
		:
		//AbstractSingleSignPropositionOp
		//,
		ImplyI
		
	{

		static private readonly Imply _Instance = new Imply();
		static public Imply Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Imply()
		{
		}

		public override string  ToString()
		{
				return "<";

		}



		
	}
}
