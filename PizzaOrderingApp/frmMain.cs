using PizzaOrderingApp.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderingApp
{
    public partial class frmMain : Form
    {
        /*
         * @Author: Brownhill Udeh
         * @version Assignment 3
         * @since 2025-10-20
         */
        public frmMain()
        {
            InitializeComponent();
            InitializePizzaTab();
        }

        //private void InitializePizzaTab()
        private void InitializePizzaTab()
        {
            //Initialize the pizza tab
            // Populate toppings checklist
            foreach (var ingredient in Pizza.IngredientsList)
            {
                clbToppings.Items.Add(ingredient);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //foreach (var ingredient in Pizza.IngredientsList)
            //{
            //    clbToppings.Items.Add(ingredient);
            //}
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (cmbSize.SelectedItem == null)
            {
                MessageBox.Show("Please select a pizza size", "Error");
                return;
            }

            string size = cmbSize.SelectedItem.ToString();
            string sauceType = rbSpicy.Checked ? "Spicy" : "Regular";

            List<string> selectedToppings = new List<string>();

            foreach (string topping in clbToppings.CheckedItems)
            {
                selectedToppings.Add(topping);
            }

            Pizza pizza = new Pizza(size, sauceType, selectedToppings);

            // Add the pizza to the order list
            Pizza.Orders.Add(pizza);
            lstSummary.Items.Add(pizza);

            MessageBox.Show("Pizza added successfully!");

        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            // Clearing the order
            lstSummary.Items.Clear();

            // Clearing the toppings checklist
            this.clbToppings.SelectedItems.Clear();

            // Clearing all pizza in order list
            Pizza.Orders.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
