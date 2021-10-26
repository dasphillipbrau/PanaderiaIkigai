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

namespace PanaderiaIkigai.UI.Controls.Ingredients
{
    public partial class EditDetailedIngredientPanel : UserControl
    {
        static IngredientContext ingredientContext = new IngredientContext();
        public EditDetailedIngredientPanel()
        {
            InitializeComponent();
        }

        private void EditDetailedIngredientPanel_Load(object sender, EventArgs e)
        {
            var ingredientsList = ingredientContext.GetDetailedIngredients();
            dgvDisplayDetailedIngredients.DataSource = ingredientsList;
        }
    }
}
