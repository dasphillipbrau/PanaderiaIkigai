using PanaderiaIkigai.Models.Orders;
using System;

namespace PanaderiaIkigai.BusinessLogic.InformationCapture
{
    public class OrderInformationCapture
    {
        public Order CaptureOrderInformation(int pClientCode, string pOrderStatus, string pOrderNotes, DateTime pOrderDate, DateTime pOrderDelivery, decimal pTax, decimal pPrepPrice)
        {
            return new Order(pClientCode, pOrderStatus, pOrderNotes, pOrderDate, pOrderDelivery, pTax, pPrepPrice);
        }
    }
}
