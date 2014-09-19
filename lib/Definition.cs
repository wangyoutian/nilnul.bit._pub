using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace nilnul.proposition
{
    public partial class Definition
    {
        public Expression<Func<object,bool>> determinant {
            get;
            set; 
        }

        public Definition(Expression<Func<object,bool>> determinant)
        {
        }
					
        
        
    }
}
