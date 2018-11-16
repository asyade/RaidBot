


















// Generated on 06/26/2015 11:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MimicryObjectFeedAndAssociateRequestMessage : SymbioticObjectAssociateRequestMessage
{

public const uint Id = 6460;
public override uint MessageId
{
    get { return Id; }
}

public uint foodUID;
        public byte foodPos;
        public bool preview;
        

public MimicryObjectFeedAndAssociateRequestMessage()
{
}

public MimicryObjectFeedAndAssociateRequestMessage(uint symbioteUID, byte symbiotePos, uint hostUID, byte hostPos, uint foodUID, byte foodPos, bool preview)
         : base(symbioteUID, symbiotePos, hostUID, hostPos)
        {
            this.foodUID = foodUID;
            this.foodPos = foodPos;
            this.preview = preview;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(foodUID);
            writer.WriteByte(foodPos);
            writer.WriteBoolean(preview);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            foodUID = reader.ReadVaruhint();
            if (foodUID < 0)
                throw new Exception("Forbidden value on foodUID = " + foodUID + ", it doesn't respect the following condition : foodUID < 0");
            foodPos = reader.ReadByte();
            if (foodPos < 0 || foodPos > 255)
                throw new Exception("Forbidden value on foodPos = " + foodPos + ", it doesn't respect the following condition : foodPos < 0 || foodPos > 255");
            preview = reader.ReadBoolean();
            

}


}


}