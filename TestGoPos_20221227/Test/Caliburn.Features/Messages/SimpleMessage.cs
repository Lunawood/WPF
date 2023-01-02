using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Features.Messages
{
    public class SimpleMessage
    {
        public SimpleMessage(string text) 
        {
            this.Text = text;
        }

        public string Text { get; }
    }
}
