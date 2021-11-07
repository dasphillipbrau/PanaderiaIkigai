using PanaderiaIkigai.Models.Clients;

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
