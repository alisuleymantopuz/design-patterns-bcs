using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern3
{
    public class MessageCreator
    {
        public static Message Create()
        {
            Message message = new Message();
            message.Content =
                "Lorem ipsum dolor sit amet. İpsum dolor sit amet. Dolor sit amet. Lorem ipsum dolor sit amet. İpsum dolor sit amet. Dolor sit amet.";
            message.Title = "Lorem ipsum dolor sit amet.";
            message.PublishDate = DateTime.Now;

            return message;
        }
    }
}
