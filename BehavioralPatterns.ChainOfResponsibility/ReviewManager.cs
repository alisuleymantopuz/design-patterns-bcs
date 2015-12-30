using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class ReviewManager
    {
        public void Process(IList<Document> documents, IEditor editor)
        {
            documents.ToList().ForEach(x =>
            {
                var result = editor.ReviewDocument(x);
                Console.WriteLine(result.Approved ? "Document {0} approved by {1}" : "Document {0} rejected by {1}", x.Id, result.Reviewer);
            });
        }
    }
}
