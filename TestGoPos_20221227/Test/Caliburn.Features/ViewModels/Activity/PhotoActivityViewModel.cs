using System;

namespace Caliburn.Features.ViewModels.Activity
{
    public class PhotoActivityViewModel : ActivityBaseViewModel
    {
        //Title set 불가시에 아래 내용 사용
        //public PhotoActivityViewModel(string caption) 
        //{
        //    this.Caption = caption;
        //}

        public PhotoActivityViewModel(string title, string caption)
        {
            this.Title = title;
            this.Caption = caption;
        }

        //Title set 불가시에 아래 내용 사용
        //public override string Title => "Photo"; 
        public override string Title { get; set; }

        public string Caption { get; }
    }
}