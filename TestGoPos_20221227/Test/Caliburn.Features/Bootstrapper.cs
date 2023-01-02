using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using Caliburn.Features.ViewModels;
using Caliburn.Features.Views;
using Caliburn.Micro;

namespace Caliburn.Features
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            //base.Configure();
            _container = new SimpleContainer();

            _container.Instance(_container);

            _container.Singleton<IWindowManager, WindowManager>();
            _container.Singleton<IEventAggregator, EventAggregator>();

            //_container
            //    .PerRequest<ShellViewModel>()
            //    .PerRequest<MenuViewModel>()
            //    .PerRequest<BindingsViewModel>();
            GetType().Assembly.GetTypes().Where(type => type.IsClass).Where(type => type.Name.EndsWith("ViewModel", StringComparison.CurrentCulture)).ToList()
            .ForEach(vmType => _container.RegisterSingleton(vmType, nameof(vmType), vmType));
        }

        protected override async void OnStartup(object sender, StartupEventArgs e)
        {
            //base.OnStartup(sender, e);
            await DisplayRootViewForAsync<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return this._container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return this._container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            this._container.BuildUp(instance);
        }

        protected override void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            //base.OnUnhandledException(sender, e);
            e.Handled = true;
            MessageBox.Show(e.Exception.Message, "An error as occurred", MessageBoxButton.OK);
        }
    }
}
