using Mybot.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBot.Protocol.Connection
{
    class SelectedServerDataMessage
    {
        public const int ProtocolId = 42;

        public virtual uint ServerId
        {
            get
            {
                return _serverId;
            }
            set
            {
                _serverId = value;
            }
        }

        private uint _serverId;

        public virtual string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        private string _address;

        public virtual ushort Port
        {
            get
            {
                return _port;
            }
            set
            {
                _port = value;
            }
        }

        private ushort _port;

        public virtual bool CanCreateNewCharacter
        {
            get
            {
                return _canCreateNewCharacter;
            }
            set
            {
                _canCreateNewCharacter = value;
            }
        }

        private bool _canCreateNewCharacter;

        public sbyte[] ticket
        {
            get
            {
                return _ticket;
            }
            set
            {
                _ticket = value;
            }
        }

        private sbyte[] _ticket;



        public void Deserialize(BigEndianReader _reader)
        {
            _serverId = _reader.ReadVarUhShort();
            if (_serverId < 0)
            {
                throw new Exception("Forbidden value (" + _serverId + ") on element of SelectedServerDataMessage.serverId.");
            }
            _address = _reader.ReadUTF();
            _port = _reader.ReadUShort();
            if (_port < 0 || _port > 65535)
            {
                throw new Exception("Forbidden value (" + _port + ") on element of SelectedServerDataMessage.port.");
            }
            _canCreateNewCharacter = _reader.ReadBoolean();
            var limit = (ushort)_reader.ReadVarInt();
            ticket = new sbyte[limit];
            for(int i = 0; i < limit; i++)
            {
                ticket[i] = _reader.ReadSByte();
            }
        }

    }
}
