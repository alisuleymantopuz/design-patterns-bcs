using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StructuralPatterns.ProxyPattern
{
    public class RssReaderService : IRssReaderService
    {
        private List<RssItem> _rssItems;

        public List<RssItem> GetRssData()
        {
            return _rssItems;
        }

        public void Initialize()
        {
            _rssItems = new List<RssItem>();

            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var channel = wc.DownloadString("http://www.zaman.com.tr/sondakika.rss");
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(channel);
            XmlNodeList nodeList = xDoc.DocumentElement.SelectNodes("channel/item");
            int itemIndex = 1;
            foreach (XmlNode node in nodeList)
            {
                Console.WriteLine("{0} New item getting...", itemIndex);
                RssItem rssItem = new RssItem();

                var singleNode = node.SelectSingleNode("title");
                if (singleNode != null)
                    rssItem.Title = singleNode.InnerText;

                var selectSingleNode = node.SelectSingleNode("pubDate");
                if (selectSingleNode != null)
                    rssItem.PubDate = selectSingleNode.InnerText;

                itemIndex++;

                _rssItems.Add(rssItem);
            }
        }
    }
}
