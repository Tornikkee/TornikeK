using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballGame
{
    internal class NumberLimitException : Exception
    {
        public NumberLimitException(string text) : base(string.Format(text))
        {

        }
    }
}
