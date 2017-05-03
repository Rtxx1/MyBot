using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBot.Protocol
{
    public abstract class NetworkMessage
    {
        public abstract void Deserialize(BigEndianReader _reader);

        public abstract void Serialize(BigEndianWriter _writer);
    }
}
