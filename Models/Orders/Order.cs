﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Models.Orders
{
    public class Order
    {
        [DisplayName("Código de Pedido")]
        public int Code { get; set; }
        [DisplayName("Código de Cliente")]
        public int ClientCode { get; set; }
        [DisplayName("Nombre de Client")]
        public string ClientName { get; set; }
        [DisplayName("Estado de Pedido")]
        public string OrderStatus { get; set; }
        [DisplayName("Notas de Entrega")]
        public string OrderNotes { get; set; }
        [DisplayName("Fecha de Pedido")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Fecha de Entrega")]
        public DateTime DeliveryDate { get; set; }
        [DisplayName("Cantidad de Items en Pedido")]
        public int ItemsInOrder { get; set; }
        [DisplayName("Porcentaje de Impuestos")]
        public decimal TaxPercentage { get; set; }
        [DisplayName("Monto de Impuestos")]
        public decimal TaxAmount { get; set; }
        [DisplayName("Mano de Obra")]
        public decimal PreparationCost { get; set; }
        [DisplayName("Precio de Items")]
        public decimal ItemsTotalPrice { get; set; }
        [DisplayName("Monto Total")]
        public decimal TotalPrice { get; set; }

        public Order() { }
        /// <summary>
        /// Constructor to use when registering order to database
        /// </summary>
        /// <param name="pClientCode"></param>
        /// <param name="pOrderStatus"></param>
        /// <param name="pOrderNotes"></param>
        /// <param name="pOrderDate"></param>
        /// <param name="pDeliveryDate"></param>
        /// <param name="pItemsInOrder"></param>
        /// <param name="pTaxPercentage"></param>
        /// <param name="pPreparationCost"></param>
        public Order(int pClientCode, string pOrderStatus, string pOrderNotes, DateTime pOrderDate, DateTime pDeliveryDate, int pItemsInOrder, decimal pTaxPercentage, decimal pPreparationCost)
        {
            ClientCode = pClientCode;
            OrderStatus = pOrderStatus;
            OrderNotes = pOrderNotes;
            OrderDate = pOrderDate;
            DeliveryDate = pDeliveryDate;
            ItemsInOrder = pItemsInOrder;
            TaxPercentage = pTaxPercentage;
            PreparationCost = pPreparationCost;
        }
        /// <summary>
        /// Constructor to use when populating a record from the database
        /// </summary>
        /// <param name="pCode"></param>
        /// <param name="pClientCode"></param>
        /// <param name="pClientName"></param>
        /// <param name="pOrderStatus"></param>
        /// <param name="pOrderNotes"></param>
        /// <param name="pOrderDate"></param>
        /// <param name="pDeliveryDate"></param>
        /// <param name="pItemsInOrder"></param>
        /// <param name="pTaxPercentage"></param>
        /// <param name="pTaxAmount"></param>
        /// <param name="pPreparationCost"></param>
        /// <param name="pTotalPrice"></param>
        public Order(int pCode, int pClientCode, string pClientName, string pOrderStatus, string pOrderNotes, 
            DateTime pOrderDate, DateTime pDeliveryDate, int pItemsInOrder, decimal pTaxPercentage, decimal pTaxAmount, decimal pPreparationCost, decimal pItemsPrice, decimal pTotalPrice)
        {
            Code = pCode;
            ClientCode = pClientCode;
            ClientName = pClientName;
            OrderStatus = pOrderStatus;
            OrderNotes = pOrderNotes;
            OrderDate = pOrderDate;
            DeliveryDate = pDeliveryDate;
            ItemsInOrder = pItemsInOrder;
            TaxPercentage = pTaxPercentage;
            TaxAmount = pTaxAmount;
            PreparationCost = pPreparationCost;
            ItemsTotalPrice = pItemsPrice;
            TotalPrice = pTotalPrice;
        }
    }
}
