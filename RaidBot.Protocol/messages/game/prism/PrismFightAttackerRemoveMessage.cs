


















// Generated on 06/26/2015 11:41:54
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismFightAttackerRemoveMessage : NetworkMessage
{

public const uint Id = 5897;
public override uint MessageId
{
    get { return Id; }
}

public ushort subAreaId;
        public ushort fightId;
        public uint fighterToRemoveId;
        

public PrismFightAttackerRemoveMessage()
{
}

public PrismFightAttackerRemoveMessage(ushort subAreaId, ushort fightId, uint fighterToRemoveId)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.fighterToRemoveId = fighterToRemoveId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(subAreaId);
            writer.WriteVaruhshort(fightId);
            writer.WriteVaruhint(fighterToRemoveId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

subAreaId = reader.ReadVaruhshort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            fightId = reader.ReadVaruhshort();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            fighterToRemoveId = reader.ReadVaruhint();
            if (fighterToRemoveId < 0)
                throw new Exception("Forbidden value on fighterToRemoveId = " + fighterToRemoveId + ", it doesn't respect the following condition : fighterToRemoveId < 0");
            

}


}


}