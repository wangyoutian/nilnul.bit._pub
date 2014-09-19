using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace nilnul.proposition
{
	class TestExprTransform
	{
		static void Main(string[] args)
		{
			PropositionI p=new Var("a");
			PropositionI b = new Var("a");

			p.Conjunct(p).Equiv(p).Conjunct(p).Not().Imply(p).UsingBasicOps().ToConsoleLine();
			p.Conjunct(p).Equiv(p).Conjunct(p).Not().Imply(p).ToConsoleLine();
			p.Equiv(b).UsingBasicOps().ToConsoleLine();

			Console.Read();


		}
	}
}
