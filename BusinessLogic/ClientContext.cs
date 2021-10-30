using PanaderiaIkigai.BusinessLogic.InformationCapture;
using PanaderiaIkigai.Data;
using PanaderiaIkigai.Models.Clients;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.BusinessLogic
{
    public class ClientContext
    {
        static SQLiteClientManager clientDataAccess = new SQLiteClientManager();
        static ClientInformationCapturer clientCapturer = new ClientInformationCapturer();
        public bool RegisterClient(string pName, string pPhone, string pEmail, string pAddress)
        {
            try
            {
                Client clientToRegister = clientCapturer.CaptureClient(pName, pPhone, pEmail, pAddress);

                if (clientDataAccess.RegisterClient(clientToRegister) == 1)
                    return true;
                else
                    return false;
            }
            catch(SQLiteException sqlEx)
            {
                MessageBox.Show("Error " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
    }
}
