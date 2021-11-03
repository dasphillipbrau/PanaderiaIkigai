using PanaderiaIkigai.Data;
using PanaderiaIkigai.Models.BI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.BusinessLogic
{
    public class BIContext
    {
        static SQLiteBusinessIntelligenceManager dataAccess = new SQLiteBusinessIntelligenceManager();

        public List<ClientSpending> GetClientSpendings()
        {
            return dataAccess.GetClientSpending();
        }
    }
}
