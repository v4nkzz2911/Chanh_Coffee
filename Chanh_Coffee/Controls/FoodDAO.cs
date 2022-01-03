using Chanh_Coffee.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanh_Coffee.Controls
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food where idCate = " + id;

            DataTable data = DataProvider.Instace.ExcuteQuerry(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food";

            DataTable data = DataProvider.Instace.ExcuteQuerry(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public void UpdateFood(int id, string name, int type, int price , string image)
        {
            string querry = " exec USP_UpdateProductInf " + id + " , N'" + name + "' , " + type + " , " + price + " , N'"+ image + "'";
            DataProvider.Instace.ExcuteNonQuerry(querry);
        }

        public void InsertFood(string name, int type, int price, string image)
        {
            string querry = " exec USP_InsertFood  N'" + name + "' , " + type + " , " + price + " , N'" + image + "'";
            DataProvider.Instace.ExcuteNonQuerry(querry);
        }

        public void RemoveFood(String id)
        {
            string querry = "DELETE FROM [dbo].[Food] where idFood = '" + id + "'";
            DataProvider.Instace.ExcuteNonQuerry(querry);
        }



        //public List<Food> SearchFoodByName(string name)
        //{

        //    List<Food> list = new List<Food>();

        //    string query = string.Format("SELECT * FROM dbo.Food WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);

        //    foreach (DataRow item in data.Rows)
        //    {
        //        Food food = new Food(item);
        //        list.Add(food);
        //    }

        //    return list;
        //}

        //public bool InsertFood(string name, int id, float price)
        //{
        //    string query = string.Format("INSERT dbo.Food ( name, idCategory, price )VALUES  ( N'{0}', {1}, {2})", name, id, price);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}

        //public bool UpdateFood(int idFood, string name, int id, float price)
        //{
        //    string query = string.Format("UPDATE dbo.Food SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, id, price, idFood);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}

        //public bool DeleteFood(int idFood)
        //{
        //    BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);

        //    string query = string.Format("Delete Food where id = {0}", idFood);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}
    }
}
