using Chanh_Coffee.Controls;
using Chanh_Coffee.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanh_Coffee.Controls
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public void InsertBill(string idEmp, string idPromo, int totalPrice)
        {
            DataProvider.Instace.ExcuteNonQuerry("exec USP_InsertBill @idEmp , @idPromo , @totalPrice", new object[] { idEmp , idPromo , totalPrice});
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instace.ExcuteScalar("SELECT MAX(IdBill) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }

        public string GetTimebyIDBill(int id)
        {
            DataTable data = DataProvider.Instace.ExcuteQuerry("SELECT * FROM dbo.Bill WHERE IdBill = " + id);

            foreach (DataRow item in data.Rows)
            {
                return new Bill(item).Time.ToString();
            }

            return null;

            
            
        }

        

        public DataTable GetBillListByDateRange(string start , string end)
        {
            string command = "exec USP_GetListByDateRange '" + start + "' , '" + end + "'";
            return DataProvider.Instace.ExcuteQuerry(command);
            
        }
    }
}
