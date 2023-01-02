using System;

namespace Caliburn.Features.ViewModels.Activity
{
    public abstract class ActivityBaseViewModel
    {
        //Title set 불가시에 아래 내용 사용
        //public abstract string Title { get; }
        public abstract string Title { get; set; }
    }
}