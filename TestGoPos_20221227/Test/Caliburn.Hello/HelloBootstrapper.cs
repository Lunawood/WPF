using System.Windows;

using Caliburn.Hello.ViewModels;
using Caliburn.Micro;

namespace Caliburn.Hello
{
    public class HelloBootstrapper : BootstrapperBase
    {
        public HelloBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //base.OnStartup(sender, e);
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}
