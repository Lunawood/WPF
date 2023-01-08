using System;
using System.Collections.Generic;
using System.Text;


namespace _09.ListView.ViewModel
{
    public class ViewModel
    {
        private readonly Model.Model items;

        public ViewModel()
        {
            this.items = new Model.Model();
        }

        public Model.Model Items
        {
            get { return this.items; }
        }
    }
}
