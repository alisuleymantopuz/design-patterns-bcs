using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactoryPattern2
{
    public class NormalDevice : Device
    {
        public override DeviceType PhoneType
        {
            get { return DeviceType.Normal; }
        } 
    }
}
