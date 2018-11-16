


















// Generated on 06/26/2015 11:42:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ShortcutObjectItem : ShortcutObject
{

public const short Id = 371;
public override short TypeId
{
    get { return Id; }
}

public int itemUID;
        public int itemGID;
        

public ShortcutObjectItem()
{
}

public ShortcutObjectItem(sbyte slot, int itemUID, int itemGID)
         : base(slot)
        {
            this.itemUID = itemUID;
            this.itemGID = itemGID;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(itemUID);
            writer.WriteInt(itemGID);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            itemUID = reader.ReadInt();
            itemGID = reader.ReadInt();
            

}


}


}