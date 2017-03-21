using System;
using System.Collections.Generic;

namespace MoneyWin.Model
{
    public class CategoryResponseModel
    {
        public string Message { get; set; }

        public List<CategoryModel> Data { get; set; }

    }

    public class CategoryModel
    {
        public string CategoryID { get; set; }
        public string Category { get; set; }
    }
    
}
