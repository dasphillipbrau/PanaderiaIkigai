using PanaderiaIkigai.Controls;
using PanaderiaIkigai.Controls.Ingredients;
using PanaderiaIkigai.UI.Controls.Ingredients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            try { 
                BaseIngredientPanel baseIngredientPanel = new BaseIngredientPanel();
                baseIngredientPanel.Location = new Point(255, 63);
                this.Controls.Add(baseIngredientPanel);
                baseIngredientPanel.Show();
                baseIngredientPanel.BringToFront();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                        , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnQueryBaseIngredients_Click(object sender, EventArgs e)
        {
            EditBaseIngredientPanel editBaseIngredientPanel = new EditBaseIngredientPanel();
            editBaseIngredientPanel.Location = new Point(255, 63);
            this.Controls.Add(editBaseIngredientPanel);
            editBaseIngredientPanel.Show();
            editBaseIngredientPanel.BringToFront();
        }

        private void btnGoToRegisterDetailedIngredient_Click(object sender, EventArgs e)
        {
            RegisterDetailedIngredientsPanel detailedIngredientPanel = new RegisterDetailedIngredientsPanel();
            detailedIngredientPanel.Location = new Point(255, 63);
            this.Controls.Add(detailedIngredientPanel);
            detailedIngredientPanel.Show();
            detailedIngredientPanel.BringToFront();
        }

        private void btnGoToEditDetailedIngredients_Click(object sender, EventArgs e)
        {
            EditDetailedIngredientPanel editDetailedIngredientPanel = new EditDetailedIngredientPanel();
            editDetailedIngredientPanel.Location = new Point(255, 63);
            this.Controls.Add(editDetailedIngredientPanel);
            editDetailedIngredientPanel.Show();
            editDetailedIngredientPanel.BringToFront();
        }
    }
}
