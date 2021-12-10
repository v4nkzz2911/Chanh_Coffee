﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanh_Coffee.Models
{
    public class Food
    {
        public Food(int id, string name, int categoryID, float price, string image)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
            this.Image = image;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["IdFood"];
            this.Name = row["FoodName"].ToString();
            this.CategoryID = (int)row["IdCate"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.Image = row["Image"].ToString();
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private int categoryID;

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Image { get => image; set => image = value; }

        private string image;
    }
}
