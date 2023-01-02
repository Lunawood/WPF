using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Caliburn.Micro;
using Caliburn.Tutorial.Models;

namespace Caliburn.Tutorial.ViewModels
{
    public class CategoryViewModel : Screen
    {
        private BindableCollection<CategoryModel> _categoryList = new BindableCollection<CategoryModel>();
        private CategoryModel _selectedCategoryModel = new CategoryModel();
        private string _categoryName = string.Empty;
        private string _categoryDescription = string.Empty;

        public BindableCollection<CategoryModel> CategoryList
        {
            get { return _categoryList; }
            set { _categoryList = value; }
        }

        public CategoryModel SelectedCategory
        {
            get { return _selectedCategoryModel; }
            set 
            { 
                _selectedCategoryModel = value;
                NotifyOfPropertyChange(nameof(SelectedCategory));
                //NotifyOfPropertyChange(() => SelectedCategory);
                NotifyOfPropertyChange(nameof(CanEdit));        // Enable / Disable Edit Button Event
                NotifyOfPropertyChange(nameof(CanDelete));      // Enable / Disable Delete Button Event
            }
        }

        public string CategoryName
        {
            get => _categoryName;
            set
            {
                _categoryName = value;
                NotifyOfPropertyChange(nameof(CategoryName));   // This uses CategoryName as the name of the property.
                NotifyOfPropertyChange(nameof(CanSave));        // Enable / Disable Save Button Event
            }
        }

        public string CategoryDescription
        {
            get => _categoryDescription;
            set
            {
                _categoryDescription = value;
                NotifyOfPropertyChange(nameof(CategoryDescription));    // This uses CategoryDescription as the name of the property.
            }
        }

        // Nullable이 아닌 경우 생성자에서 초기화 혹은 변수 선언시 초기화 필요함(.NET 6.0)
        /*
        public CategoryViewModel()
        {
            this._selectedCategoryModel = new CategoryModel();
            this._categoryName = string.Empty;
            this._categoryDescription = string.Empty;
        }
        */

        // View Loading 화면 정의
        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            CategoryList.Add(new CategoryModel { CategoryName = "Meals", CategoryDescription = "Lunches and dinners" });
            CategoryList.Add(new CategoryModel { CategoryName = "Representation", CategoryDescription = "Gifts for our customers" });
        }

        // Enable / Disable Edit Button
        public bool CanEdit
        {
            get
            {
                //return SelectedCategory != null;
                return (SelectedCategory != null)
                    && (!string.IsNullOrEmpty(SelectedCategory.CategoryName));
            }
        }

        // Edit Button Event Handler
        public void Edit()
        {
            CategoryName = SelectedCategory.CategoryName;
            CategoryDescription = SelectedCategory.CategoryDescription;
        }

        // Enable / Disable Delete Button
        public bool CanDelete
        {
            get
            {
                return (SelectedCategory != null)
                    && (!string.IsNullOrEmpty(SelectedCategory.CategoryName));
            }
        }

        // Delete Button Event Handler
        public void Delete()
        {
            CategoryList?.Remove((CategoryModel)SelectedCategory);
            Clear();
        }

        // Enable / Disable Save Button
        public bool CanSave
        {
            get
            {
                return (CategoryName?.Length > 2);
            }
        }

        public void Save()
        {
            CategoryModel newCategory = new CategoryModel();
            newCategory.CategoryName = CategoryName;
            newCategory.CategoryDescription = CategoryDescription;

            if (SelectedCategory != null)
            {
                // remove the existing category, needed to update the view
                CategoryList.Remove(SelectedCategory);
            }

            CategoryList.Add(newCategory);
            Clear();
        }

        public void Clear()
        {
            CategoryName = string.Empty;
            CategoryDescription = string.Empty;
            //SelectedCategory = null;
            SelectedCategory = new CategoryModel();
        }

    }
}