﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactoryPattern2
{
    public abstract class DeviceFactory
    {
        public abstract Device CreateDevice();
    }
}
