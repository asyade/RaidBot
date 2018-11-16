


















// Generated on 06/26/2015 11:41:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightActivateGlyphTrapMessage : AbstractGameActionMessage
{

public const uint Id = 6545;
public override uint MessageId
{
    get { return Id; }
}

public short markId;
        public bool active;
        

public GameActionFightActivateGlyphTrapMessage()
{
}

public GameActionFightActivateGlyphTrapMessage(ushort actionId, int sourceId, short markId, bool active)
         : base(actionId, sourceId)
        {
            this.markId = markId;
            this.active = active;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(markId);
            writer.WriteBoolean(active);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            markId = reader.ReadShort();
            active = reader.ReadBoolean();
            

}


}


}