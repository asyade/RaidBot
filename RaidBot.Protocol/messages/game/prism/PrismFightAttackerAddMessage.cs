


















// Generated on 06/26/2015 11:41:54
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismFightAttackerAddMessage : NetworkMessage
{

public const uint Id = 5893;
public override uint MessageId
{
    get { return Id; }
}

public ushort subAreaId;
        public ushort fightId;
        public Types.CharacterMinimalPlusLookInformations attacker;
        

public PrismFightAttackerAddMessage()
{
}

public PrismFightAttackerAddMessage(ushort subAreaId, ushort fightId, Types.CharacterMinimalPlusLookInformations attacker)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.attacker = attacker;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(subAreaId);
            writer.WriteVaruhshort(fightId);
            writer.WriteShort(attacker.TypeId);
            attacker.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

subAreaId = reader.ReadVaruhshort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            fightId = reader.ReadVaruhshort();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            attacker = Types.ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadShort());
            attacker.Deserialize(reader);
            

}


}


}