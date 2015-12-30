using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.ProxyPattern
{
    public interface IRssReaderService
    {
        void Initialize();
        List<RssItem> GetRssData();
    }
}
