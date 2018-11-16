


















// Generated on 06/26/2015 11:41:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightInvisibilityMessage : AbstractGameActionMessage
{

public const uint Id = 5821;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public sbyte state;
        

public GameActionFightInvisibilityMessage()
{
}

public GameActionFightInvisibilityMessage(ushort actionId, int sourceId, int targetId, sbyte state)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.state = state;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteSByte(state);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            state = reader.ReadSByte();
            if (state < 0)
                throw new Exception("Forbidden value on state = " + state + ", it doesn't respect the following condition : state < 0");
            

}


}


}