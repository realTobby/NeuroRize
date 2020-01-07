using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroRize.CORE.Interfaces
{
    public interface IInputFunction
    {
        double CalculateInput(List<ISynapse> inputs); 
    }
}
