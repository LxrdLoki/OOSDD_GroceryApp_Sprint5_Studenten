using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Models
{
    public partial class ProductCategory : Model
    {


        public ProductCategory(int id, string name) : base(id, name)
        {

        }
    
    }
}
