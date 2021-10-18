using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Models
{
    public class BaseIngredient
    {
        
        [DisplayName("Código")]
        public int Code { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Unidad de Medida")]
        public string MeasuringUnit { get; set; }
        [DisplayName("Precio Promedio")]
        public decimal AveragePrice { get; set; }
        [DisplayName("Unidades Disponibles")]
        public int UnitsAvailable { get; set; }

        public BaseIngredient() { }
        public BaseIngredient(int pCode, string pName, string pUnit, decimal pAveragePrice, int pUnitsAvaialble)
        {
            Code = pCode;
            Name = pName;
            MeasuringUnit = pUnit;
            AveragePrice = pAveragePrice;
            UnitsAvailable = pUnitsAvaialble;
        }
    }
}
