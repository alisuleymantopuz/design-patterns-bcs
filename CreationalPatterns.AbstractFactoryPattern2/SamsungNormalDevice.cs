using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactoryPattern2
{
    public class SamsungNormalDevice : NormalDevice
    {
        public Brand Brand { get { return Brand.Samsung; } }
    }
}
