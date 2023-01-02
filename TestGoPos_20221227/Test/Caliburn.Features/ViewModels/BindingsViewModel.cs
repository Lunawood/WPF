using Caliburn.Micro;
using Caliburn.Features.ViewModels.Activity;

namespace Caliburn.Features.ViewModels
{
    public class BindingsViewModel : Screen
    {
        private ActivityBaseViewModel _selectedActivity;

        public BindingsViewModel()
        {
            Activities = new BindableCollection<ActivityBaseViewModel>
            {
                new MessageActivityViewModel("Message View One", Lipsum.Get()),
                new PhotoActivityViewModel("Photo View One ", KoreanLipsum.Get()),
                new MessageActivityViewModel("Message View Two", KoreanLipsum.Get()),
                new PhotoActivityViewModel("Photo View Two", Lipsum.Get())
            };

            // Default 선택된 ViewModel
            this._selectedActivity = this.Activities[0];
        }

        public BindableCollection<ActivityBaseViewModel> Activities { get; }

        public ActivityBaseViewModel SelectedActivity
        {
            get { return this._selectedActivity; }
            set { Set(ref this._selectedActivity, value); }
        }
    }
}
