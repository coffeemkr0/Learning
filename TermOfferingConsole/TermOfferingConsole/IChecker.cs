﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    public interface IChecker
    {
        bool Check(TermOffering termOffering, PrintLogger logger);
    }
}
