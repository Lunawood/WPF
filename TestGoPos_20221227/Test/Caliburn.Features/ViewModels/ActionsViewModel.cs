using System.Threading.Tasks;

using Caliburn.Micro;
using Caliburn.Features.Helper;

namespace Caliburn.Features.ViewModels
{
    public class ActionsViewModel : Screen
    {
        private string output = string.Empty;

        public string Output 
        { 
            get { return output; } 
            set { Set(ref output, value); } 
        }

        public void Clear() => Output = string.Empty;

        public void SimpleSayHello() => Output = "Hello from Caliburn.Micro";

        public void SayHello(string name) => Output = $"Hello {name}";

        public bool CanSayHello(string name) => !string.IsNullOrEmpty(name);

        public Task SayGoodbyeAsync(string name)
        {
            Output = $"Goodbye {name}";

            return TaskHelper.FromResult(true);
        }

        public bool CanSayGoodbye(string name) => !string.IsNullOrEmpty(name);
    }
}
