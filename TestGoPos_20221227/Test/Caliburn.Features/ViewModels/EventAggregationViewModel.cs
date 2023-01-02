using Caliburn.Micro;
using Caliburn.Features.ViewModels.Events;

namespace Caliburn.Features.ViewModels
{
    public class EventAggregationViewModel : Screen
    {
        public EventAggregationViewModel(IEventAggregator eventAggregator)
        {
            this.Source = new EventSourceViewModel(eventAggregator);
            this.Destination = new EventDestinationViewModel(eventAggregator);
        }

        // Event Publisher 
        public EventSourceViewModel Source { get; }

        // Event Subscriber 
        public EventDestinationViewModel Destination { get; }
    }
}