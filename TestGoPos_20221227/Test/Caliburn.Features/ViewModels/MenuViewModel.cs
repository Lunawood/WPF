using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Features.ViewModels
{
    public class MenuViewModel : Screen
    {
        private readonly INavigationService _navigationService;

        public MenuViewModel(INavigationService navigationService)
        {
            this._navigationService = navigationService;

            this.Features = new BindableCollection<FeatureViewModel>
            {
                new FeatureViewModel("Binding Conventions(바인딩 규칙)", "Binding view model properties to your view.\r\nView Model로 View를 바인딩합니다. 또한 View 안에서 다른 ViewModel 속성으로 다른 Sub View를 바인딩할 수 있습니다.", typeof(BindingsViewModel)),
                
                new FeatureViewModel("Action Conventions(동작처리(이벤트) 규칙)", "Wiring view events to view model methods.\r\nView의 이벤트를 View Model의 메소드로 전달하기 위한 규칙입니다.", typeof(ActionsViewModel)),

                new FeatureViewModel("Event Aggregator (이벤트 수집기 패턴)", "Send events between uncoupled view models.\r\n서로 연관되지 않은 View Model간에 이벤트를 보내고 받는 모델입니다.\r\n왼쪽 Publisher 쪽에서 이벤트를 Message 형태로 발생시킴\r\n오른쪽 Subscriber 쪽에서 이벤트 수집할지 말지 여부를 결정하고 수집할 경우 Message를 텍스트 컨트롤 컬렉션 영역에 표시합니다.", typeof(EventAggregationViewModel)),

                new FeatureViewModel("Coroutines (코루틴)", "Using IEnumerable<IResult>", typeof(CoroutineViewModel)),
            };
        }

        public BindableCollection<FeatureViewModel> Features { get; }

        public void ShowFeature(FeatureViewModel feature)
        {
            this._navigationService.NavigateToViewModel(feature.ViewModel);
        }
    }
}