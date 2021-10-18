using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Models
{
    public class DetailedIngredient : BaseIngredient
    {
        public string DetailedIngredientCode { get; set; }
        public string Brand { get; set; }
        public string IngredientSource { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal AmountInUnit { get; set; }
        public decimal MinimumUnitPrice { get; set; }
        public int Quality { get; set; }

        public DetailedIngredient() { }

        public DetailedIngredient(int pCode, string pName, string pUnit, decimal pAveragePrice, int pUnitsAvailable, string pBrand, string pDetailedIngredientCode, string pIngredientSource, 
            decimal pUnitPrice, decimal pAmountInUnit, decimal pMinimumUnitPrice, int pQuality) : base(pCode, pName, pUnit, pAveragePrice, pUnitsAvailable)
        {
            DetailedIngredientCode = pDetailedIngredientCode;
            Brand = pBrand;
            IngredientSource = pIngredientSource;
            UnitPrice = pUnitPrice;
            AmountInUnit = pAmountInUnit;
            MinimumUnitPrice = pMinimumUnitPrice;
            Quality = pQuality;
        }

        public DetailedIngredient(BaseIngredient pBaseIngredient, string pDetailedIngredientCode, string pBrand, string pIngredientSource,
            decimal pUnitPrice, decimal pAmountInUnit, decimal pMinimumUnitPrice, int pQuality) : base(pBaseIngredient.Code, pBaseIngredient.Name, 
                pBaseIngredient.MeasuringUnit, pBaseIngredient.AveragePrice, pBaseIngredient.UnitsAvailable)
        {
            DetailedIngredientCode = pDetailedIngredientCode;
            Brand = pBrand;
            IngredientSource = pIngredientSource;
            UnitPrice = pUnitPrice;
            AmountInUnit = pAmountInUnit;
            MinimumUnitPrice = pMinimumUnitPrice;
            Quality = pQuality;
        }
 
    }
}
