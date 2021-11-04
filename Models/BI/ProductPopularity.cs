using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Models.BI
{
    public class ProductPopularity
    {
        public string RecipeName { get; set; }
        public decimal Popularity { get; set; }

        public ProductPopularity(string pName, decimal pPopularity) 
        {
            RecipeName = pName;
            Popularity = pPopularity;
        }
    }
}
