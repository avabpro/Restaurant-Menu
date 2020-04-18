using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            // needs to be built out
        }

    }

    class Menu
    {
        private DateTime lastUpdated;

        private List<MenuItem> menuList = new List<MenuItem>();

        public DateTime LastUpdated
        {
            get { return lastUpdated; }
            set { lastUpdated = value; }
        }

        public Menu()
        {
            LastUpdated = DateTime.Now;
        }

        public void AddMenuItem(double price, string description, string category, Boolean isNew)

        {
            menuList.Add(new MenuItem(price, description, category, isNew));
        }
    }

    class MenuItem
    {
        private double price;
        private string description;
        private string category;
        private Boolean isNew;



        public double Price
        {
            get { return price; }
            set 
            { 
                if(value < 0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }
                price = value;

            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Description cannot be left empty.");
                }
                description = value;

            }
        }

        public string Category
        {
            get { return category; }
            set
            {
                if (value != "appetizer" || value != "main course" || value != "dessert")
                {
                    throw new ArgumentException("Category must be one of the following: appetizer, main course, dessert");
                }
                category = value;

            }
        }

        public Boolean IsNew
        {
            get { return isNew; }
            set
            { isNew = value; }
        }

        public MenuItem(double price, string description, string category, Boolean isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }
    }

}
