using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactoryPattern2
{
    public class SamsungNormalDeviceFactory : DeviceFactory
    { 

        public override Device CreateDevice()
        {
            return new SamsungNormalDevice();
        }
    }
}
