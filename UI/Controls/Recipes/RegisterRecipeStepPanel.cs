using PanaderiaIkigai.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Controls.Recipes
{
    public partial class RegisterRecipeStepPanel : UserControl
    {
        static RecipeContext recipeContext = new RecipeContext();
        static IngredientContext ingredientContext = new IngredientContext();
        public RegisterRecipeStepPanel()
        {
            InitializeComponent();
        }

        private void RegisterRecipeStepPanel_Load(object sender, EventArgs e)
        {
            PopulateDataGridViews();
            
        }

        private void PopulateDataGridViews()
        {
            var ingredientsList = ingredientContext.GetBaseIngredients();
            dgvIngredients.DataSource = ingredientsList.Select(o => new
            { Column1 = o.Code, Column2 = o.Name, Column3 = o.AverageMinimumPrice }).ToList();
            dgvIngredients.Columns[0].HeaderCell.Value = "Código";
            dgvIngredients.Columns[1].HeaderCell.Value = "Nombre";
            dgvIngredients.Columns[2].HeaderCell.Value = "Precio por Peso Mínimo";
            dgvIngredients.AutoResizeColumns();
            dgvIngredients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvIngredients.ClearSelection();

            var recipeList = recipeContext.GetRecipes();
            dgvRecipes.DataSource = recipeList;
            dgvRecipes.AutoResizeColumns();
            dgvRecipes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRecipes.ClearSelection();

        }
    }
}
