﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Custom1 : UserError
    {
        public override string UEMessage()
        {
            return "This is Custom1 class";
        }
    }
}
