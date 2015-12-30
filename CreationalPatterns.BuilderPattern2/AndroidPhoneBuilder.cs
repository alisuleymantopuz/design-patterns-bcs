using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern2
{
    public class AndroidPhoneBuilder : IPhoneBuilder
    {
        private MobilePhone _mobilePhone;

        public AndroidPhoneBuilder()
        {
            _mobilePhone = new MobilePhone();
        }

        public AndroidPhoneBuilder(string name)
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
            this._mobilePhone.OperatingSystem = OperatingSystem.Android;
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
