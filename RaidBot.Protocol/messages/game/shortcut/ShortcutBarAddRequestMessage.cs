


















// Generated on 06/26/2015 11:41:55
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ShortcutBarAddRequestMessage : NetworkMessage
{

public const uint Id = 6225;
public override uint MessageId
{
    get { return Id; }
}

public sbyte barType;
        public Types.Shortcut shortcut;
        

public ShortcutBarAddRequestMessage()
{
}

public ShortcutBarAddRequestMessage(sbyte barType, Types.Shortcut shortcut)
        {
            this.barType = barType;
            this.shortcut = shortcut;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(barType);
            writer.WriteShort(shortcut.TypeId);
            shortcut.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

barType = reader.ReadSByte();
            if (barType < 0)
                throw new Exception("Forbidden value on barType = " + barType + ", it doesn't respect the following condition : barType < 0");
            shortcut = Types.ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadShort());
            shortcut.Deserialize(reader);
            

}


}


}