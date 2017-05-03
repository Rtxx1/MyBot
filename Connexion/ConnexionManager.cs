using MyBot.Interface;
using MyBot.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBot.Connexion
{
    class ConnexionManager
    {
        private IPEndPoint _serverEP;
        private Server _listenerSocket;
        private ConsoleLog Log;
        private FormBot ClientForm;
        private Main Main;
        private PackManager PManager;
        private PackIdNames idNames;


        public delegate void clientActionEventHandler(Client client);
        public event clientActionEventHandler ClientConnected;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="server"></param>
        /// <param name="_Log"></param>
        /// <param name="_Main"></param>
        public ConnexionManager(IPEndPoint server, ConsoleLog _Log, Main _Main)
        {
            _serverEP = server; // on le garde pour le Client
            _listenerSocket = new Server(); // on initialise le Listener
            Log = _Log;
            Main = _Main;
            idNames = new PackIdNames();
        }

        /// <summary>
        /// 
        /// </summary>
        public void start()
        {
            _listenerSocket.onClientConnected += clientconnect; // on s'abonne aux nouvelles connexions
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        public void clientconnect(Client client)
        {
            Log.WriteLog("Nouveau client connecté sur " + client.IpAndPort);
            ClientForm = new FormBot();
            Main.Invoke((MethodInvoker)delegate () {
                ClientForm.MdiParent = Main;
                ClientForm.Text = client.IpAndPort;
                ClientForm.Show();
            });

            Client server = new Client(_serverEP); // on initialise le client

            client.associated = server;
            server.associated = client;

            client.onReception += forwardtoserver; // on créer les règles de redirection
            server.onReception += forwadtoclient;

            server.connect(); // on connect le client
        }

        private void forwadtoclient(Client sender, byte[] buffer)
        {
            PManager = new PackManager(ClientForm);
            string content_hex = string.Empty;
            int huit_bytes = 0;
            foreach (byte b in buffer)
            {
                content_hex += b.ToString("X2") + " ";
                huit_bytes++;
            }
            PManager.ParsePacket(buffer);
            ClientForm.AddItem(true, PManager.packet_id, idNames.GetClasseName(PManager.packet_id), PManager.packet_lenght, PManager.packet_content);
            PManager.ParsePacket(buffer);
            sender.associated.send(buffer);
        }

        private void forwardtoserver(Client sender, byte[] buffer)
        {
            PManager = new PackManager(ClientForm);
            string content_hex = string.Empty;
            int huit_bytes = 0;
            foreach (byte b in buffer)
            {
                content_hex += b.ToString("X2") + " ";
                huit_bytes++;
            }
            PManager.ParsePacket(buffer);
            ClientForm.AddItem(false, PManager.packet_id, idNames.GetClasseName(PManager.packet_id), PManager.packet_lenght, PManager.packet_content);
            //ClientForm.WriteLogClient(content_hex + "\tASCII = " + Encoding.ASCII.GetString(buffer));
            sender.associated.send(buffer);
        }
    }
}
