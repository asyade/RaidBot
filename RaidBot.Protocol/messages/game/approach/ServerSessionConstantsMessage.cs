


















// Generated on 06/26/2015 11:41:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ServerSessionConstantsMessage : NetworkMessage
{

public const uint Id = 6434;
public override uint MessageId
{
    get { return Id; }
}

public Types.ServerSessionConstant[] variables;
        

public ServerSessionConstantsMessage()
{
}

public ServerSessionConstantsMessage(Types.ServerSessionConstant[] variables)
        {
            this.variables = variables;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)variables.Length);
            foreach (var entry in variables)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            variables = new Types.ServerSessionConstant[limit];
            for (int i = 0; i < limit; i++)
            {
                 variables[i] = Types.ProtocolTypeManager.GetInstance<Types.ServerSessionConstant>(reader.ReadShort());
                 variables[i].Deserialize(reader);
            }
            

}


}


}