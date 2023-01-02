using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Tutorial.Models
{
    public class CategoryModel
    {
        public CategoryModel()
        {
            this.CategoryName = string.Empty;
            this.CategoryDescription = string.Empty;
        }

        public CategoryModel(string categoryName, string categoryDescription)
        {
            this.CategoryName = categoryName;
            this.CategoryDescription = categoryDescription;
        }

        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
