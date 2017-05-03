using Mybot.IO;
using MyBot.Interface;
using MyBot.Protocol.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBot.Protocol
{
    class PackManager
    {
        private FormBot ClientForm;

        #region Getter Setter

        private short _packet_id;

        public virtual short packet_id
        {
            get { return _packet_id; }
            set { _packet_id = value; }
        }

        private Int32 _packet_lenght;

        public virtual Int32 packet_lenght
        {
            get { return _packet_lenght; }
            set { _packet_lenght = value; }
        }

        private byte[] _packet_content;

        public virtual byte[] packet_content
        {
            get { return _packet_content; }
            set { _packet_content = value; }
        }
        #endregion

        public PackManager(FormBot _ClientForm)
        {
            ClientForm = _ClientForm;
        }

        public void ParsePacket(byte[] PacketToParse)
        {
            try
            {
                string content_hex = string.Empty;
                int huit_bytes = 0;
                foreach (byte b in PacketToParse)
                {
                    content_hex += b.ToString("X2") + " ";
                    huit_bytes++;
                }
                ClientForm.WriteLog("Paquet reçu = " + content_hex + "\nAnalyse...");
                // Déclaration des variables qui seront utilisées
                int index = 0;
                short id_and_packet_lenght_type, packet_lenght_type;
                _packet_lenght = 0;

                // Lecture jusqu'à la fin de byte[] data
                while (index != PacketToParse.Length)
                {
                    // Décodage du header
                    id_and_packet_lenght_type = (short)(PacketToParse[index] * 256 + PacketToParse[index + 1]); // Selection des 2 premiers octets du paquet
                    _packet_id = (short)(id_and_packet_lenght_type >> 2); // Récupérer l'ID du paquet
                    packet_lenght_type = (short)(id_and_packet_lenght_type & 3); // Récupérer la taille de la taille de la longueur du paquet

                    index += 2; // On se déplace 2 octets plus loin

                    if (packet_lenght_type < 0 || packet_lenght_type > 3)
                        throw new Exception("Malformated Message Header, invalid bytes number to read message length (inferior to 0 or superior to 3)");
                    // Récupération de la taille du paquet
                    switch (packet_lenght_type)
                    {
                        case 0:
                            _packet_lenght = 0;
                            break;
                        case 1:
                            _packet_lenght = PacketToParse[index];
                            break;
                        case 2:
                            _packet_lenght = PacketToParse[index] * 256 + PacketToParse[index + 1];
                            break;
                        case 3:
                            _packet_lenght = PacketToParse[index] * 65536 + PacketToParse[index + 1] * 256 + PacketToParse[index + 2];
                            break;
                    }
                    ClientForm.WriteLog("Id du Paquet = " + _packet_id);
                    _packet_content = new byte[(int)_packet_lenght];
                    Array.Copy(PacketToParse, index + packet_lenght_type, _packet_content, 0, _packet_lenght);
                    TreatPacket(_packet_id, _packet_content);
                    index += _packet_lenght + packet_lenght_type;
                }
            }
            catch (Exception e)
            {
                ClientForm.WriteError(e.ToString());
            }
        }


        public void TreatPacket(int packetID, byte[] packetContent)
        {
            BigEndianReader reader = new BigEndianReader();
            switch (packetID)
            {
                case 42:
                    SelectedServerDataMessage Ssdm = new SelectedServerDataMessage();
                    Ssdm.Deserialize(reader);
                    ClientForm.WriteLog(Ssdm.ServerId + " " + Ssdm.Address + " " + Ssdm.Port + " " + Ssdm.CanCreateNewCharacter);
                    break;

            }
        }
    }
}
