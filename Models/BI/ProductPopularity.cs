using System;

namespace PanaderiaIkigai.Models.BI
{
    public class ProductPopularity
    {
        public string Name { get; set; }
        public decimal Popularity { get; set; }
        public DateTime OrderDate { get; set; }

        public int OrderCode { get; set; }

        public ProductPopularity(string pName, decimal pPopularity)
        {
            Name = pName;
            Popularity = pPopularity;

        }
        public ProductPopularity(string pName, decimal pPopularity, DateTime pOrderDate)
        {
            Name = pName;
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
