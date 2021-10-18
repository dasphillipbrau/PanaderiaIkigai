using PanaderiaIkigai.Controls;
using PanaderiaIkigai.Controls.Ingredients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.Menus
{
    public partial class IngredientMenu : Form
    {
        public IngredientMenu()
        {
            InitializeComponent();
        }

        private void btnOpenRegisterBasePanel_Click(object sender, EventArgs e)
        {
            try { 
                BaseIngredientPanel baseIngredientPanel = new BaseIngredientPanel();
                this.Controls.Add(baseIngredientPanel);
                baseIngredientPanel.Location = new Point(257, 63);
                baseIngredientPanel.Show();
                baseIngredientPanel.BringToFront();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                        , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnQueryBaseIngredients_Click(object sender, EventArgs e)
        {
            DisplayBaseIngredientPanel queryPanel = new DisplayBaseIngredientPanel();
            this.Controls.Add(queryPanel);
            queryPanel.Location = new Point(257, 63);
            queryPanel.Show();
            queryPanel.BringToFront();
        }
    }
}
