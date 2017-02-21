using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyData
{
    public class BillData
    {
        MoneyEntities moneyContext = new MoneyEntities();

        public List<DisplayBills_Result> GetBills(string vendorID = "")
        {
            int vendorIDNew;
            if(int.TryParse(vendorID, out vendorIDNew))
            {
                var result = moneyContext.DisplayBills(vendorIDNew);
                return result.ToList();
            }
            return moneyContext.DisplayBills(null).ToList();
        }

        public string AddBill(tblBill input)
        {
            moneyContext.tblBills.Add(input);
            moneyContext.SaveChanges();
            return string.Empty;
        }

        public string UpdateBill(tblBill input)
        {
            var result = moneyContext.tblBills.SingleOrDefault(b => b.BillID == input.BillID);
            if (result != null)
            {
                result.CategoryID = input.CategoryID;
                result.Amount = input.Amount;
                result.Description = input.Description;
                result.DueDate = input.DueDate;
                result.EstPaidDate = input.EstPaidDate;
                result.VendorID = input.VendorID;
                moneyContext.SaveChanges();
                return string.Empty;
            }
            else
                return "Bill does not exist.";
        }

        public string DeleteBill(int billID)
        {
            var result = moneyContext.tblBills.SingleOrDefault(b => b.BillID == billID);
            if (result != null)
            {
                moneyContext.tblBills.Remove(result);
                moneyContext.SaveChanges();
                return string.Empty;
            }
            else
                return "Bill does not exist.";
        }
                
    }
}
