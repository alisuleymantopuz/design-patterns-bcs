using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern
{
    public class StatusReportBuilder : ReportBuilder
    {
        public StatusReportBuilder()
        {
            this._report = new Report("Status Report");
        }
        public override void BuildHeader()
        {
            this.Report["header"] = "Status report header...";
        }

        public override void BuildContent()
        {
            this.Report["content"] = "Status report content...";
        }

        public override void BuildFooter()
        {
            this.Report["footer"] = "Status report footer...";
        }
    }
}
