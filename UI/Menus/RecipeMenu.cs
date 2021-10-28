using PanaderiaIkigai.UI.Controls.Recipes;
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
    public partial class RecipeMenu : Form
    {
        public RecipeMenu()
        {
            InitializeComponent();
        }

        private void btnOpenRegisterBasePanel_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();
            RegisterRecipePanel registerRecipePanel = new RegisterRecipePanel();
            registerRecipePanel.Location = new Point(1, 34);
            panelHolder.Controls.Add(registerRecipePanel);
            registerRecipePanel.Show();
            registerRecipePanel.BringToFront();
        }

        private void btnGoToEditRecipe_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();
            EditRecipePanel editRecipePanel = new EditRecipePanel();
            editRecipePanel.Location = new Point(1, 34);
            panelHolder.Controls.Add(editRecipePanel);
            editRecipePanel.Show();
            editRecipePanel.BringToFront();
        }

        private void btnGoToRecipeSteps_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();
            RegisterRecipeStepPanel recipeStepPanel = new RegisterRecipeStepPanel();
            recipeStepPanel.Location = new Point(1, 34);
            panelHolder.Controls.Add(recipeStepPanel);
            recipeStepPanel.Show();
            recipeStepPanel.BringToFront();
        }
    }
}
