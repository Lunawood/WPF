using System.Collections.Generic;

using Caliburn.Micro;

using Caliburn.Features.Helper;
using Caliburn.Features.Results;

namespace Caliburn.Features.ViewModels
{
    public class CoroutineViewModel : Screen
    {
        public IEnumerable<IResult> Execute()
        {
            yield return new VisualStateResult("Loading");

            yield return TaskHelper.Delay(3000).AsResult();

            yield return new VisualStateResult("LoadingComplete");

            yield return new MessageDialogResult("This was executed from a custom IResult, MessageDialogResult.", "IResult Coroutines");
           
        }
    }
}