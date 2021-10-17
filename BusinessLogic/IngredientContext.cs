using PanaderiaIkigai.Data;
using PanaderiaIkigai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.BusinessLogic
{
    public class IngredientContext
    {
        static SqliteIngredientManager dataAccess = new SqliteIngredientManager();
        public void RegisterIngredient(BaseIngredient pIngredient)
        {
            throw new NotImplementedException();
        }

        public List<DetailedIngredient> GetDetailedIngredients()
        {
            Console.WriteLine("STARTING");
            var result = dataAccess.GetDetailedIngredients() as List<DetailedIngredient>;
            Console.WriteLine(result);
            return result;
        }
    }
}
