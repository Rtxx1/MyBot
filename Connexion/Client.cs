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
    class Client
    {
        private Socket _socket;
        private Thread lowreceivethread;
        private IPEndPoint _remoteEP;
        
        public delegate void onTravellingDataEventHandler(Client sender, byte[] buffer);
        public event onTravellingDataEventHandler onReception;
        public event onTravellingDataEventHandler onSending;

        /*public delegate void onClientDisconnect(Client SocketClient);
        public event onClientDisconnect onDisconnected;*/

        public Client associated;
        /// <summary>
        /// Get the IP and Port of the local socket
        /// </summary>
        public string IpAndPort
        {
            get { return _socket.RemoteEndPoint.ToString(); }
            set { IpAndPort = value; }
        }

        /// <summary>
        /// Create a new client with a socket already created
        /// </summary>
        /// <param name="socket"></param>
        public Client(Socket socket)
        {
            _socket = socket;
            startReceive();
        }

        /// <summary>
        /// Create a new client with a non-created socket
        /// </summary>
        /// <param name="serverip">IP End Point of the client</param>
        public Client(IPEndPoint serverip)
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // on initialise la socket
            _remoteEP = serverip;
        }
        
        /// <summary>
        /// Connect the socket to the Remote End Point
        /// </summary>
        public void connect()
        {
            _socket.Connect(_remoteEP); // on connecte la socket
            startReceive();
        }

        /// <summary>
        /// Thread to receive data continuously
        /// </summary>
        private void startReceive()
        {
            lowreceivethread = new Thread(new ThreadStart(lowreceive));
            lowreceivethread.Start(); // on démarre la boucle de reception
        }

        /// <summary>
        /// Receive the data - Method of the lowreceivethread thread  
        /// </summary>
        private void lowreceive()
        {
            while (_socket.Connected) // tant que la socket est connecté
            {
                //Thread.Sleep(200);
                if (_socket.Available > 0) // si le nombre de byte disponible est supérieur a 0
                {
                    byte[] buffer = new byte[_socket.Available]; // faire un tableau de byte de la longueur du nombre de bytes disponibles
                    _socket.Receive(buffer); // écrire les bytes disponibles dans le tableau de bytes
                    onReception?.Invoke(this, buffer); // un event qui dit qui a reçu des données et le tableau de bytes reçu
                }
            }
        }

        /// <summary>
        /// Send data from the local socket
        /// </summary>
        /// <param name="data"></param>
        public void send(byte[] data)
        {
            _socket.Send(data); // on écrit les données
            onSending?.Invoke(this, data); // un event qui indique qui envoi des données et quelles sont les données envoyées
        }
    }
}
