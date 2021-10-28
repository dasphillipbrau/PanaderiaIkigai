using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Controls.Recipes
{
    public partial class EditRecipePanel : UserControl
    {
        static RecipeContext recipeContext = new RecipeContext();
        static string successfulOperationMessage = "Operación Exitosa";
        static string errorMessage = "Ha ocurrido un Error";
        static string imagePath = "";
        static byte[] staticImageByteArr;
        static int staticRecipeCode = -1;

        static bool nameValid = false;
        static bool categoryValid = false;
        static bool authorValid = false;
        static bool unitsValid = false;
        static bool ingredientAmountValid = false;

        public EditRecipePanel()
        {
            InitializeComponent();
        }

        private void EditRecipePanel_Load(object sender, EventArgs e)
        {
            var recipeList = recipeContext.GetRecipes();
            var categoryList = recipeContext.GetCategories();
            if (categoryList.Count == 0)
            {
                comboBoxCurrentCategories.Items.Add("No hay Categorías");
                comboBoxEditRecipeCategory.Items.Add("No hay Categorías");
                comboBoxCurrentCategories.SelectedIndex = 0;
                comboBoxEditRecipeCategory.SelectedIndex = 0;
            }
            else
            {
                comboBoxEditRecipeCategory.DataSource = categoryList;
                comboBoxCurrentCategories.DataSource = categoryList;
                comboBoxCurrentCategories.SelectedIndex = 0;
                comboBoxEditRecipeCategory.SelectedIndex = 0;
            }
            if (recipeList.Count != 0) {
                dgvRecipes.DataSource = recipeList;
                dgvRecipes.AutoResizeColumns();
                dgvRecipes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRecipes.ClearSelection();
            } else
            {
                ClearFields();
            }
            

            comboBoxSelectFilter.Items.Add("Nombre");
            comboBoxSelectFilter.Items.Add("Categoría");
            comboBoxSelectFilter.Items.Add("Autor");
            comboBoxSelectFilter.SelectedIndex = 0;
        }

        private void dgvRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Recipe selectedRecipe = (Recipe)dgvRecipes.CurrentRow.DataBoundItem;
            if (selectedRecipe.Image != null) 
            { 
                pictureBoxRecipeImage.Image = ReadImageFromByteArray(selectedRecipe.Image);
                staticImageByteArr = selectedRecipe.Image;
            }
            else 
            {
                staticImageByteArr = null;
                imagePath = "";
                pictureBoxRecipeImage.Image = null;
                lblIngredientImage.Visible = true;
                lblIngredientImage.Text = "No se encuentra ninguna Imagen para esta receta";
            }
            PopulateFields(selectedRecipe);
            staticRecipeCode = selectedRecipe.Code;
            btnSaveChanges.Enabled = true;
            btnDeleteRecipe.Enabled = true;
            btnDeleteImage.Enabled = true;
        }

        private Bitmap ReadImageFromByteArray(byte[] blob)
        {
            try { 
                using (MemoryStream mStream = new MemoryStream())
                {
                    byte[] pData = blob;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    Bitmap bm = new Bitmap(mStream, false);
                    lblIngredientImage.Visible = true;
                    lblIngredientImage.Text = "Imagen Encontrada";
                    return bm;
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message, errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblIngredientImage.Visible = true;
                lblIngredientImage.Text = "ERROR LEYENDO LA IMAGEN";
                return null;
            }
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

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if(dgvRecipes.SelectedRows.Count != 0)
            {
                Recipe selectedRecipe = (Recipe)dgvRecipes.CurrentRow.DataBoundItem;
                if(MessageBox.Show("¿Está seguro que desea borrar el registro " + selectedRecipe.Name + "?", "Confirme Operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (recipeContext.DeleteRecipe(selectedRecipe))
                    {
                        selectedRecipe = null;
                        MessageBox.Show("Registro Eliminado.", successfulOperationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        dgvRecipes.DataSource = recipeContext.GetRecipes();
                        
                    }
                    
                }
            }
        }

        private void ClearFields()
        {
            txtName.Text = "";
            comboBoxEditRecipeCategory.SelectedIndex = 0;
            txtAuthorName.Text = "";
            txtUnitsAvailable.Text = "";
            txtIngredientAmount.Text = "";
            txtPrepNotes.Text = "";
            txtFilter.Text = "";

            txtName.ReadOnly = true;
            comboBoxEditRecipeCategory.Enabled = false;
            txtAuthorName.ReadOnly = true;
            txtUnitsAvailable.ReadOnly = true;
            txtIngredientAmount.ReadOnly = true;
            txtPrepNotes.ReadOnly = true;

            txtFilter.Text = "";
            lblImgFound.Visible = false;
            lblImgFound.Text = "";
            lblIngredientImage.Text = "";
            lblIngredientImage.Visible = false;
            imagePath = "";
            pictureBoxRecipeImage.Image = null;
            nameValid = false;
            categoryValid = false;
            authorValid = false;
            unitsValid = false;
            ingredientAmountValid = false;
            btnSaveChanges.Enabled = false;
            btnBrowseImage.Enabled = false;
            btnDeleteImage.Enabled = false;
            btnDeleteRecipe.Enabled = false;

            staticImageByteArr = null;
            staticRecipeCode = -1;

            dgvRecipes.ClearSelection();

        }

        private void PopulateFields(Recipe pRecipe)
        {
            EnableFields();
            txtName.Text = pRecipe.Name;
            comboBoxEditRecipeCategory.SelectedItem = pRecipe.CategoryName;
            txtAuthorName.Text = pRecipe.Author;
            txtUnitsAvailable.Text = pRecipe.UnitsAvailable.ToString();
            txtIngredientAmount.Text = pRecipe.AmountOfMainIngredient.ToString();
            txtPrepNotes.Text = pRecipe.PreparationNotes;
        }

        private void EnableFields()
        {
            txtName.ReadOnly = false;
            comboBoxEditRecipeCategory.Enabled = true;
            txtAuthorName.ReadOnly = false;
            txtUnitsAvailable.ReadOnly = false;
            txtIngredientAmount.ReadOnly = false;
            txtPrepNotes.ReadOnly = false;
            btnBrowseImage.Enabled = true;
            btnDeleteImage.Enabled = true;
            btnDeleteRecipe.Enabled = true;

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                nameValid = false;
                errorProviderName.SetError(txtName, "Nombre no puede estar vacío");
            }
            else if (txtName.Text.Trim().Length > 30)
            {
                nameValid = false;
                errorProviderName.SetError(txtName, "Nombre no puede exceder 30 caracteres");
            }
            else
            {
                nameValid = true;
                errorProviderName.Clear();
            }
        }

        private void comboBoxEditRecipeCategory_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxEditRecipeCategory.SelectedItem.ToString().Equals("No hay Categorías"))
            {
                categoryValid = false;
                errorProviderCategoryName.SetError(comboBoxEditRecipeCategory, "Debe seleccionar una categoría");
            }
            else
            {
                categoryValid = true;
                errorProviderCategoryName.Clear();
            }
        }

        private void txtAuthorName_Validating(object sender, CancelEventArgs e)
        {
            if (txtAuthorName.Text.Trim().Length == 0)
            {
                authorValid = false;
                errorProviderAuthorName.SetError(txtAuthorName, "Nombre no puede estar vacío");
            }
            else if (txtAuthorName.Text.Trim().Length > 30)
            {
                authorValid = false;
                errorProviderAuthorName.SetError(txtAuthorName, "Nombre no puede exceder 30 caracteres");
            }
            else
            {
                authorValid = true;
                errorProviderAuthorName.Clear();
            }
        }

        private void txtUnitsAvailable_Validating(object sender, CancelEventArgs e)
        {
            if (txtUnitsAvailable.Text.Trim().Length == 0 || !int.TryParse(txtUnitsAvailable.Text.Trim(), out int i) ||
                (int.TryParse(txtUnitsAvailable.Text, out int j) && int.Parse(txtUnitsAvailable.Text.Trim()) < 0))
            {
                unitsValid = false;
                errorProviderUnitsAvailable.SetError(txtUnitsAvailable, "Indique una cantidad númerica positiva");
            }
            else
            {
                unitsValid = true;
                errorProviderUnitsAvailable.Clear();
            }
        }

        private void txtIngredientAmount_Validating(object sender, CancelEventArgs e)
        {
            if (txtIngredientAmount.Text.Trim().Length == 0 || !decimal.TryParse(txtIngredientAmount.Text.Trim(), out decimal i) ||
                (decimal.TryParse(txtIngredientAmount.Text.Trim(), out decimal j) && decimal.Parse(txtIngredientAmount.Text.Trim()) < 0))
            {
                ingredientAmountValid = false;
                errorProviderIngredientAmount.SetError(txtIngredientAmount, "Indique una cantidad númerica positiva.\nSi va a indicar una cantidad decimal, use coma para el punto decimal");
            }
            else
            {
                ingredientAmountValid = true;
                errorProviderIngredientAmount.Clear();
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog imageBrowser = new OpenFileDialog();
                string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                imageBrowser.InitialDirectory = myDocumentsPath;
                imageBrowser.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.svg;*.gif;*.webp";
                imageBrowser.FilterIndex = 0;
                imageBrowser.Multiselect = false;
                imageBrowser.CheckFileExists = true;
                imageBrowser.CheckPathExists = true;
                if (imageBrowser.ShowDialog() == DialogResult.OK)
                {

                    imagePath = imageBrowser.FileName;
                    lblImgFound.Text = "Imagen encontrada: " + Path.GetFileName(imagePath);
                    lblImgFound.Visible = true;

                }
            }
            catch (FileNotFoundException fileEx)
            {
                imagePath = "";
                lblImgFound.Text = "";
                lblImgFound.Visible = false;
                MessageBox.Show(fileEx.Message, errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled) && nameValid && authorValid && categoryValid && unitsValid && ingredientAmountValid)
                {
                    if(MessageBox.Show("¿Desea actualizar esta receta?", "Confirme Operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 
                        if (recipeContext.UpdateRecipe(staticRecipeCode, txtName.Text, comboBoxEditRecipeCategory.SelectedItem.ToString(), txtAuthorName.Text,
                            int.Parse(txtUnitsAvailable.Text.Trim()), decimal.Parse(txtIngredientAmount.Text.Trim()), imagePath, txtPrepNotes.Text, staticImageByteArr))
                        {
                            MessageBox.Show("Receta Actualizada", successfulOperationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtFilter.Text = "";
                            dgvRecipes.DataSource = recipeContext.GetRecipes();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("No se ha actualizado la receta", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha actualizado la receta", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Uno o más campos del formulario tienen errores.\nRevise los datos e intente de nuevo.", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar la imagen de la receta?\nLos cambios no tomarán efecto hasta que los guarde.", "Confire Operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                imagePath = "";
                staticImageByteArr = null;
                pictureBoxRecipeImage.Image = null;
                btnDeleteImage.Enabled = false;
                lblIngredientImage.Visible = true;
                lblIngredientImage.Text = "La imagen ha sido marcada para ser borrada";
            }
        }

        private void comboBoxCurrentCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNewNameForCategory.Text = comboBoxCurrentCategories.SelectedItem.ToString();
        }

        private void btnSaveCategoryChanges_Click(object sender, EventArgs e)
        {
            bool problemWithCategoryName = false;
            if (txtNewNameForCategory.Text.Length == 0)
            {
                problemWithCategoryName = true;
                lblCategoryValidation.Text = "Nombre no puede estar vacío";
            }
            else if (txtNewNameForCategory.Text.Length > 30)
            {
                problemWithCategoryName = true;
                lblCategoryValidation.Visible = true;
                lblCategoryValidation.Text = "Nombre no puede exceder \nlos 30 caracteres";
            }
            else if(txtNewNameForCategory.Text.Trim().ToUpper().Equals(comboBoxCurrentCategories.SelectedItem.ToString()))
            {
                problemWithCategoryName = true;
                lblCategoryValidation.Visible = true;
                lblCategoryValidation.Text = "No hay cambios en el nombre";
            }
            else
            {
                lblCategoryValidation.Visible = false;
                lblCategoryValidation.Text = "";
            }
            if (problemWithCategoryName)
            {
                MessageBox.Show("Hay problemas con el nombre de la categoría", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                if(recipeContext.UpdateCategory(txtNewNameForCategory.Text.Trim().ToUpper(), comboBoxCurrentCategories.SelectedItem.ToString()))
                {
                    MessageBox.Show("Categoría Actualizada", successfulOperationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var updatedCategories = recipeContext.GetCategories();
                    comboBoxCurrentCategories.DataSource = updatedCategories;
                    comboBoxCurrentCategories.SelectedIndex = 0;
                    comboBoxEditRecipeCategory.DataSource = updatedCategories;
                    comboBoxEditRecipeCategory.SelectedIndex = 0;
                    dgvRecipes.DataSource = recipeContext.GetRecipes();
                    dgvRecipes.ClearSelection();
                }
            }
            
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que desea borrar la categoría " + comboBoxCurrentCategories.SelectedItem.ToString() + "?", "Confirme Operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (recipeContext.DeleteCategory(comboBoxCurrentCategories.SelectedItem.ToString().ToUpper())) { 
                    MessageBox.Show("Categoría Borrada", successfulOperationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var updatedCategories = recipeContext.GetCategories();
                    comboBoxCurrentCategories.DataSource = updatedCategories;
                    comboBoxCurrentCategories.SelectedIndex = 0;
                    comboBoxEditRecipeCategory.DataSource = updatedCategories;
                    comboBoxEditRecipeCategory.SelectedIndex = 0;
                    dgvRecipes.DataSource = recipeContext.GetRecipes();
                    dgvRecipes.ClearSelection();
                }
            }
        }
    }
}
