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
    }
}
