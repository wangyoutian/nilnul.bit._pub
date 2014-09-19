using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.logic.proposition.expr;

namespace nilnul.logic.proposition.op
{
	/// <summary>
	/// this class generates a instance that
	///		is a relation between two propostions.
	/// </summary>
	public partial class Contraposition
	{

		static private readonly Contraposition _Instance = new Contraposition();
		static public Contraposition Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Contraposition()
		{
		}

		public bool isContrapostion(PropositionI a,PropositionI b) {
			throw new Exception();
		
		}

		public IfThen call(IfThen ifThen) {
			return new IfThen(ifThen.inference.Not(), ifThen.premise.Not());
		
		}
				
	}
}
