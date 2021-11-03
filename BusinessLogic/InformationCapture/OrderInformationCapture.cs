using PanaderiaIkigai.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
