using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyData
{
    public class VendorData
    {
        MoneyEntities moneyContext = new MoneyEntities();

        public List<tblVendor> GetVendors(string vendorID)
        {
            var result = moneyContext.tblVendors;
            int vendorIDNew;
            if (int.TryParse(vendorID, out vendorIDNew))
                return result.Where(a => a.VendorID == vendorIDNew).ToList();
            return result.ToList();
        }

        public string AddVendor(tblVendor vendor)
        {
            moneyContext.tblVendors.Add(vendor);
            moneyContext.SaveChanges();
            return string.Empty;
        }

        public string UpdateVendor(tblVendor vendor)
        {
            var result = moneyContext.tblVendors.SingleOrDefault(b => b.VendorID == vendor.VendorID);
            if (result != null)
            {
                result.VendorName = vendor.VendorName;
                result.Active = vendor.Active;
                result.IsBank = vendor.IsBank;
                moneyContext.SaveChanges();
                return string.Empty;
            }
            else
                return "Vendor does not exist.";
        }

        public string DeleteVendor(int vendorID)
        {
            var result = moneyContext.tblVendors.SingleOrDefault(b => b.VendorID == vendorID);
            if (result != null)
            {
                var bill = moneyContext.tblBills.SingleOrDefault(b => b.VendorID == vendorID);
                var transactionBank = moneyContext.tblTransactions.SingleOrDefault(b => b.BankID == vendorID);
                var transactionVendor = moneyContext.tblTransactions.SingleOrDefault(b => b.VendorID == vendorID);
                var paymentFrom = moneyContext.tblPayments.SingleOrDefault(b => b.BankID == vendorID);
                var paymentTo = moneyContext.tblPayments.SingleOrDefault(b => b.TransferTo == vendorID);

                if (bill == null && transactionBank == null && transactionVendor == null && paymentFrom == null && paymentTo == null)
                {
                    moneyContext.tblVendors.Remove(result);
                    moneyContext.SaveChanges();
                    return string.Empty;
                }
                else
                    return "Vendor cannot be deleted due to related transactions.";
            }
            else
                return "Vendor does not exist.";
        }
                
    }
}
