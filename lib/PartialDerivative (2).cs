using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.real;
using nilnul.linearAlgebra;
using nilnul.number;

namespace nilnul.calculus
{
	public class PartialDerivative:Derivative
	{
		private Function _f;	//the function
		private Real[] _x0;	//the point;
		private NonnegativeInteger[] _sampleWithReplacement;	//from 0;

		


		public PartialDerivative(Function f,Real[] x0,NonnegativeInteger[] sampleWithReplacement) {
			this._f = f;
			this._x0 = x0;
			this._sampleWithReplacement = sampleWithReplacement;
			
		}

		public PartialDerivative(Function f, Real[] x0, uint[] sampleWithReplacement)
		{
			_sampleWithReplacement=new NonnegativeInteger[sampleWithReplacement.Length];
			this._f = f;
			this._x0 = x0;
			for(uint i=0;i<sampleWithReplacement.Length;i++){
				_sampleWithReplacement[i]=sampleWithReplacement[i];
			}

		}

		public override string ToString()
		{
			return 
			_f.name+"_"+ _sampleWithReplacement.toString()+"("+ _x0.toString() + ")";
			
		}

		public override string name
		{
			get
			{
				return base.name;
			}
			set
			{
				base.name = value;
			}
		}
		///Number of different n partial derivatives of function f which has k coordinates, provided that order of the deriving process is not important.
		///Considering n balls put in k boxes. Then there are k-1 sticks in between the balls. Select n from the n+k-1 balls or sticks, the selection 
		///Note: this is how many kinds of, not the cooefficent of a partial derivative,which is how many of the same partial derivative, if taking into no account of order of the variables.

		static public 


		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="f"></param>
		/// <param name="X0"></param>
		/// <param name="order">order[0]: f will be derived on this variable first;for example: the order is 4,2,2,1; we will get df/dx4, then d(df/dx4)/dx2,...,then d^3 f/dx4dx2dx2;</param>
		/// <returns></returns>
	
	}//class

	static public class PartialDerivative_Extension{

		//public static Real PartialDerivative(Func<List<Real>,Real> f,List<Real> x, uint[] sampleWithReplacement)
		//{
		//    if ( sampleWithReplacement.Length == 0)
		//    {
		//        return f(x);
		//    }
		//    else
		//    {
		//        return new PartialDerivative(f, x.ToArray(), sampleWithReplacement);
		//    }
		//}

	}

}
