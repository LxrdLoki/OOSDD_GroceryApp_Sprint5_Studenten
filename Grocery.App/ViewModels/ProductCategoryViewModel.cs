using Grocery.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.App.ViewModels
{
    public partial class ProductCategoryViewModel : BaseViewModel
    {
        private readonly IProductCategoryService _productCategoryService;


        public ProductCategoryViewModel(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
            Title = "Categories";
        }

    }
}
