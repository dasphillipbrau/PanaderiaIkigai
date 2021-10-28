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
        public EditRecipePanel()
        {
            InitializeComponent();
        }

        private void EditRecipePanel_Load(object sender, EventArgs e)
        {
            var recipeList = recipeContext.GetRecipes();
            if(recipeList.Count != 0) { 
                dgvRecipes.DataSource = recipeList;
                dgvRecipes.AutoResizeColumns();
                dgvRecipes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgvRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Recipe selectedRecipe = (Recipe)dgvRecipes.CurrentRow.DataBoundItem;
            if (selectedRecipe.Image != null)
                pictureBoxRecipeImage.Image = ReadImageFromByteArray(selectedRecipe.Image);
            else
                pictureBoxRecipeImage.Image = null;
        }

        private Bitmap ReadImageFromByteArray(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
