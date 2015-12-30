using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern
{
    public class SalesReportBuilder : ReportBuilder
    {
        public SalesReportBuilder()
        {
            this._report = new Report("Sales Report");
        }
        public override void BuildHeader()
        {
            this.Report["header"] = "Sales report header...";
        }

        public override void BuildContent()
        {
            this.Report["content"] = "Sales report content...";
        }

        public override void BuildFooter()
        {
            this.Report["footer"] = "Sales report footer...";
        }
    }
}
