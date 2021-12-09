using Chanh_Coffee.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Chanh_Coffee.Control
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; } 
            private set => instance = value; 
        }

        private AccountDAO()
        {

        }

        public bool Login(string userName, string passWord)
        {
            string querry = "USP_Login @username , @password ";
            DataTable result = DataProvider.Instace.ExcuteQuerry(querry,new object[] {userName, passWord });
            
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instace.ExcuteQuerry("Select * from account where UserName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public string GetNameFromID(string ID)
        {
            string querry = "Select * From dbo.Employee Where IdEmployee=\'"+ID+"\'";
            DataTable result = DataProvider.Instace.ExcuteQuerry(querry);

            return result.Rows[0]["Name"].ToString();
        }
    }
}
