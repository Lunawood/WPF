using Caliburn.Micro;
using Caliburn.Tutorial.Models;
using System.Threading.Tasks;

namespace Caliburn.Tutorial.ViewModels
{
    public class AboutViewModel : Screen
    {
        private AboutModel _aboutData = new AboutModel();

        public AboutModel AboutData
        {
            get { return _aboutData; }
        }

        public Task CloseForm()
        {
            return TryCloseAsync(true);     // for OK
            //return TryCloseAsync(false);  // for Close
            //return TryCloseAsync();       // for null 
        }
    }
}
