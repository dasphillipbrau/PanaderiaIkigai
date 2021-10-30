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
            RecipeMenu recipeMenu = new RecipeMenu();
            recipeMenu.Show();
            recipeMenu.BringToFront();
        }

        private void btnOpenClientsMenu_Click(object sender, EventArgs e)
        {
            ClientsMenu clientsMenu = new ClientsMenu();
            clientsMenu.Show();
            clientsMenu.BringToFront();
        }
    }
}
