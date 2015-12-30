using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern2
{
    public class WindowsPhoneBuilder : IPhoneBuilder
    {
        private MobilePhone _mobilePhone;

        public WindowsPhoneBuilder()
        {
            _mobilePhone = new MobilePhone();
        }

        public WindowsPhoneBuilder(string name)
        {
            _mobilePhone = new MobilePhone(name);
        }

        public void BuildScreen()
        {
            this._mobilePhone.ScreenType = ScreenType.Capacitive;
        }

        public void BuildBattery()
        {
            this._mobilePhone.Battery = Battery.Mh2000;
        }

        public void BuildOS()
        {
            this._mobilePhone.OperatingSystem = OperatingSystem.Windows;
        }

        public MobilePhone MobilePhone
        {
            get
            {
                return this._mobilePhone;
            }
        }
    }
}
