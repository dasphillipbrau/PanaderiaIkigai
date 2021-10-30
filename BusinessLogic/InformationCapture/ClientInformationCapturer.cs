using PanaderiaIkigai.Models.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.BusinessLogic.InformationCapture
{
    public class ClientInformationCapturer
    {
        public Client CaptureClient(string pName, string pPhone, string pEmail, string pAddress)
        {
            return new Client(pName, pPhone, pEmail, pAddress);
        }
    }
}
