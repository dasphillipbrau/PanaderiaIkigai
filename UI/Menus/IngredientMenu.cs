using PanaderiaIkigai.Controls;
using PanaderiaIkigai.Controls.Ingredients;
using PanaderiaIkigai.UI.Controls.Ingredients;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PanaderiaIkigai.Menus
{
    public partial class IngredientMenu : Form
    {
        public IngredientMenu()
        {
            InitializeComponent();
        }
        private void btnOpenRegisterBasePanel_Click(object sender, EventArgs e)
        {
            try
            {
                panelMenuHolders.Controls.Clear();
                BaseIngredientPanel baseIngredientPanel = new BaseIngredientPanel();
                baseIngredientPanel.Location = new Point(1, 34);
                panelMenuHolders.Controls.Add(baseIngredientPanel);
                baseIngredientPanel.Show();
                baseIngredientPanel.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                        , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnQueryBaseIngredients_Click(object sender, EventArgs e)
        {
            panelMenuHolders.Controls.Clear();
            EditBaseIngredientPanel editBaseIngredientPanel = new EditBaseIngredientPanel();
            editBaseIngredientPanel.Location = new Point(1, 34);
            panelMenuHolders.Controls.Add(editBaseIngredientPanel);
            editBaseIngredientPanel.Show();
            editBaseIngredientPanel.BringToFront();
        }

        private void btnGoToRegisterDetailedIngredient_Click(object sender, EventArgs e)
        {
            panelMenuHolders.Controls.Clear();
            RegisterDetailedIngredientsPanel detailedIngredientPanel = new RegisterDetailedIngredientsPanel();
            detailedIngredientPanel.Location = new Point(1, 34);
            panelMenuHolders.Controls.Add(detailedIngredientPanel);
            detailedIngredientPanel.Show();
            detailedIngredientPanel.BringToFront();
        }

        private void btnGoToEditDetailedIngredients_Click(object sender, EventArgs e)
        {
            panelMenuHolders.Controls.Clear();
            EditDetailedIngredientPanel editDetailedIngredientPanel = new EditDetailedIngredientPanel();
            editDetailedIngredientPanel.Location = new Point(1, 34);
            panelMenuHolders.Controls.Add(editDetailedIngredientPanel);
            editDetailedIngredientPanel.Show();
            editDetailedIngredientPanel.BringToFront();
        }

        private void btnGoToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
