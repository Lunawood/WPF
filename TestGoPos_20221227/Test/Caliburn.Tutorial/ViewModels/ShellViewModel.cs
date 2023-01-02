using System.Dynamic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using Caliburn.Micro;

namespace Caliburn.Tutorial.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private readonly IWindowManager _windowManager;

        public ShellViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }

        protected async override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await EditCategories();
        }

        public Task EditCategories()
        {
            var viewmodel = IoC.Get<CategoryViewModel>();
            return ActivateItemAsync(viewmodel, new CancellationToken());
        }

        public bool CanFileMenu
        {
            get
            {
                return false;
            }
        }

        public Task About()
        {
            //단순 Dialog modeless form
            //return _windowManager.ShowDialogAsync(IoC.Get<AboutViewModel>());

            //Dialog Dialog Result 포함
            /*
            Task<bool?> ret = _windowManager.ShowDialogAsync(IoC.Get<AboutViewModel>());
            MessageBox.Show(ret.Result.ToString());
            return ret;
            */

            dynamic settings = new ExpandoObject();
            settings.WindowStartupLocation = WindowStartupLocation.Manual; //.CenterOwner;
            settings.ResizeMode = ResizeMode.NoResize;
            settings.MinWidth = 600;
            settings.Title = "My New Window2";
            //settings.Icon = new BitmapImage(new System.Uri("pack://application:,,,/Caliburn.Tutorial;Assets/logo.ico"));

            IWindowManager manager = new WindowManager();
            Task<bool?> ret = manager.ShowDialogAsync(IoC.Get<AboutViewModel>(), null, settings);
            MessageBox.Show(ret.Result.ToString());
            return ret;
        }
    }
}
