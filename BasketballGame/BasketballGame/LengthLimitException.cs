using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballGame
{
    internal class LengthLimitException : Exception
    {
        public LengthLimitException(string text) : base(string.Format(text))
        {

        }
    }
}
