﻿using Chanh_Coffee.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Chanh_Coffee.Controls
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

        

        public void ChangePassword(String username, String newpass)
        {
            string query = "exec USP_ChangePassword @username , @newpass ";
            DataProvider.Instace.ExcuteNonQuerry(query, new object[] { username, newpass });
        }
        public List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();

            string query = "select * from Account";

            DataTable data = DataProvider.Instace.ExcuteQuerry(query);

            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }

            return list;
        }

        public void AddNewUser(string name, String pass, String type, string id)
        {
            string querry = " exec USP_AddNewUser  N'" + name + "' , '" + pass + "' , '" + type + "' , N'" + id + "'";
            DataProvider.Instace.ExcuteNonQuerry(querry);
        }

        public void RemoveUser(String id)
        {
            string querry = "DELETE FROM [dbo].[Account] where idEmployee = '" + id + "'";
            DataProvider.Instace.ExcuteNonQuerry(querry);
        }
    }
}
