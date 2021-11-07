using System;
using System.ComponentModel;

namespace PanaderiaIkigai.Models.Recipes
{
    public class RecipeStep
    {
        [DisplayName("Código de Paso")]
        public string StepCode { get; set; }
        [DisplayName("Código de Receta")]
        public int RecipeCode { get; set; }
        [DisplayName("Nombre de Ingrediente")]
        public string IngredientName { get; set; }
        [DisplayName("Proporción de Ingrediente en porcentaje")]
        public decimal IngredientPercentage { get; set; }
        [DisplayName("Cantidad de Ingrediente en Unidad de Medida")]
        public decimal IngredientAmount { get; set; }
        [DisplayName("Precio por Cantidad Usada")]
        public decimal PriceForAmountUsed { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RecipeStep() { }

        /// <summary>
        /// Constructor to use when fetching from Database
        /// </summary>
        /// <param name="pStepCode"></param>
        /// <param name="pRecipeCode"></param>
        /// <param name="pName"></param>
        /// <param name="pPercentage"></param>
        /// <param name="pAmountUsed"></param>
        /// <param name="pPriceForAmount"></param>
        public RecipeStep(string pStepCode, int pRecipeCode, string pName, decimal pPercentage, decimal pAmountUsed, decimal pPriceForAmount)
        {
            StepCode = pStepCode;
            RecipeCode = pRecipeCode;
            IngredientName = pName;
            IngredientPercentage = pPercentage;
            IngredientAmount = pAmountUsed;
            PriceForAmountUsed = pPriceForAmount;
        }

        /// <summary>
        /// Constructor to use when sending a record to the Database
        /// </summary>
        /// <param name="pRecipeCode"></param>
        /// <param name="pIngredient"></param>
        /// <param name="pPercentage"></param>
        /// <param name="pRecipe"></param>
        public RecipeStep(int pRecipeCode, BaseIngredient pIngredient, decimal pPercentage, Recipe pRecipe)
        {
            StepCode = pRecipeCode + "-" + pIngredient.Name;
            RecipeCode = pRecipeCode;
            IngredientName = pIngredient.Name;
            IngredientPercentage = Math.Round(pPercentage, 2);
            IngredientAmount = Math.Round(((IngredientPercentage * pRecipe.AmountOfMainIngredient) / 100), 2);
            PriceForAmountUsed = Math.Round(IngredientAmount * pIngredient.AverageMinimumPrice, 2);
        }
    }
}
