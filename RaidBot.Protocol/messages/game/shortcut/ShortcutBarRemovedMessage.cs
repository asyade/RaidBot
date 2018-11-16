


















// Generated on 06/26/2015 11:41:56
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ShortcutBarRemovedMessage : NetworkMessage
{

public const uint Id = 6224;
public override uint MessageId
{
    get { return Id; }
}

public sbyte barType;
        public sbyte slot;
        

public ShortcutBarRemovedMessage()
{
}

public ShortcutBarRemovedMessage(sbyte barType, sbyte slot)
        {
            this.barType = barType;
            this.slot = slot;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(barType);
            writer.WriteSByte(slot);
            

}

public override void Deserialize(ICustomDataReader reader)
{

barType = reader.ReadSByte();
            if (barType < 0)
                throw new Exception("Forbidden value on barType = " + barType + ", it doesn't respect the following condition : barType < 0");
            slot = reader.ReadSByte();
            if (slot < 0 || slot > 99)
                throw new Exception("Forbidden value on slot = " + slot + ", it doesn't respect the following condition : slot < 0 || slot > 99");
            

}


}


}