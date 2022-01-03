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
                if (!item["IdPromotion"].Equals("Không"))
                {
                    Promotion promo = new Promotion(item);
                    list.Add(promo);
                }
                
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

        public void UpdatePromo(string newId , string start , string end , decimal price , string des , string Id)
        {
            string querry = "exec USP_UpdatePromo '"+ newId +"' , '"+start+"' , '"+end+"' , "+price+" , N'"+des+"' , '"+Id+"'";
            DataProvider.Instace.ExcuteNonQuerry(querry);
        }

        public void InsertPromo(string newId, string start, string end, decimal price, string des)
        {
            string querry = "exec USP_InsertPromo '" + newId + "' , '" + start + "' , '" + end + "' , " + price + " , N'" + des + "'";
            DataProvider.Instace.ExcuteNonQuerry(querry);
        }

        public void DeletePromo(string id)
        {
            string querry = "DELETE FROM [dbo].[Promotion] WHERE IdPromotion =  '" + id + "'";
            DataProvider.Instace.ExcuteNonQuerry(querry);
        }
    }
}
