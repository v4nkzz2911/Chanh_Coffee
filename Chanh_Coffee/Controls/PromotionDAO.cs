using Chanh_Coffee.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanh_Coffee.Controls
{
    public class PromotionDAO
    {
        private static PromotionDAO instance;

        public static PromotionDAO Instance
        {
            get { if (instance == null) instance = new PromotionDAO(); return PromotionDAO.instance; }
            private set { PromotionDAO.instance = value; }
        }

        public List<Promotion> GetListPromotion()
        {
            List<Promotion> list = new List<Promotion>();

            string query = "select * from Promotion";

            DataTable data = DataProvider.Instace.ExcuteQuerry(query);

            foreach (DataRow item in data.Rows)
            {
                Promotion promo = new Promotion(item);
                list.Add(promo);
            }

            return list;
        }

        public List<Promotion> GetListPromotionAvailable()
        {
            List<Promotion> list = new List<Promotion>();

            string query = "select * from Promotion";

            DataTable data = DataProvider.Instace.ExcuteQuerry(query);

            DateTime today = DateTime.Today;
            foreach (DataRow item in data.Rows)
            {
                Promotion promo = new Promotion(item);
                if ((promo.StartDate <= today) && (today <= promo.EndDate))
                {
                    list.Add(promo);
                }
                
            }

            return list;
        }
    }
}
