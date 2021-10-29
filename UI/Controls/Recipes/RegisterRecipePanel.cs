using PanaderiaIkigai.BusinessLogic;
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
    public partial class RegisterRecipePanel : UserControl
    {
        static RecipeContext recipeContext = new RecipeContext();
        static string successfulOperationMessage = "Operación Exitosa";
        static string errorMessage = "Ha ocurrido un Error";
        static string imagePath = "";

        static bool nameValid = false;
        static bool categoryValid = false;
        static bool authorValid = false;
        static bool unitsValid = false;
        static bool ingredientAmountValid = false;
        public RegisterRecipePanel()
        {
            InitializeComponent();
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            try 
            { 
                if(recipeContext.RegisterCategory(txtRegisterCategory, lblCategoryRegistrationValidation))
                {
                    MessageBox.Show("Categoría Registrada", successfulOperationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblCategoryRegistrationValidation.Visible = false;
                    txtRegisterCategory.Text = "";
                    comboBoxCategory.DataSource = recipeContext.GetCategories();
                } 
                else
                {
                    MessageBox.Show("Categoría no Registrada", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterRecipePanel_Load(object sender, EventArgs e)
        {
            var categories = recipeContext.GetCategories();
            if (categories.Count == 0)
                comboBoxCategory.Items.Add("No hay Categorías");
            else
                comboBoxCategory.DataSource = categories;
            comboBoxCategory.SelectedIndex = 0;

        }

        private void txtRecipeName_Validating(object sender, CancelEventArgs e)
        {
            if(txtRecipeName.Text.Trim().Length == 0)
            {
                nameValid = false;
                errorProviderRecipeName.SetError(txtRecipeName, "Nombre no puede estar vacío");
            }
            else if (txtRecipeName.Text.Trim().Length > 30)
            {
                nameValid = false;
                errorProviderRecipeName.SetError(txtRecipeName, "Nombre no puede exceder 30 caracteres");
            }
            else
            {
                nameValid = true;
                errorProviderRecipeName.Clear();
            }
        }

        private void comboBoxCategory_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxCategory.SelectedItem.ToString().Equals("No hay Categorías"))
            {
                categoryValid = false;
                errorProviderCategoryName.SetError(comboBoxCategory, "Debe seleccionar una categoría");
            } 
            else
            {
                categoryValid = true;
                errorProviderCategoryName.Clear();
            }
        }

        private void txtRecipeAuthor_Validating(object sender, CancelEventArgs e)
        {
            if (txtRecipeAuthor.Text.Trim().Length == 0)
            {
                authorValid = false;
                errorProviderAuthor.SetError(txtRecipeAuthor, "Nombre no puede estar vacío");
            }
            else if (txtRecipeAuthor.Text.Trim().Length > 30)
            {
                authorValid = false;
                errorProviderAuthor.SetError(txtRecipeAuthor, "Nombre no puede exceder 30 caracteres");
            }
            else
            {
                authorValid = true;
                errorProviderAuthor.Clear();
            }
        }

        private void txtUnitsAvailable_Validating(object sender, CancelEventArgs e)
        {
            if(txtUnitsAvailable.Text.Trim().Length == 0 || !int.TryParse(txtUnitsAvailable.Text.Trim(), out int i) || 
                (int.TryParse(txtUnitsAvailable.Text, out int j) && int.Parse(txtUnitsAvailable.Text.Trim()) < 0))
            {
                unitsValid = false;
                errorProviderUnitsAvailable.SetError(txtUnitsAvailable, "Indique una cantidad númerica positiva");
            } else
            {
                unitsValid = true;
                errorProviderUnitsAvailable.Clear();
            }
        }

        private void txtMainIngredientAmount_Validating(object sender, CancelEventArgs e)
        {
            if(txtMainIngredientAmount.Text.Trim().Length == 0 || !decimal.TryParse(txtMainIngredientAmount.Text.Trim(), out decimal i) || 
                (decimal.TryParse(txtMainIngredientAmount.Text.Trim(), out decimal j) && decimal.Parse(txtMainIngredientAmount.Text.Trim()) < 0))
            {
                ingredientAmountValid = false;
                errorProviderIngredientAmount.SetError(txtMainIngredientAmount, "Indique una cantidad númerica positiva.\nSi va a indicar una cantidad decimal, use coma para el punto decimal");
            }
            else
            {
                ingredientAmountValid = true;
                errorProviderIngredientAmount.Clear();
            }
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            try { 
                OpenFileDialog imageBrowser = new OpenFileDialog();
                string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                imageBrowser.InitialDirectory = myDocumentsPath;
                imageBrowser.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.svg;*.gif;*.webp";
                imageBrowser.FilterIndex = 0;
                imageBrowser.Multiselect = false;
                imageBrowser.CheckFileExists = true;
                imageBrowser.CheckPathExists = true;
                if(imageBrowser.ShowDialog() == DialogResult.OK)
                {
                
                    imagePath = imageBrowser.FileName;
                    lblImgFound.Text = "Imagen encontrada: " + Path.GetFileName(imagePath);
                    lblImgFound.Visible = true;
             
                }
            } catch (FileNotFoundException fileEx)
            {
                imagePath = "";
                lblImgFound.Text = "";
                lblImgFound.Visible = false;
                MessageBox.Show(fileEx.Message, errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            try { 
                if(ValidateChildren(ValidationConstraints.Enabled) && nameValid && authorValid && categoryValid && unitsValid && ingredientAmountValid)
                {
                    if(recipeContext.RegisterRecipe(txtRecipeName.Text, comboBoxCategory.SelectedItem.ToString(), txtRecipeAuthor.Text,
                        int.Parse(txtUnitsAvailable.Text.Trim()), decimal.Parse(txtMainIngredientAmount.Text.Trim()), imagePath, txtPreparationNotes.Text))
                    {
                        MessageBox.Show("Receta Insertada", successfulOperationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("No se ha insertado la receta", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
                else
                {
                    MessageBox.Show("Uno o más campos del formulario tienen errores.\nRevise los datos e intente de nuevo.", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception Ex) 
            {
                MessageBox.Show(Ex.Message, errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtRecipeName.Text = "";
            comboBoxCategory.SelectedIndex = 0;
            txtRecipeAuthor.Text = "";
            txtUnitsAvailable.Text = "";
            txtMainIngredientAmount.Text = "";
            imagePath = "";
            txtPreparationNotes.Text = "";
            nameValid = false;
            categoryValid = false;
            authorValid = false;
            unitsValid = false;
            ingredientAmountValid = false;
        }
    }
}
