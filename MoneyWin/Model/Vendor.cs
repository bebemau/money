using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyWin.Model
{
    public class VendorResponseModel
    {
        public string VendorID {get;set;}
        public string VendorName { get; set; }
        public string IsBank { get; set; }
        
        public string Active { get; set; }
    }
}
