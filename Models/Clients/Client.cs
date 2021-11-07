using System;
using System.ComponentModel;

namespace PanaderiaIkigai.Models.Clients
{
    public class Client
    {
        [DisplayName("Código de Cliente")]
        public int Code { get; set; }
        [DisplayName("Nombre de Cliente")]
        public string Name { get; set; }
        [DisplayName("Número Teléfonico")]
        public string Phone { get; set; }
        [DisplayName("Correo Electrónico")]
        public string Email { get; set; }
        [DisplayName("Dirección de Cliente")]
        [Browsable(false)]
        public string Address { get; set; }
        [DisplayName("Dinero Gastado en Compras")]
        public decimal TotalSpent { get; set; }
        [DisplayName("Ordenes Realizadas")]
        public int TotalOrders { get; set; }

        public Client() { }
        /// <summary>
        /// Constructor to use when sending a record to the database
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPhone"></param>
        /// <param name="pEmail"></param>
        /// <param name="pAddress"></param>
        public Client(string pName, string pPhone, string pEmail, string pAddress)
        {
            Name = pName;
            Phone = pPhone;
            Email = pEmail;
            Address = pAddress;
        }
        /// <summary>
        /// Constructor to use when fetching a record from the database
        /// </summary>
        /// <param name="pCode"></param>
        /// <param name="pName"></param>
        /// <param name="pPhone"></param>
        /// <param name="pEmail"></param>
        /// <param name="pAddress"></param>
        /// <param name="pTotalSpent"></param>
        /// <param name="pOrdersMade"></param>
        public Client(int pCode, string pName, string pPhone, string pEmail, string pAddress, decimal pTotalSpent, int pOrdersMade)
        {
            Code = pCode;
            Name = pName;
            Phone = pPhone;
            Email = pEmail;
            Address = pAddress;
            TotalSpent = Math.Round(pTotalSpent, 2);
            TotalOrders = pOrdersMade;
        }

    }

    public enum ClientFilter
    {
        Code,
        Name,
        Phone,
        Email,
        Address
    }
}
