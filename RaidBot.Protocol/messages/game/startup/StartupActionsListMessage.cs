


















// Generated on 06/26/2015 11:41:56
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class StartupActionsListMessage : NetworkMessage
{

public const uint Id = 1301;
public override uint MessageId
{
    get { return Id; }
}

public Types.StartupActionAddObject[] actions;
        

public StartupActionsListMessage()
{
}

public StartupActionsListMessage(Types.StartupActionAddObject[] actions)
        {
            this.actions = actions;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)actions.Length);
            foreach (var entry in actions)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            actions = new Types.StartupActionAddObject[limit];
            for (int i = 0; i < limit; i++)
            {
                 actions[i] = new Types.StartupActionAddObject();
                 actions[i].Deserialize(reader);
            }
            

}


}


}