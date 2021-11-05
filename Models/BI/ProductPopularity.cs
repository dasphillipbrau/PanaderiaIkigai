﻿using System;
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
        public DateTime OrderDate { get; set; }

        public int OrderCode { get; set; }

        public ProductPopularity(string pName, decimal pPopularity) 
        {
            RecipeName = pName;
            Popularity = pPopularity;

        }
        public ProductPopularity(string pName, decimal pPopularity, DateTime pOrderDate)
        {
            RecipeName = pName;
            Popularity = pPopularity;
            OrderDate = pOrderDate.Date;
        }

        public ProductPopularity(int pCode, DateTime pOrderDate, decimal pPopularity)
        {
            OrderCode = pCode;
            OrderDate = pOrderDate;
            Popularity = pPopularity;
        }
    }
}
