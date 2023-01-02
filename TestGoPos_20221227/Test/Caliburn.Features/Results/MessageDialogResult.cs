using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Caliburn.Features.Results
{
    public class MessageDialogResult : ResultBase
    {
        private readonly string _content;
        private readonly string _title;

        public MessageDialogResult(string content, string title)
        {
            this._content = content;
            this._title = title;
        }

        public override void Execute(CoroutineExecutionContext context)
        {
            MessageBox.Show(this._content, this._title, MessageBoxButton.OK);

            OnCompleted();
        }
    }
}
