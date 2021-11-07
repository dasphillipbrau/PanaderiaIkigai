using LiveCharts;
using LiveCharts.Wpf;
using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.UI.Controls.BI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Menus
{
    public partial class BiMenu : Form
    {
        static BIContext biContext = new BIContext();
        static ClientContext clientContext = new ClientContext();
        static IngredientContext ingredientContext = new IngredientContext();
        static OrderContext orderContext = new OrderContext();
        static RecipeContext recipeContext = new RecipeContext();
        public BiMenu()
        {
            InitializeComponent();
        }

        private void BI_Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGoToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGoToClientBI_Click(object sender, EventArgs e)
        {
            if(clientContext.GetClients().Count > 0) { 
                panelHolder.Controls.Clear();
                ClientsBiPanel clientsBiPanel = new ClientsBiPanel();
                clientsBiPanel.Location = new Point(1, 1);
                panelHolder.Controls.Add(clientsBiPanel);
                clientsBiPanel.Show();
                clientsBiPanel.BringToFront();
            }
            else
            {
                MessageBox.Show("No hay ningún cliente registrado", "No se encuentran datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoToProductBi_Click(object sender, EventArgs e)
        {
            if(recipeContext.GetRecipes().Count > 0) { 
                panelHolder.Controls.Clear();
                ProductsBiPanel productBiPanel = new ProductsBiPanel();
                productBiPanel.Location = new Point(1, 1);
                panelHolder.Controls.Add(productBiPanel);
                productBiPanel.Show();
                productBiPanel.BringToFront();
            }
            else
            {
                MessageBox.Show("No hay ninguna receta registrada", "No se encuentran datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoToIngredientBi_Click(object sender, EventArgs e)
        {
            if(ingredientContext.GetBaseIngredients().Count > 0)
            {
                panelHolder.Controls.Clear();
                IngredientsBiPanel ingredientBiPanel = new IngredientsBiPanel();
                ingredientBiPanel.Location = new Point(1, 1);
                panelHolder.Controls.Add(ingredientBiPanel);
                ingredientBiPanel.Show();
                ingredientBiPanel.BringToFront();
            }
            else
            {
                MessageBox.Show("No hay ningun ingrediente registrado", "No se encuentran datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoToOrdersBi_Click(object sender, EventArgs e)
        {
            if(orderContext.GetOrders().Count > 0)
            {
                panelHolder.Controls.Clear();
                OrdersBiPanel orderBiPanel = new OrdersBiPanel();
                orderBiPanel.Location = new Point(1, 1);
                panelHolder.Controls.Add(orderBiPanel);
                orderBiPanel.Show();
                orderBiPanel.BringToFront();
            }
            else
            {
                MessageBox.Show("No hay ningun pedido registrado", "No se encuentran datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
