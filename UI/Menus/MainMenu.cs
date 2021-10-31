using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.Menus;
using PanaderiaIkigai.Models;
using PanaderiaIkigai.UI.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai
{
    public partial class MainMenu : Form
    {
        static ClientContext clientContext = new ClientContext();
        static RecipeContext recipeContext = new RecipeContext();
        static IngredientContext ingredientContext = new IngredientContext();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnGoToIngredientMenu_Click(object sender, EventArgs e)
        {
            IngredientMenu ingredientMenu = new IngredientMenu();
            ingredientMenu.Show();
            ingredientMenu.BringToFront();
        }

        private void btnGoToRecipeMenu_Click(object sender, EventArgs e)
        {
            if(ingredientContext.GetDetailedIngredients().Count == 0)
            {
                MessageBox.Show("Para poder acceder al menú de recetas, deben existir al menos un ingrediente detallado registrado" +
                    "\nUtilice el menu de ingredientes para añadir un registro", "No hay ingredientes detallados registrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else 
            { 
                RecipeMenu recipeMenu = new RecipeMenu();
                recipeMenu.Show();
                recipeMenu.BringToFront();
            }
        }

        private void btnOpenClientsMenu_Click(object sender, EventArgs e)
        {
            ClientsMenu clientsMenu = new ClientsMenu();
            clientsMenu.Show();
            clientsMenu.BringToFront();
        }

        private void btnGoToOrdersMenu_Click(object sender, EventArgs e)
        {
            
            if(clientContext.GetClients().Count == 0)
            {
                MessageBox.Show("Para poder acceder al menú de ordenes, deben existir al menos un cliente registrado" +
                    "\nUtilice el menu de clientes para añadir un registro", "No hay clientes registrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if(recipeContext.GetSteps().Count == 0)
            {
                MessageBox.Show("Para poder acceder al menú de ordenes, deben existir al menos una receta registrada" +
                    "\nUtilice el menu de recetas para añadir un registro", "No hay recetas registradas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OrdersMenu ordersMenu = new OrdersMenu();
                ordersMenu.Show();
                ordersMenu.BringToFront();
            }
            
            
        }
    }
}
