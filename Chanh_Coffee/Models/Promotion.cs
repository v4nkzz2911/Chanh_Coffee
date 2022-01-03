using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanh_Coffee.Models
{
    public class Promotion
    {
        public Promotion(string idPromo, DateTime startDate, DateTime endDate, string des, int pricePromo)
        {
            this.idPromo = idPromo;
            this.startDate = startDate;
            this.endDate = endDate;
            this.des = des;
            this.pricePromo = pricePromo;
        }
        
        public Promotion(DataRow row)
        {
            this.idPromo = row["IdPromotion"].ToString();
            this.startDate = (DateTime)row["StartDate"];
            this.endDate = (DateTime)row["EndDate"];
            this.des = row["Description"].ToString();
            this.pricePromo = Int32.Parse(row["PricePromotion"].ToString());
        }
        
        
        private string idPromo;
        private DateTime startDate;
        private DateTime endDate;
        private string des;
        private int pricePromo;

        public string IdPromo { get => idPromo; set => idPromo = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string Des { get => des; set => des = value; }
        public int PricePromo { get => pricePromo; set => pricePromo = value; }
    }
}
