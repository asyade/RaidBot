


















// Generated on 06/26/2015 11:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class LockableStateUpdateStorageMessage : LockableStateUpdateAbstractMessage
{

public const uint Id = 5669;
public override uint MessageId
{
    get { return Id; }
}

public int mapId;
        public uint elementId;
        

public LockableStateUpdateStorageMessage()
{
}

public LockableStateUpdateStorageMessage(bool locked, int mapId, uint elementId)
         : base(locked)
        {
            this.mapId = mapId;
            this.elementId = elementId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(mapId);
            writer.WriteVaruhint(elementId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            mapId = reader.ReadInt();
            elementId = reader.ReadVaruhint();
            if (elementId < 0)
                throw new Exception("Forbidden value on elementId = " + elementId + ", it doesn't respect the following condition : elementId < 0");
            

}


}


}