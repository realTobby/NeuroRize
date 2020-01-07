﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuroRize.CORE.Interfaces;

namespace NeuroRize.CORE.ActivationFunctions
{
    public class StepActivationFunction : IActivationFunction
    {
        private double _treshold;

        public StepActivationFunction(double treshold)
        {
            _treshold = treshold;
        }

        public double CalculateOutput(double input)
        {
            return Convert.ToDouble(input > _treshold);
        }
    }
}
