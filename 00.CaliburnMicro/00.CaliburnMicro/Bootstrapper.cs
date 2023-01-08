// Bootstrapper.cs
using _00.CaliburnMicro.ViewModels;
using Caliburn.Micro;
using System.Windows;

namespace _00.CaliburnMicro
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // 루트 ViewModel을 확인하고 View를 찾은다음, 둘을 알아서 바인딩해줍니다.
            // 또한, 오버라이드 된 OnStartup에서 호출함으로써, 스플래시 스크린이나 로그인 페이지를
            // 구현하기에 적합합니다.
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}