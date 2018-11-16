


















// Generated on 06/26/2015 11:40:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ConsoleCommandsListMessage : NetworkMessage
{

public const uint Id = 6127;
public override uint MessageId
{
    get { return Id; }
}

public string[] aliases;
        public string[] args;
        public string[] descriptions;
        

public ConsoleCommandsListMessage()
{
}

public ConsoleCommandsListMessage(string[] aliases, string[] args, string[] descriptions)
        {
            this.aliases = aliases;
            this.args = args;
            this.descriptions = descriptions;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)aliases.Length);
            foreach (var entry in aliases)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteUShort((ushort)args.Length);
            foreach (var entry in args)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteUShort((ushort)descriptions.Length);
            foreach (var entry in descriptions)
            {
                 writer.WriteUTF(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            aliases = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 aliases[i] = reader.ReadUTF();
            }
            limit = reader.ReadUShort();
            args = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 args[i] = reader.ReadUTF();
            }
            limit = reader.ReadUShort();
            descriptions = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 descriptions[i] = reader.ReadUTF();
            }
            

}


}


}