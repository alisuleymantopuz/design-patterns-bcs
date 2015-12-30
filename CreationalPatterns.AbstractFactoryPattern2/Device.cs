using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactoryPattern2
{
    public abstract class Device
    {
        public abstract DeviceType PhoneType { get; } 
    }
}
