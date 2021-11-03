using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Models.BI
{
    public class ClientSpending
    {
        public string ClientName { get; set; }
        public decimal TotalSpent { get; set; }

        public ClientSpending() { }
        public ClientSpending(string pName, decimal pTotalSpent)
        {
            ClientName = pName;
            TotalSpent = pTotalSpent;
        }
    }

    
}
