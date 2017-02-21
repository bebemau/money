using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyData
{
    public class BalanceData
    {
        MoneyEntities moneyContext = new MoneyEntities();

        public double GetBalance()
        {
            var result =  moneyContext.DisplayBalance().FirstOrDefault();
            return Convert.ToDouble(result);
        }
                
    }
}
