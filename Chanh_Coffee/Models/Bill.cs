using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        public Bill(string idbill, DateTime? time , string idEmployee , string idPromotion)
        {
            this.idBill = idbill;
            this.time = time;
            this.idEmployee = idEmployee;
            this.idPromotion = idPromotion;
        }

        public Bill(DataRow row)
        {
            this.idBill = row["idBill"].ToString();
            this.time = (DateTime?)row["Time"];
            this.idEmployee = row["idEmployee"].ToString();
            this.idPromotion = row["idPromotion"].ToString();
        }


        private string idBill;
        private DateTime? time;
        private string idEmployee;
        private string idPromotion;


        
        public string IdBill { get => idBill; set => idBill = value; }
        public DateTime? Time { get => time; set => time = value; }
        public string IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string IdPromotion { get => idPromotion; set => idPromotion = value; }
    }
}
