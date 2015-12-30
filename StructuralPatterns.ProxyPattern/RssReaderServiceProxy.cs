using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.ProxyPattern
{
    public class RssReaderServiceProxy : IRssReaderService
    {
        public IRssReaderService RssReaderService { get; private set; }

        public void Initialize()
        {
            this.RssReaderService = new RssReaderService();
            this.RssReaderService.Initialize();
        }

        public List<RssItem> GetRssData()
        {
            return this.RssReaderService.GetRssData();
        }
    }
}
