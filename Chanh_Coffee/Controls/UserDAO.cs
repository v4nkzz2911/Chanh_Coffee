using Chanh_Coffee.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanh_Coffee.Controls
{
    public class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return instance; }
            private set => instance = value;
        }

        private UserDAO()
        {

        }

        public User GetUserByID(string ID)
        {
            User x = null;
            string querry = "Select * From dbo.Employee Where IdEmployee=\'" + ID + "\'";
            DataTable result = DataProvider.Instace.ExcuteQuerry(querry);
            foreach (DataRow item in result.Rows)
            {
                User t = new User(item);
                return t;
            }

            return x;
        }

        //public List GetUserList()
        //{
        //    DataTable data = DataProvider.Instace.ExcuteQuerry("Select * from account where UserName = '" + userName + "'");
        //    List<User> listUsers = new List();
        //    foreach (DataRow item in data.Rows)
        //    {
        //        listUsers.Add(new )
        //    }

        //    return null;
        //}
    }
}
