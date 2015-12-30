using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern2
{
    public class MobilePhone
    {
        public MobilePhone()
        {

        }

        public MobilePhone(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public ScreenType ScreenType { get; set; }
        public OperatingSystem OperatingSystem { get; set; }
        public Battery Battery { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", this.Name, this.ScreenType.ToString(),
                                 this.OperatingSystem.ToString(), this.Battery.ToString());
        }
    }
}
