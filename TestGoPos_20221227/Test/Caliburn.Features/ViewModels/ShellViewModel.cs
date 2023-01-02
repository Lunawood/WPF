using System.Windows.Controls;

using Caliburn.Micro;

namespace Caliburn.Features.ViewModels
{
    public class ShellViewModel : Screen
    {
        private readonly SimpleContainer _container;
        private INavigationService _navigationService;

        public ShellViewModel(SimpleContainer container)
        {
            this._container = container;
            //this._navigationService = new FrameAdapter(null, false);
        }

        public void RegisterFrame(Frame frame)
        {
            this._navigationService = new FrameAdapter(frame);

            this._container.Instance(this._navigationService);

            this._navigationService.NavigateToViewModel(typeof(MenuViewModel));
        }
    }
}
