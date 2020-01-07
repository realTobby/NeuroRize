﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroRize.CORE.Interfaces
{
    public interface IActivationFunction
    {
        double CalculateOutput(double input);
    }
}
