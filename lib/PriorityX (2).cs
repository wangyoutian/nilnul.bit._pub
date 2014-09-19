using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;






namespace nilnul.proposition
{
	static public  partial class PriotyX
	{

		/// <summary>
		/// the bigger the more prior
		/// </summary>
		static public readonly Type[][] TypeEchelon = {

			new [] {typeof(EquivExprI)}
			,
			new [] {typeof(ImplyExprI)}
			,
			new [] {typeof(DisjunctExprI)}
			,
			new [] {typeof(ConjunctExprI)}
			,
			new [] {typeof(NotExprI)}
			//,
			//new [] {typeof(PropositionVarI)}

		   
		};


		static public int Order(this PropositionI p)
		{
			for (int i = 0; i < TypeEchelon.Length; i++)
			{
				for (int j = 0; j <TypeEchelon[i].Length ; j++)
				{
			
					 if (TypeEchelon[i][j].IsInstanceOfType(p))
						//if (TypeEchelon[i].Contains(op.GetType().))
					{
						return i;
					}
				}
				
			}
			throw new Exception();

		}

		static public int Order(this Type t)
		{
			//TypeFilter typeFilter=(x,y)=>x==y;
			if (t.FindInterfaces((x, y) => x == y, typeof(PropositionOpI)).Any())
			{
				for (int i = 0; i < TypeEchelon.Length; i++)
				{
					if (TypeEchelon[i].Contains(t))
					{
						return i;
					}
				}
				throw new Exception();
			}
			throw new Exception();

		}

		static public int Prior(this PropositionI a, PropositionI b)
		{
			return Order(a) - Order(b);

		}


		


	}
}
