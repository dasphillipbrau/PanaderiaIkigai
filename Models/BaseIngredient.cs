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
        /// <summary>
        /// Unique Ingredient Code
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// Ingredient Name
        /// </summary>
        public string Name { get; set; }
        public string MeasuringUnit { get; set; }

        public int UnitsAvailable { get; set; }

        public BaseIngredient() { }
        public BaseIngredient(int pCode, string pName, string pUnit, int pUnitsAvaialble)
        {
            Code = pCode;
            Name = pName;
            MeasuringUnit = pUnit;
            UnitsAvailable = pUnitsAvaialble;
        }
    }
}
