using PanaderiaIkigai.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.Controls.Ingredients
{
    public partial class DisplayBaseIngredientPanel : UserControl
    {
        public DisplayBaseIngredientPanel()
        {
            InitializeComponent();
        }

        private void DisplayBaseIngredientPanel_Load(object sender, EventArgs e)
        {
            IngredientContext ingredientContext = new IngredientContext();
            var ingredientsList = ingredientContext.GetBaseIngredients();
            dgvBaseIngredients.DataSource = ingredientsList;
        }

        private void txtSearchBaseIngredient_TextChanged(object sender, EventArgs e)
        {
            try { 
                IngredientContext ingredientContext = new IngredientContext();
                var ingredientsList = ingredientContext.GetBaseIngredients(txtSearchBaseIngredient);
                dgvBaseIngredients.DataSource = ingredientsList;
            }
            catch (SQLiteException sqlEx)
            {
                MessageBox.Show(sqlEx.ErrorCode + " " + sqlEx.Message
                        , "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
