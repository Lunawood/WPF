using System;
using System.Threading;
using System.Threading.Tasks;

using Caliburn.Micro;
using Caliburn.Features;
using Caliburn.Features.Messages;

namespace Caliburn.Features.ViewModels.Events
{
    public class EventDestinationViewModel : Screen, IHandle<SimpleMessage>
    {
        private readonly IEventAggregator _eventAggregator;

        public EventDestinationViewModel(IEventAggregator eventAggregator)
        {
            this._eventAggregator = eventAggregator;

            this.Messages = new BindableCollection<SimpleMessage>();
        }

        // Event Subscribe Action 
        public void Subscribe()
        {
            this._eventAggregator.SubscribeOnPublishedThread(this);
        }

        // Event Unsubscribe Action
        public void Unsubscribe()
        {
            this._eventAggregator.Unsubscribe(this);
        }

        // Event Handle Action
        public Task HandleAsync(SimpleMessage message, CancellationToken cancellationToken)
        {
            this.Messages.Add(message);

            return Task.FromResult(true);
        }

        // 이벤트 수신 메시지를 계속 보관하기 위한 저장소
        public BindableCollection<SimpleMessage> Messages { get; }
    }
}