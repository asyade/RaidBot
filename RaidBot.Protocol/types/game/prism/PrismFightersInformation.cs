


















// Generated on 06/26/2015 11:42:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PrismFightersInformation
{

public const short Id = 443;
public virtual short TypeId
{
    get { return Id; }
}

public ushort subAreaId;
        public Types.ProtectedEntityWaitingForHelpInfo waitingForHelpInfo;
        public Types.CharacterMinimalPlusLookInformations[] allyCharactersInformations;
        public Types.CharacterMinimalPlusLookInformations[] enemyCharactersInformations;
        

public PrismFightersInformation()
{
}

public PrismFightersInformation(ushort subAreaId, Types.ProtectedEntityWaitingForHelpInfo waitingForHelpInfo, Types.CharacterMinimalPlusLookInformations[] allyCharactersInformations, Types.CharacterMinimalPlusLookInformations[] enemyCharactersInformations)
        {
            this.subAreaId = subAreaId;
            this.waitingForHelpInfo = waitingForHelpInfo;
            this.allyCharactersInformations = allyCharactersInformations;
            this.enemyCharactersInformations = enemyCharactersInformations;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(subAreaId);
            waitingForHelpInfo.Serialize(writer);
            writer.WriteUShort((ushort)allyCharactersInformations.Length);
            foreach (var entry in allyCharactersInformations)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)enemyCharactersInformations.Length);
            foreach (var entry in enemyCharactersInformations)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

subAreaId = reader.ReadVaruhshort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            waitingForHelpInfo = new Types.ProtectedEntityWaitingForHelpInfo();
            waitingForHelpInfo.Deserialize(reader);
            var limit = reader.ReadUShort();
            allyCharactersInformations = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 allyCharactersInformations[i] = Types.ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadShort());
                 allyCharactersInformations[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            enemyCharactersInformations = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 enemyCharactersInformations[i] = Types.ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadShort());
                 enemyCharactersInformations[i].Deserialize(reader);
            }
            

}


}


}