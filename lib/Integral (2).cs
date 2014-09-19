using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.realNumber;


namespace nilnul.realNumber.calculus
{
    /// <summary>
    /// 
    /// </summary>
    public class Integral : IntegralI
    {
        public Integral(ExtendedRealI lower,ExtendedRealI upper, Func<RealI,RealI> function) {
            this.lower = lower;
            this.upper = upper;
            this.function = function;
        }

		public ExtendedRealI upper
		{
			set;
			get;
		}

		public ExtendedRealI lower
		{
			set;
			get;
		}

		public Func<RealI, RealI> function
		{
			set;
			get;
		}

    }
}
