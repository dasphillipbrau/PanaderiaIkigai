using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.Models;
using PanaderiaIkigai.Models.Recipes;
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

        static Recipe selectedRecipe = null;
        static BaseIngredient selectedIngredient = null;

        static bool recipeNameValid = false;
        static bool ingredientNameValid = false;
        static bool percentageValid = false;
        

        static string successfulOperationMessage = "Operación Exitosa";
        static string errorMessage = "Ha ocurrido un Error";
        static string originalStepCode = "";
        public RegisterRecipeStepPanel()
        {
            InitializeComponent();
        }

        private void RegisterRecipeStepPanel_Load(object sender, EventArgs e)
        {
            comboBoxSelectFilter.Items.Add("Nombre");
            comboBoxSelectFilter.Items.Add("Categoría");
            comboBoxSelectFilter.Items.Add("Autor");
            comboBoxSelectFilter.SelectedIndex = 0;
            PopulateDataGridViews();
            dgvIngredients.ClearSelection();
            dgvRecipes.ClearSelection();
        }

        private void PopulateDataGridViews()
        {
            var ingredientsList = ingredientContext.GetBaseIngredientsWithPrice();
            dgvIngredients.DataSource = ingredientsList.Select(o => new
            { Column1 = o.Code, Column2 = o.Name, Column3 = o.AverageMinimumPrice }).ToList();
            dgvIngredients.Columns[0].HeaderCell.Value = "Código";
            dgvIngredients.Columns[1].HeaderCell.Value = "Nombre";
            dgvIngredients.Columns[2].HeaderCell.Value = "Precio por Peso Mínimo";
            dgvIngredients.AutoResizeColumns();
            dgvIngredients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            var recipeList = recipeContext.GetRecipes();
            dgvRecipes.DataSource = recipeList;
            dgvRecipes.AutoResizeColumns();
            dgvRecipes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectFilter.SelectedIndex == 0)
                dgvRecipes.DataSource = recipeContext.GetRecipes(txtFilter.Text.ToUpper(), "NAME");
            else if (comboBoxSelectFilter.SelectedIndex == 1)
                dgvRecipes.DataSource = recipeContext.GetRecipes(txtFilter.Text.ToUpper(), "CATEGORY");
            else if (comboBoxSelectFilter.SelectedIndex == 2)
                dgvRecipes.DataSource = recipeContext.GetRecipes(txtFilter.Text.ToUpper(), "AUTHOR");
        }

        private void txtFilterIngredient_TextChanged(object sender, EventArgs e)
        {
            dgvIngredients.DataSource = ingredientContext.GetBaseIngredientsWithPrice(txtFilterIngredient.Text.ToUpper());
        }

        private void dgvRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRecipe = (Recipe)dgvRecipes.CurrentRow.DataBoundItem;
            txtRecipeName.Text = selectedRecipe.Name;
            recipeNameValid = true;
            txtIngredientPercentage.ReadOnly = false;
            txtPrepNotes.Text = selectedRecipe.PreparationNotes;
            dgvSteps.DataSource = recipeContext.GetSteps(selectedRecipe.Code);
            dgvSteps.AutoResizeColumns();
            dgvSteps.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void dgvIngredients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIngredient = new BaseIngredient();
            selectedIngredient.Code = (int)dgvIngredients.CurrentRow.Cells[0].Value;
            selectedIngredient.Name = (string)dgvIngredients.CurrentRow.Cells[1].Value;
            selectedIngredient.AverageMinimumPrice = (decimal)dgvIngredients.CurrentRow.Cells[2].Value;
            txtIngredientName.Text = selectedIngredient.Name;
            ingredientNameValid = true;
        }

        private void txtIngredientPercentage_Validating(object sender, CancelEventArgs e)
        {
            if (txtIngredientPercentage.Text.Trim().Length == 0)
            {
                percentageValid = false;
                errorProviderPercentage.SetError(txtIngredientPercentage, "Porcentaje no puede estar vacío");
            }
            else if (!decimal.TryParse(txtIngredientPercentage.Text, out decimal i) ||
                (decimal.TryParse(txtIngredientPercentage.Text, out decimal j) && (decimal.Parse(txtIngredientPercentage.Text) <= 0 || decimal.Parse(txtIngredientPercentage.Text) > 100)))
            {
                percentageValid = false;
                errorProviderPercentage.SetError(txtIngredientPercentage, "Indique un valor númerico entre 0,01 y 100\nRecuerde usar coma para indicar el punto decimal");
            }
            else if (decimal.TryParse(txtIngredientPercentage.Text, out decimal k) && (recipeContext.GetSteps(selectedRecipe.Code).Count == 0 && decimal.Parse(txtIngredientPercentage.Text) != 100))
            {
                percentageValid = false;
                errorProviderPercentage.SetError(txtIngredientPercentage, "El primer paso de un ingrediente siempre debe tener el 100% de proporción.");
            }
            
            else
            {
                percentageValid = true;
                errorProviderPercentage.Clear();
            }

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && recipeNameValid && ingredientNameValid && percentageValid)
            {
                if (rBtnRegistration.Checked) { 
                    if(recipeContext.RegisterStep(Math.Round(decimal.Parse(txtIngredientPercentage.Text), 2), selectedRecipe, selectedIngredient))
                    {
                        MessageBox.Show("Paso Registrado", successfulOperationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSteps.DataSource = recipeContext.GetSteps(selectedRecipe.Code);
                        ClearFields();
                        dgvRecipes.DataSource = recipeContext.GetRecipes();
                    }
                } 
                else
                {
                    if (!originalStepCode.Equals("")) 
                    {
                        if (recipeContext.UpdateStep(Math.Round(decimal.Parse(txtIngredientPercentage.Text), 2), selectedRecipe, selectedIngredient, originalStepCode))
                        {
                            MessageBox.Show("Paso Actualizado", successfulOperationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvSteps.DataSource = recipeContext.GetSteps(selectedRecipe.Code);
                            ClearFields();
                            dgvRecipes.DataSource = recipeContext.GetRecipes();
                        }
                        else
                        {
                            MessageBox.Show("No se ha actualizado el paso", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Antes de editar un registro, debe dar click a una fila de la tabla de pasos.",
                            errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hay errores en el formularío. Asegurese de llenar \nel campo " +
                "de porcentaje y de hacer click en \nuna de las celdas de la tabla de recetas y de la tabla de ingredientes",
                errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            ingredientNameValid = false;
            recipeNameValid = false;
            percentageValid = false;
            selectedRecipe = null;
            selectedIngredient = null;
            btnDeleteStep.Enabled = false;
            dgvRecipes.ClearSelection();
            dgvIngredients.ClearSelection();
            dgvSteps.ClearSelection();
            txtIngredientName.Text = "";
            txtRecipeName.Text = "";
            txtIngredientPercentage.Text = "";
            txtIngredientPercentage.ReadOnly = true;
            btnDeleteStep.Enabled = false;
            txtPrepNotes.Text = "";
            originalStepCode = "";
        }

        private void dgvSteps_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteStep.Enabled = true;
            var step = (RecipeStep)dgvSteps.CurrentRow.DataBoundItem;
            originalStepCode = step.StepCode;
        }

        private void btnDeleteStep_Click(object sender, EventArgs e)
        {
            RecipeStep step = (RecipeStep)dgvSteps.CurrentRow.DataBoundItem;
            if (MessageBox.Show("¿Esta seguro que quiere borrar el paso " + step.StepCode + "?", "Confirme Operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (recipeContext.DeleteStep(step.StepCode))
                {
                    MessageBox.Show("Paso borrado", successfulOperationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSteps.DataSource = recipeContext.GetSteps(step.RecipeCode);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("No se ha borrado el paso", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rBtnEdition_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnEdition.Checked)
            {
                ClearFields();
                btnSaveChanges.Text = "Editar Paso";
            }
        }

        private void rBtnRegistration_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnRegistration.Checked)
            {
                ClearFields();
                btnSaveChanges.Text = "Registrar Paso";
            }
        }
    }
}
