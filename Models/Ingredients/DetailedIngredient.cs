using System;
using System.ComponentModel;

namespace PanaderiaIkigai.Models
{
    public class DetailedIngredient
    {
        [DisplayName("Código de Ingrediente Detallado")]
        public string DetailedIngredientCode { get; set; }
        [DisplayName("Código de Ingrediente Base")]
        public int BaseIngredientCode { get; set; }
        [DisplayName("Nombre de Ingrediente Base")]
        public string BaseIngredientName { get; set; }
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
        [DisplayName("Unidades Disponibles")]
        public int TotalUnitsAvailable { get; set; }

        public DetailedIngredient() { }
        /// <summary>
        /// Constructor to populate an instance of DetailedIngredient with data coming from the database
        /// </summary>
        /// <param name="pBaseIngredient">Base Ingredient instance</param>
        /// <param name="pDetailedCode">Detailed Ingredient Code</param>
        /// <param name="pBrand">Product Brand</param>
        /// <param name="pIngredientSource">Store of purchase</param>
        /// <param name="pUnitPrice">Unit Price</param>
        /// <param name="pAmountInUnit">Weight of unit</param>
        /// <param name="pMinimumUnitPrice">Price per minimum weight</param>
        /// <param name="pQuality">Ingredient Quality</param>
        /// <param name="pTotalUnits">Units available</param>
        public DetailedIngredient(BaseIngredient pBaseIngredient, string pDetailedCode, string pBrand, string pIngredientSource, decimal pUnitPrice, decimal pAmountInUnit, decimal pMinimumUnitPrice, int pQuality, int pTotalUnits)
        {
            DetailedIngredientCode = pDetailedCode;
            BaseIngredientCode = pBaseIngredient.Code;
            BaseIngredientName = pBaseIngredient.Name;
            Brand = pBrand;
            IngredientSource = pIngredientSource;
            UnitPrice = pUnitPrice;
            AmountInUnit = pAmountInUnit;
            MinimumUnitPrice = pMinimumUnitPrice;
            Quality = pQuality;
            TotalUnitsAvailable = pTotalUnits;
        }
        /// <summary>
        /// Constructor to populate an instance of DetailedIngredient to register in the database
        /// </summary>
        /// <param name="pBaseCode"></param>
        /// <param name="pBrand"></param>
        /// <param name="pIngredientSource"></param>
        /// <param name="pUnitPrice"></param>
        /// <param name="pAmountInUnit"></param>
        /// <param name="pQuality"></param>
        /// <param name="pTotalUnits"></param>
        public DetailedIngredient(int pBaseCode, string pBrand, string pIngredientSource, decimal pUnitPrice, decimal pAmountInUnit, int pQuality, int pTotalUnits)
        {
            BaseIngredientCode = pBaseCode;
            Brand = pBrand;
            IngredientSource = pIngredientSource;
            UnitPrice = pUnitPrice;
            AmountInUnit = pAmountInUnit;
            MinimumUnitPrice = Math.Round(UnitPrice / AmountInUnit, 2);
            Quality = pQuality;
            TotalUnitsAvailable = pTotalUnits;
        }

    }
}
