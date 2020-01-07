﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuroRize.CORE.Interfaces;

namespace NeuroRize.CORE.ActivationFunctions
{
    public class RectifiedActivationFuncion : IActivationFunction
    {
        public double CalculateOutput(double input)
        {
            return Math.Max(0, input);
        }
    }
}
