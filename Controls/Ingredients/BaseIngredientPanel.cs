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

namespace PanaderiaIkigai.Controls
{
    public partial class BaseIngredientPanel : UserControl
    {
        public BaseIngredientPanel()
        {
            InitializeComponent();
        }

        private void btnRegisterBaseIngredient_Click(object sender, EventArgs e)
        {
            try { 
                IngredientContext ingredientContext = new IngredientContext();
                if (ingredientContext.RegisterIngredient(txtName, txtUnit, lblBaseIngredientNameValidation, lblBaseIngredientUnitValidation))
                {
                    MessageBox.Show("Ingrediente Registrado"
                            , "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Text = "";
                    txtUnit.Text = "";
                }
                else
                {
                    MessageBox.Show("No se ha registrado el ingrediente.\nRevise el mensaje en los campos."
                            , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (System.Data.SQLite.SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("Ya existe un ingrediente con este nombre.\nTodos los nombres de ingredientes deben de ser únicos."
                        , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = "";
                } else
                {
                    MessageBox.Show(sqlEx.Message
                        , "SQLite Error code " + sqlEx.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BaseIngredientPanel_Load(object sender, EventArgs e)
        {
            Console.WriteLine("I AM OPEN");
        }
    }
}
