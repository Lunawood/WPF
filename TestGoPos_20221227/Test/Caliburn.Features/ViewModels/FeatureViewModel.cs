using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Features.ViewModels
{
    public class FeatureViewModel
    {
        public FeatureViewModel(string title, string description, Type viewModel) 
        {
            this.Title = title;
            this.Description = description;
            this.ViewModel = viewModel;
        }

        public string Title { get; }

        public string Description { get; }

        public Type ViewModel { get; }
    }
}
