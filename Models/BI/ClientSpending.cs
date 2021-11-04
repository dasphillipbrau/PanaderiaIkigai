using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Models.BI
{
    public class ClientSpending
    {
        public int ClientCode { get; set; }
        public string ClientName { get; set; }
        public decimal TotalSpent { get; set; }

        public ClientSpending() { }
        public ClientSpending(int pCode, string pName, decimal pTotalSpent)
        {
            ClientCode = pCode;
            ClientName = pName;
            TotalSpent = pTotalSpent;
        }
    }

    
}
