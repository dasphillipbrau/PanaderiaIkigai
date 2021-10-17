using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai
{
    public partial class Form1 : Form
    {
        static IngredientContext context = new IngredientContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lel = context.GetDetailedIngredients() as List<DetailedIngredient>;
            dataGridView.DataSource = lel;
        }

    }
}
