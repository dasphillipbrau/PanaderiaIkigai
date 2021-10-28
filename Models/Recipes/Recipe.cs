using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Models
{
    public class Recipe
    {
        [DisplayName("Código")]
        public int Code { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Nombre de Categoría")]
        public string CategoryName { get; set; }
        [DisplayName("Autor")]
       
        public string Author { get; set; }
        [DisplayName("Precio de Fabricación")]

        public decimal TotalPrice { get; set; }
        [DisplayName("Unidades Preparadas")]
        public int UnitsAvailable { get; set; }
        [DisplayName("Cantidad del Ingrediente Principal")]
        public decimal AmountOfMainIngredient { get; set; }

        [Browsable(false)]
        public string PreparationNotes { get; set; }
        [Browsable(false)]
        public byte[] Image { get; set; }

        public Recipe()
        {

        }

        public Recipe(int pCode, string pName, string pCategory, string pAuthor, decimal pTotalPrice, int pUnitsAvailable, decimal pAmountOfMainIngredient, string pPreparationNotes, byte[] pImage)
        {
            Code = pCode;
            Name = pName;
            CategoryName = pCategory;
            Author = pAuthor;
            TotalPrice = pTotalPrice;
            UnitsAvailable = pUnitsAvailable;
            AmountOfMainIngredient = pAmountOfMainIngredient;
            PreparationNotes = pPreparationNotes;
            Image = pImage;
        }
    }
}
