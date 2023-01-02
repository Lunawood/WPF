using Caliburn.Micro;
using System.Windows;
using TestCalibrunMicro.ViewModels;

namespace TestCalibrunMicro
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //DisplayRootViewForAsync<ShellViewModel>().ConfigureAwait(true);
            DisplayRootViewForAsync<ShellViewModel>();

            //base.OnStartup(sender, e);
        }
    }
}