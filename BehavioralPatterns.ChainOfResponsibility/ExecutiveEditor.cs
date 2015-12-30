using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class ExecutiveEditor : IEditor
    {
        public ReviewResult ReviewDocument(Document document)
        {
            ReviewResult result = new ReviewResult();
            result.Reviewer = "Executive Editor";
            result.Approved = !string.IsNullOrWhiteSpace(document.Content) && document.Content.Length > 1000;
            return result;
        }
    }
}
