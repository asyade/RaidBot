


















// Generated on 06/26/2015 11:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyInvitationDungeonRequestMessage : PartyInvitationRequestMessage
{

public const uint Id = 6245;
public override uint MessageId
{
    get { return Id; }
}

public ushort dungeonId;
        

public PartyInvitationDungeonRequestMessage()
{
}

public PartyInvitationDungeonRequestMessage(string name, ushort dungeonId)
         : base(name)
        {
            this.dungeonId = dungeonId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(dungeonId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            dungeonId = reader.ReadVaruhshort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            

}


}


}