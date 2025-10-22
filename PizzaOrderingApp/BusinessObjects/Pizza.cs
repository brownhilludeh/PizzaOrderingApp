using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingApp.BusinessObjects
{
    /*
     * This class is used to represent a pizza
     * @Author: Brownhill Udeh
     * @version Assignment 3
     * @since 2025-10-20
     */
    internal class Pizza
    {
        //Properties 
        private string size;
        private string sauceType;
        private List<string> ingredients;
        private double cost;


        //Attributes
        public string Size { get => size; set => size = value; }
        public string SauceType{ get => sauceType; set => sauceType = value; }
        public List<string> Ingredients { get => ingredients; set => ingredients = value; }
        public double Cost => cost;
        //public double Cost { get => cost; private set => cost = value; }

        //Static List of 10 Ingredients
        public static List<string> IngredientsList = new List<string>
        {
            "Pepperoni", "Mushrooms", "Onions", "Green Peppers",
            "Black Olives", "Bacon", "Sausage", "Pineapple",
            "Jalepenos", "Spinach"
        };

        //List of Orders
        public static List<Pizza> Orders = new List<Pizza>();

        //Default Constructor
        public Pizza() { }

        //Custom Constructor
        public Pizza(string size, string sauceType, List<string> ingredients)
        {
            Size = size;
            SauceType = sauceType;
            Ingredients = ingredients;
            CalculateCost();
        }

        /*
         * This method is used to calculate the cost of the pizza
         * @Author: Brownhill Udeh
         * @version Assignment 3
         * @since 2025-10-20
         * @return void
         */
        private void CalculateCost()
        {
            double baseCost;

            switch (Size)
            {
                case "10\"":
                    baseCost = 5.0;
                    break;
                case "12\"":
                    baseCost = 8.0;
                    break;
                case "14\"":
                    baseCost = 12.0;
                    break;
                default:
                    baseCost = 0.0;
                    break;
            }

            double IngredientCost = Ingredients.Count * 0.75;
            cost = baseCost + IngredientCost;

        }

        public override string ToString()
        {
            string ingredientsList = Ingredients.Count > 0
                ? string.Join(", ", Ingredients)
                : "No toppings";

            return $"{Size} Pizza ({SauceType} sauce) with {ingredientsList} - ${Cost:F2}";
        }
    }
}
