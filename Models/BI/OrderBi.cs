using System;

namespace PanaderiaIkigai.Models.BI
{
    public class OrderBi
    {
        public int Code { get; set; }
        public string OrderStatus { get; set; }
        public decimal Revenue { get; set; }

        public DateTime OrderDate { get; set; }
        public int AmountOfOrders { get; set; }
    }
}
