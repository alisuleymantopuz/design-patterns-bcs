using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactoryPattern2
{
    public static class DeviceFactories
    {
        public static DeviceFactory GetFactory(Brand brand, DeviceType deviceType)
        {
            switch (brand)
            {
                case Brand.Samsung:
                    {
                        switch (deviceType)
                        {
                            case DeviceType.Normal:
                                return new SamsungNormalDeviceFactory(); 
                            case DeviceType.Smart:
                                return new SamsungSmartDeviceFactory(); 
                            default:
                                return null;
                        }
                    }
                    break;
                default:
                    return null;

            }
        }
    }
}
