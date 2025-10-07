using Grocery.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.App.ViewModels
{
    public partial class CategoriesViewModel : BaseViewModel
    {
        private readonly ICategoryService _categoryService;


        public CategoriesViewModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            Title = "Categories";
        }

    }
}
