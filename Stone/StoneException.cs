using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone
{
    class StoneException : Exception
    {
        public StoneException(string m) : base(m)
        {
            
        }
    }
}
