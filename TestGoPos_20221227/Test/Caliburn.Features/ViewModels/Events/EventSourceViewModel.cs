using System;
using System.Threading;

using Caliburn.Micro;
using Caliburn.Features.Messages;

namespace Caliburn.Features.ViewModels.Events
{
    public class EventSourceViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;
        private string text;

        public EventSourceViewModel(IEventAggregator eventAggregator)
        {
            this._eventAggregator = eventAggregator;
            this.text = string.Empty;
        }

        public string Text
        {
            get { return text; }
            set { Set(ref text, value); }
        }

        // Event Publish Action 
        public async void Publish()
        {
            await _eventAggregator.PublishOnUIThreadAsync(new SimpleMessage(Text), CancellationToken.None);
        }
    }
}