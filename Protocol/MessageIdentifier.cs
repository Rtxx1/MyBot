using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBot.Protocol
{
    class MessageIdentifier
    {
        private static readonly Dictionary<int, string> Packets = new Dictionary<int, string>();

        /*public static void Initialize()
        {
            var asm = Assembly.GetAssembly(typeof(MessageIdentifier));
            foreach (var type in asm.GetTypes().Where(entry => entry.IsSubclassOf(typeof(NetworkMessage))))
            {
                var property = type.GetProperty("ProtocolId");
                if (property == null) continue;
                var num = (int)property.GetValue(Activator.CreateInstance(type), null);
                if (Packets.ContainsKey(num)) continue;
                Packets.Add(num, type.Name);
            }
        }*/

        public static string GetMessageName(int id) => Packets[id];
    }
}
