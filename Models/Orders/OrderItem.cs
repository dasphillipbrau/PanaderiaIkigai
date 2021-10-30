using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Models.Orders
{
    public class OrderItem
    {
        [DisplayName("Código de Item")]
        public string Code { get; set; }
        [DisplayName("Código de Orden")]
        public int OrderCode { get; set; }
        [DisplayName("Código de Receta")]
        public int RecipeCode { get; set; }
        [DisplayName("Nombre de Receta")]
        public string RecipeName { get; set; }
        [DisplayName("Unidades en Item")]
        public int UnitsInItem { get; set; }
        [DisplayName("Precio Total de Item")]
        public decimal TotalItemPrice { get; set; }

        public OrderItem() { }

        /// <summary>
        /// Constructor to use when registering a record to the database
        /// </summary>
        /// <param name="pOrderCode"></param>
        /// <param name="pRecipeCode"></param>
        /// <param name="pRecipeName"></param>
        /// <param name="pUnitsInItem"></param>
        /// <param name="pTotalItemPrice"></param>
        public OrderItem(int pOrderCode, int pRecipeCode, string pRecipeName, int pUnitsInItem, decimal pTotalItemPrice)
        {
            OrderCode = pOrderCode;
            RecipeCode = pRecipeCode;
            RecipeName = pRecipeName;
            UnitsInItem = pUnitsInItem;
            TotalItemPrice = Math.Round(pTotalItemPrice, 2);
            Code = pOrderCode + "-" + pRecipeName;
        }
        /// <summary>
        /// Constructor to use when retrieving a record from the database
        /// </summary>
        /// <param name="pItemCode"></param>
        /// <param name="pOrderCode"></param>
        /// <param name="pRecipeCode"></param>
        /// <param name="pRecipeName"></param>
        /// <param name="pUnitsInItem"></param>
        /// <param name="pTotalItemPrice"></param>
        public OrderItem(string pItemCode, int pOrderCode, int pRecipeCode, string pRecipeName, int pUnitsInItem, decimal pTotalItemPrice)
        {
            Code = pItemCode;
            OrderCode = pOrderCode;
            RecipeCode = pRecipeCode;
            RecipeName = pRecipeName;
            UnitsInItem = pUnitsInItem;
            TotalItemPrice = pTotalItemPrice;
        }

    }
}
