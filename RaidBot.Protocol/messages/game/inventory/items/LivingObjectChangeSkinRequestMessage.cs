


















// Generated on 06/26/2015 11:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class LivingObjectChangeSkinRequestMessage : NetworkMessage
{

public const uint Id = 5725;
public override uint MessageId
{
    get { return Id; }
}

public uint livingUID;
        public byte livingPosition;
        public uint skinId;
        

public LivingObjectChangeSkinRequestMessage()
{
}

public LivingObjectChangeSkinRequestMessage(uint livingUID, byte livingPosition, uint skinId)
        {
            this.livingUID = livingUID;
            this.livingPosition = livingPosition;
            this.skinId = skinId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(livingUID);
            writer.WriteByte(livingPosition);
            writer.WriteVaruhint(skinId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

livingUID = reader.ReadVaruhint();
            if (livingUID < 0)
                throw new Exception("Forbidden value on livingUID = " + livingUID + ", it doesn't respect the following condition : livingUID < 0");
            livingPosition = reader.ReadByte();
            if (livingPosition < 0 || livingPosition > 255)
                throw new Exception("Forbidden value on livingPosition = " + livingPosition + ", it doesn't respect the following condition : livingPosition < 0 || livingPosition > 255");
            skinId = reader.ReadVaruhint();
            if (skinId < 0)
                throw new Exception("Forbidden value on skinId = " + skinId + ", it doesn't respect the following condition : skinId < 0");
            

}


}


}