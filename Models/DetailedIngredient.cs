using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Models
{
    public class DetailedIngredient : BaseIngredient
    {
        [DisplayName("Código de Ingrediente Detallado")]
        public string DetailedIngredientCode { get; set; }
        [DisplayName("Marca")]
        public string Brand { get; set; }
        [DisplayName("Tienda de Compra")]
        public string IngredientSource { get; set; }
        [DisplayName("Precio Unitario")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Cantidad en Unidad")]
        public decimal AmountInUnit { get; set; }
        [DisplayName("Precio por Unidad de Medida")]
        public decimal MinimumUnitPrice { get; set; }
        [DisplayName("Calidad")]
        public int Quality { get; set; }

        public DetailedIngredient() { }

        public DetailedIngredient(int pCode, string pName, string pUnit, decimal pAveragePrice, decimal pAverageMinimumPrice, int pUnitsAvailable, 
            string pBrand, string pDetailedIngredientCode, string pIngredientSource, 
            decimal pUnitPrice, decimal pAmountInUnit, int pQuality) : base(pCode, pName, pUnit, pAveragePrice, pAverageMinimumPrice, pUnitsAvailable)
        {
            DetailedIngredientCode = pDetailedIngredientCode;
            Brand = pBrand;
            IngredientSource = pIngredientSource;
            UnitPrice = pUnitPrice;
            AmountInUnit = pAmountInUnit;
            MinimumUnitPrice = Math.Round(UnitPrice / AmountInUnit, 2);
            Quality = pQuality;
        }

        public DetailedIngredient(BaseIngredient pBaseIngredient, string pDetailedIngredientCode, string pBrand, string pIngredientSource,
            decimal pUnitPrice, decimal pAmountInUnit, int pQuality) : base(pBaseIngredient.Code, pBaseIngredient.Name, 
                pBaseIngredient.MeasuringUnit, pBaseIngredient.AveragePrice, pBaseIngredient.AverageMinimumPrice, pBaseIngredient.UnitsAvailable)
        {
            DetailedIngredientCode = pDetailedIngredientCode;
            Brand = pBrand;
            IngredientSource = pIngredientSource;
            UnitPrice = pUnitPrice;
            AmountInUnit = pAmountInUnit;
            MinimumUnitPrice = Math.Round(UnitPrice / AmountInUnit, 2);
            Quality = pQuality;
        }

        public DetailedIngredient(BaseIngredient pBaseIngredient, string pDetailedIngredientCode, string pBrand, string pIngredientSource,
            decimal pUnitPrice, decimal pAmountInUnit, decimal pMinimumUnitPrice, int pQuality) : base(pBaseIngredient.Code, pBaseIngredient.Name,
                pBaseIngredient.MeasuringUnit, pBaseIngredient.AveragePrice, pBaseIngredient.AverageMinimumPrice, pBaseIngredient.UnitsAvailable)
        {
            DetailedIngredientCode = pDetailedIngredientCode;
            Brand = pBrand;
            IngredientSource = pIngredientSource;
            UnitPrice = pUnitPrice;
            AmountInUnit = pAmountInUnit;
            MinimumUnitPrice = pMinimumUnitPrice;
            Quality = pQuality;
        }

        public DetailedIngredient(BaseIngredient pBaseIngredient, string pBrand, string pOrigin, decimal pAmountInUnit, decimal pUnitPrice, int pQuality, int pUnitsAvailable):base(pBaseIngredient.Code)
        {
            Brand = pBrand;
            IngredientSource = pOrigin;
            AmountInUnit = pAmountInUnit;
            UnitPrice = pUnitPrice;
            Quality = pQuality;
            UnitsAvailable = pUnitsAvailable;
            MinimumUnitPrice = Math.Round(UnitPrice / AmountInUnit, 2);
        }
 
    }
}
