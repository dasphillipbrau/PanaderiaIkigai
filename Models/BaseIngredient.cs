using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.Models
{
    public class BaseIngredient
    {
        
        [DisplayName("Código")]
        public int Code { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Unidad de Medida")]
        public string MeasuringUnit { get ; set; }
        [DisplayName("Precio Promedio")]
        public decimal AveragePrice { get; set; }
        [DisplayName("Precio Promedio por Unidad de Medida")]
        public decimal AverageMinimumPrice { get; set; }
        [DisplayName("Unidades Disponibles")]
        public int UnitsAvailable { get; set; }

        public BaseIngredient() { }
        public BaseIngredient(int pCode, string pName, string pUnit, decimal pAveragePrice, decimal pAverageMinimumPrice, int pUnitsAvaialble)
        {
            Code = pCode;
            Name = pName;
            MeasuringUnit = pUnit;
            AveragePrice = pAveragePrice;
            AverageMinimumPrice = pAverageMinimumPrice;
            UnitsAvailable = pUnitsAvaialble;
        }

        public BaseIngredient(DataGridView dgv, int rowIndex = 0)
        {
            Code = int.Parse(dgv.SelectedRows[rowIndex].Cells[0].Value.ToString());
            Name = dgv.SelectedRows[rowIndex].Cells[1].Value.ToString().Trim().ToUpper();
            MeasuringUnit = dgv.SelectedRows[rowIndex].Cells[2].Value.ToString().Trim().ToUpper();
            AveragePrice = decimal.Parse(dgv.SelectedRows[rowIndex].Cells[3].Value.ToString());
            AverageMinimumPrice = decimal.Parse(dgv.SelectedRows[rowIndex].Cells[4].Value.ToString());
            UnitsAvailable = int.Parse(dgv.SelectedRows[rowIndex].Cells[5].Value.ToString());
        }

        public BaseIngredient(int pCode)
        {
            Code = pCode;
        }

        public bool CompareIngredients(BaseIngredient pIngredientToCompare)
        {
            if (Code == pIngredientToCompare.Code && Name.ToUpperInvariant().Equals(pIngredientToCompare.Name.ToUpper())
                && MeasuringUnit.ToUpper().Equals(pIngredientToCompare.MeasuringUnit.ToUpper()) && AveragePrice == pIngredientToCompare.AveragePrice
                && AverageMinimumPrice == pIngredientToCompare.AverageMinimumPrice && UnitsAvailable == pIngredientToCompare.UnitsAvailable)
                return true;
            else
                return false;
        }
    }
}
