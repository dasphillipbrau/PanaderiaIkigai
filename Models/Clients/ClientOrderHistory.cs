using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Models.Clients
{
    public class ClientOrderHistory
    {
        [DisplayName("Código de Cliente")]
        public int ClientCode { get; set; }
        [DisplayName("Nombre de Cliente")]
        public string ClientName { get; set; }
        [DisplayName("Código de Pedido")]
        public int OrderCode { get; set; }
        [DisplayName("Nombre de Artículo")]
        public string RecipeName { get; set; }
        [DisplayName("Cantidad Comprada")]
        public int UnitsPurchased { get; set; }
        [DisplayName("Fecha de Compra")]
        public DateTime OrderPurchaseDate { get; set; }
        [DisplayName("Estado de Pedido")]
        public string OrderStatus { get; set; }
        [DisplayName("Total de Pedido")]
        public decimal OrderTotal { get; set; }

        public ClientOrderHistory() { }
        public ClientOrderHistory(int pClientCode, string pClientName, int pOrderCode, string pRecipeName, int pUnitsPurchased, DateTime pOrderDate, string pStatus, decimal pOrderTotal)
        {
            ClientCode = pClientCode;
            ClientName = pClientName;
            OrderCode = pOrderCode;
            RecipeName = pRecipeName;
            UnitsPurchased = pUnitsPurchased;
            OrderPurchaseDate = pOrderDate.Date;
            OrderStatus = pStatus;
            OrderTotal = Math.Round(pOrderTotal, 2);
        }

        public enum ClientOrderFilter
        {
            ClientCode,
            ClientName,
            OrderCode,
            RecipeName,
            OrderStatus
        }
    }
}
