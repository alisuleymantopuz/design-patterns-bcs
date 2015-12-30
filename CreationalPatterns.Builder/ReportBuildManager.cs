using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.BuilderPattern
{
    public class ReportBuildManager 
    {
        public void Construct(ReportBuilder builder)
        {
            builder.BuildHeader();
            builder.BuildContent();
            builder.BuildFooter();
            builder.Report.Show();
        }
    }
}
