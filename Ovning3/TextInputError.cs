using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // TextInputError class that inherits from UserError
    internal class TextInputError : UserError
    {
        // Override of UEMessage()
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
}
