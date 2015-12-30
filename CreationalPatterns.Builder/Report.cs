using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.BuilderPattern
{
    public class Report
    {
        private string _reportType;

        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        // Constructor
        public Report(string reportType)
        {
            this._reportType = reportType;
        }

        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n ---------------------------");
            Console.WriteLine(" \t Report Type: {0}", _reportType);
            Console.WriteLine(" \t\t Header : {0}", _parts["header"]);
            Console.WriteLine(" \t\t Content : {0}", _parts["content"]);
            Console.WriteLine(" \t\t Footer : {0}", _parts["footer"]);
        }
    }
}
