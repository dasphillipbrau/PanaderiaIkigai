using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Models
{
    class Ingredient
    {
        /// <summary>
        /// Unique Ingredient Code
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// Ingredient Name
        /// </summary>
        public string Name { get; set; }
        public string UnitMeasure { get; set; }
        public int IndividualUnits { get; set; }
        public int TotalUnits { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal PricePerGram { get; set; }
        public decimal AmountInUnit { get; set; }
        public string IngredientSource { get; set; }
        public int Quality { get; set; }
    }
}
