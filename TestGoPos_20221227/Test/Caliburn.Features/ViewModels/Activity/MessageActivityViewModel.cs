using System;

namespace Caliburn.Features.ViewModels.Activity
{
    public class MessageActivityViewModel : ActivityBaseViewModel
    {
        //Title set 불가시에 아래 내용 사용
        //public MessageActivityViewModel(string message)
        //{
        //    this.Message = message;
        //}

        public MessageActivityViewModel(string title, string message)
        {
            this.Title = title;
            this.Message = message;
        }

        //Title set 불가시에 아래 내용 사용
        //public override string Title => "Message";
        public override string Title { get; set; }

        public string Message { get; }
    }
}
