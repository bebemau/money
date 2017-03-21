using System;
using System.Collections.Generic;

namespace MoneyAPI.Models
{
    public class CategoryResponseModel
    {
        public string Message { get; set; }

        public List<MoneyData.tblCategory> Data { get; set; }

    }

    
}
