


















// Generated on 06/26/2015 11:41:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightCloseCombatMessage : AbstractGameActionFightTargetedAbilityMessage
{

public const uint Id = 6116;
public override uint MessageId
{
    get { return Id; }
}

public ushort weaponGenericId;
        

public GameActionFightCloseCombatMessage()
{
}

public GameActionFightCloseCombatMessage(ushort actionId, int sourceId, int targetId, short destinationCellId, sbyte critical, bool silentCast, ushort weaponGenericId)
         : base(actionId, sourceId, targetId, destinationCellId, critical, silentCast)
        {
            this.weaponGenericId = weaponGenericId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(weaponGenericId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            weaponGenericId = reader.ReadVaruhshort();
            if (weaponGenericId < 0)
                throw new Exception("Forbidden value on weaponGenericId = " + weaponGenericId + ", it doesn't respect the following condition : weaponGenericId < 0");
            

}


}


}