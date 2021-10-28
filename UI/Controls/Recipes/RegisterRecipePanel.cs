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
    public partial class RegisterRecipePanel : UserControl
    {
        static RecipeContext recipeContext = new RecipeContext();
        static string successfulOperationMessage = "Operación Exitosa";
        static string errorMessage = "Ha ocurrido un Error";

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
    }
}
