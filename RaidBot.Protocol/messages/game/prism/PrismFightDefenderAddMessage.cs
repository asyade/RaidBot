


















// Generated on 06/26/2015 11:41:54
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismFightDefenderAddMessage : NetworkMessage
{

public const uint Id = 5895;
public override uint MessageId
{
    get { return Id; }
}

public ushort subAreaId;
        public ushort fightId;
        public Types.CharacterMinimalPlusLookInformations defender;
        

public PrismFightDefenderAddMessage()
{
}

public PrismFightDefenderAddMessage(ushort subAreaId, ushort fightId, Types.CharacterMinimalPlusLookInformations defender)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.defender = defender;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(subAreaId);
            writer.WriteVaruhshort(fightId);
            writer.WriteShort(defender.TypeId);
            defender.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

subAreaId = reader.ReadVaruhshort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            fightId = reader.ReadVaruhshort();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            defender = Types.ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadShort());
            defender.Deserialize(reader);
            

}


}


}