using System.ComponentModel;

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
        /// <summary>
        /// Constructor to populate an instance of Recipe from the database
        /// </summary>
        /// <param name="pCode"></param>
        /// <param name="pName"></param>
        /// <param name="pCategory"></param>
        /// <param name="pAuthor"></param>
        /// <param name="pTotalPrice"></param>
        /// <param name="pUnitsAvailable"></param>
        /// <param name="pAmountOfMainIngredient"></param>
        /// <param name="pPreparationNotes"></param>
        /// <param name="pImage"></param>
        public Recipe(int pCode, string pName, string pCategory, string pAuthor, decimal pTotalPrice, int pUnitsAvailable, decimal pAmountOfMainIngredient, string pPreparationNotes)
        {
            Code = pCode;
            Name = pName;
            CategoryName = pCategory;
            Author = pAuthor;
            TotalPrice = pTotalPrice;
            UnitsAvailable = pUnitsAvailable;
            AmountOfMainIngredient = pAmountOfMainIngredient;
            PreparationNotes = pPreparationNotes;

        }
        /// <summary>
        /// Constructor to register an instance of Recipe to the database
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pCategory"></param>
        /// <param name="pAuthor"></param>
        /// <param name="pUnitsAvailable"></param>
        /// <param name="pAmountOfMainIngredient"></param>
        /// <param name="pPreparationNotes"></param>
        /// <param name="pImage"></param>
        public Recipe(string pName, string pCategory, string pAuthor, int pUnitsAvailable, decimal pAmountOfMainIngredient, string pPreparationNotes, byte[] pImage)
        {
            Name = pName;
            CategoryName = pCategory;
            Author = pAuthor;
            UnitsAvailable = pUnitsAvailable;
            AmountOfMainIngredient = pAmountOfMainIngredient;
            PreparationNotes = pPreparationNotes;
            Image = pImage;
        }
    }
}
