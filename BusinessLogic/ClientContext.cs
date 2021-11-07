using PanaderiaIkigai.BusinessLogic.InformationCapture;
using PanaderiaIkigai.Data;
using PanaderiaIkigai.Models.Clients;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using static PanaderiaIkigai.Models.Clients.ClientOrderHistory;

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
            catch (SQLiteException sqlEx)
            {

                if (sqlEx.ErrorCode == 19 && sqlEx.Message.Equals("constraint failed\r\nUNIQUE constraint failed: Client.PHONE"))
                {
                    MessageBox.Show("El número de teléfono ya está registrado bajo otro cliente\n" +
                        "Todos los números telefónicos y correos deben de ser únicos", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.Debug.WriteLine("This is the error: " + sqlEx.Message);
                }
                else if (sqlEx.ErrorCode == 19 && sqlEx.Message.Equals("constraint failed\r\nUNIQUE constraint failed: Client.EMAIL"))
                {
                    MessageBox.Show("El correo electrónico ya está registrado bajo otro cliente\n" +
                        "Todos los números telefónicos y correos deben de ser únicos", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.Debug.WriteLine(sqlEx.Message);
                }
                else
                    MessageBox.Show("Error " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public List<Client> GetClients()
        {
            return clientDataAccess.GetClients() as List<Client>;
        }

        public List<Client> GetClients(string pFilterValue, string pFilterMode)
        {
            List<Client> clientsList = new List<Client>();

            switch (pFilterMode)
            {
                case "Nombre":
                    clientsList = clientDataAccess.GetClients(pFilterValue.ToUpper(), ClientFilter.Name) as List<Client>;
                    break;
                case "Código":
                    clientsList = clientDataAccess.GetClients(pFilterValue.ToUpper(), ClientFilter.Code) as List<Client>;
                    break;
                case "Teléfono":
                    clientsList = clientDataAccess.GetClients(pFilterValue.ToUpper(), ClientFilter.Phone) as List<Client>;
                    break;
                case "E - Mail":
                    clientsList = clientDataAccess.GetClients(pFilterValue.ToUpper(), ClientFilter.Email) as List<Client>;
                    break;
                case "Dirección":
                    clientsList = clientDataAccess.GetClients(pFilterValue.ToUpper(), ClientFilter.Address) as List<Client>;
                    break;
            }

            return clientsList;

        }

        public bool UpdateClient(int pCode, string pName, string pPhone, string pEmail, string pAddress)
        {
            try
            {
                var clientToUpdate = clientCapturer.CaptureClient(pName, pPhone, pEmail, pAddress);
                clientToUpdate.Code = pCode;
                if (clientDataAccess.UpdateClient(clientToUpdate) == 1)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                MessageBox.Show("Error " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public bool DeleteClient(int pCode)
        {
            try
            {
                if (clientDataAccess.DeleteClient(pCode) == 1)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("El registro de cliente que desea borrar es referenciado por otro registro en la base de datos" +
                        "\nprimero debe borrar cualquier registro que referencie a este cliente", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Error " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public List<ClientOrderHistory> GetClientOrderHistories()
        {
            return clientDataAccess.GetClientsOrderHistories() as List<ClientOrderHistory>;
        }

        public List<ClientOrderHistory> GetClientOrderHistories(string pFilterMode, string pFilterValue)
        {
            switch (pFilterMode.ToUpper())
            {
                case "CÓDIGO DE CLIENTE":
                    return clientDataAccess.GetClientsOrderHistories(ClientOrderFilter.ClientCode, pFilterValue) as List<ClientOrderHistory>;
                case "NOMBRE DE CLIENTE":
                    return clientDataAccess.GetClientsOrderHistories(ClientOrderFilter.ClientName, pFilterValue) as List<ClientOrderHistory>;
                case "CÓDIGO DE PEDIDO":
                    return clientDataAccess.GetClientsOrderHistories(ClientOrderFilter.OrderCode, pFilterValue) as List<ClientOrderHistory>;
                case "NOMBRE DE ARTÍCULO":
                    return clientDataAccess.GetClientsOrderHistories(ClientOrderFilter.RecipeName, pFilterValue) as List<ClientOrderHistory>;
                case "ESTADO DE PEDIDO":
                    return clientDataAccess.GetClientsOrderHistories(ClientOrderFilter.OrderStatus, pFilterValue) as List<ClientOrderHistory>;
                default:
                    return clientDataAccess.GetClientsOrderHistories(ClientOrderFilter.ClientName, pFilterValue) as List<ClientOrderHistory>;
            }
        }
    }
}
