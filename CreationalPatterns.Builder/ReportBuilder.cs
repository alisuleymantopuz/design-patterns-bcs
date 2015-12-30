using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern
{
    public abstract class ReportBuilder
    {
        protected Report _report;

        // Gets vehicle instance
        public Report Report
        {
            get { return _report; }
        }

        // Abstract build methods
        public abstract void BuildHeader();
        public abstract void BuildContent();
        public abstract void BuildFooter();
    }
}
