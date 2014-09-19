using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real;


namespace nilnul.math.calculus
{
    /// <summary>
    /// 
    /// </summary>
    public class Integral
    {
        public Integral(IReal lower,IReal upper, IFunction<IReal,IReal> function) {
            this.lower = lower;
            this.upper = upper;
            this.function = function;
        }

        public IReal upper {
            set {
                this["upper"] = value;
            }
            get {
                return this["upper"];
            }
        }

        public IReal lower {
            set
            {
                this["lower"] = value;
            }
            get
            {
                return this["lower"];
            }
        }

        public IFunction function {
            set {
                this["function"] = value;

            }
            get {
                return this["function"];
            }
        }

    }
}
