using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.Menus;
using PanaderiaIkigai.UI.Menus;
using System;
using System.Windows.Forms;

namespace PanaderiaIkigai
{
    public partial class MainMenu : Form
    {
        static ClientContext clientContext = new ClientContext();
        static RecipeContext recipeContext = new RecipeContext();
        static IngredientContext ingredientContext = new IngredientContext();
        static GeneralDataContext dataContext = new GeneralDataContext();
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
            if (ingredientContext.GetDetailedIngredients().Count == 0)
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

            if (clientContext.GetClients().Count == 0)
            {
                MessageBox.Show("Para poder acceder al menú de pedidos, deben existir al menos un cliente registrado" +
                    "\nUtilice el menu de clientes para añadir un registro", "No hay clientes registrados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (recipeContext.GetSteps().Count == 0)
            {
                MessageBox.Show("Para poder acceder al menú de pedidos, deben existir al menos una receta registrada" +
                    "\nUtilice el menu de recetas para añadir un registro", "No hay recetas registradas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (recipeContext.GetAvailableOrders().Count == 0)
            {
                MessageBox.Show("Actualmente ninguna de las recetas que tiene registradas tiene unidades disponibles" +
                    "\nPrimero utilice la funcionalidad de edición de recetas en el menú de recetas y añada unidades a al menos una receta", "No hay recetas disponibles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OrdersMenu ordersMenu = new OrdersMenu();
                ordersMenu.Show();
                ordersMenu.BringToFront();
            }


        }

        private void btnGoToBiMenu_Click(object sender, EventArgs e)
        {
            BiMenu bImenu = new BiMenu();
            bImenu.Show();
            bImenu.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataMenu dataMenu = new DataMenu();
            dataMenu.Show();
            dataMenu.BringToFront();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (dataContext.TestDatabase())
            {
                dataContext.AttemptAutoBackup();
            }
            else
            {
                MessageBox.Show("El archivo de base de datos que tiene seleccionado es inválido." +
                    "\nSe han deshabilitado todos los menús, excepto el menú de manejo de datos" +
                    "\nDirijase a este menu y seleccione un archivo válido.\nDespués, reinicie el programa para que los cambios tomen efecto", "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGoToBiMenu.Enabled = false;
                btnGoToIngredientMenu.Enabled = false;
                btnGoToRecipeMenu.Enabled = false;
                btnGoToClientsMenu.Enabled = false;
                btnGoToOrdersMenu.Enabled = false;
            }
        }
    }
}
