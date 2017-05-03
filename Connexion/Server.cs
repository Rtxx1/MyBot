using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using MyBot.Interface;

namespace MyBot.Connexion
{
    class Server
    {
        private Socket _socket;
        private Thread _acceptingthread;
        private IPEndPoint _localEP;

        public delegate void onClientActionEventHandler(Client client);
        public event onClientActionEventHandler onClientConnected;

        /// <summary>
        /// Constructor that connect the server socket and start the _acceptingthread thread
        /// </summary>
        public Server()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _acceptingthread = new Thread(new ThreadStart(accept));
            _localEP = new IPEndPoint(IPAddress.Loopback, 5555);
            _socket.Bind(_localEP); // écoute sur localhost
            _socket.Listen(100);
            _acceptingthread.Start(); // on démarre le thread d'acceptation
        }

        /// <summary>
        /// Accept clients - Method of the _acceptingthread thread
        /// </summary>
        public void accept()
        {
            while (true)
            {
                Socket socket = _socket.Accept(); // on recupère la socket du nouveau client
                Client client = new Client(socket);
                onClientConnected?.Invoke(client); // on l'envoi via l'event
            }
        }
    }
}
