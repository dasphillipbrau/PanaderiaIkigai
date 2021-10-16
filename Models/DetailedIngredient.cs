using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Models
{
    public class DetailedIngredient : BaseIngredient
    {
        public string IngredientSource { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal AmountInUnit { get; set; }
        public decimal MinimumUnitPrice { get; set; }
        public int Quality { get; set; }

        public DetailedIngredient() { }

        public DetailedIngredient(int pCode, string pName, string pUnit, int pUnitsAvaialble, string pIngredientSource, 
            decimal pUnitPrice, decimal pAmountInUnit, decimal pMinimumUnitPrice, int pQuality) : base(pCode, pName, pUnit, pUnitsAvaialble)
        {
            IngredientSource = pIngredientSource;
            UnitPrice = pUnitPrice;
            AmountInUnit = pAmountInUnit;
            MinimumUnitPrice = pMinimumUnitPrice;
            Quality = pQuality;
        }
 
    }
}
