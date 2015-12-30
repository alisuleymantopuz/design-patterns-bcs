using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class Editor : IEditor
    {
        public IEditor Successor { get; private set; }

        public Editor(IEditor successor)
        {
            this.Successor = successor;
        }

        public ReviewResult ReviewDocument(Document document)
        {
            ReviewResult result = new ReviewResult();
            result.Reviewer = "Editor";
            if (!string.IsNullOrWhiteSpace(document.Content))
            {
                if (document.Content.Length > 1000)
                    return Successor.ReviewDocument(document);
                if (document.Content.Length > 600)
                    result.Approved = true;
            }

            return result;
        }
    }
}
