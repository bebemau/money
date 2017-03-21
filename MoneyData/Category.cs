using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyData
{
    public class CategoryData
    {
        MoneyEntities moneyContext = new MoneyEntities();

        public Tuple<string, List<tblCategory>> GetCategories(string categoryID = "")
        {
            int categoryIDNew=0;
            var result = moneyContext.tblCategories;

            if (string.IsNullOrEmpty(categoryID) || int.TryParse(categoryID, out categoryIDNew))
            {
                if (categoryIDNew == 0)
                    return new Tuple<string, List<tblCategory>>(string.Empty, result.ToList());
                else
                    return new Tuple<string, List<tblCategory>>(string.Empty, result.Where(a => a.CategoryID == categoryIDNew).ToList());
            }
            else
                return new Tuple<string, List<tblCategory>>("CategoryID is not in valid format", new List<tblCategory>());
        }

        public string AddCategory(tblCategory input)
        {
            moneyContext.tblCategories.Add(input);
            moneyContext.SaveChanges();
            return string.Empty;
        }

        public string UpdateCategory(tblCategory input)
        {
            var result = moneyContext.tblCategories.SingleOrDefault(b => b.CategoryID == input.CategoryID);
            if (result != null)
            {
                result.CategoryID = input.CategoryID;
                result.Category = input.Category;
                moneyContext.SaveChanges();
                return string.Empty;
            }
            else
                return "Category does not exist.";
        }

        public string DeleteCategory(int categoryID)
        {
            var result = moneyContext.tblCategories.SingleOrDefault(b => b.CategoryID == categoryID);
            if (result != null)
            {
                moneyContext.tblCategories.Remove(result);
                moneyContext.SaveChanges();
                return string.Empty;
            }
            else
                return "Category does not exist.";
        }
                
    }
}
