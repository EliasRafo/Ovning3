using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // NumericInputError class that inherits from UserError
    internal class NumericInputError : UserError
    {
        // Override of UEMessage()
        public override string UEMessage() 
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
}
