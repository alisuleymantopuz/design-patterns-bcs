using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.DecoratorPattern
{
    public class OpelAstra : Vehicle
    {
        public string Make
        {
            get { return "OpelAstra"; }
        }

        public string Model
        {
            get { return "Cosmo"; }
        }

        public double Price
        {
            get { return 65000; }
        }
    }

}
