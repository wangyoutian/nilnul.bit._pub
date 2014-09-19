using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition.predicate
{
    /// <summary>
    /// this is the predicate: (an object) is a type.
    /// </summary>
    public partial class IsType
    {
        public Type type { get; set; }

        public IsType(Type type)
        {
            this.type = type;
        }
					
    }
}
