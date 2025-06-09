using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;

namespace StockManagementSystem.Middlewares
{
    public static class Validation
    {
        #region Validation
        public static bool IsTextBoxEmpty(params string[] fields)
        {
            return fields.Any(string.IsNullOrWhiteSpace);

        }
        public static bool IsViolateDataType(string quantity,string supplierID,string price)
        {
            if (!int.TryParse(quantity, out _) || !int.TryParse(supplierID, out _) || !decimal.TryParse(price, out _))
                return true;
            else
                return false;
        }
        public static bool CheckSupplierForeignKeyExisting(AppDBContext context , string supplierID)
        {
            var ForeignKey = context.Suppliers.Where(x => x.SupplierID == int.Parse(supplierID)).FirstOrDefault();
            if (ForeignKey != null)
                return true;
            else
                return false;

        }
        #endregion
    }
}
