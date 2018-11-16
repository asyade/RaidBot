


















// Generated on 06/26/2015 11:42:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AllianceInsiderPrismInformation : PrismInformation
{

public const short Id = 431;
public override short TypeId
{
    get { return Id; }
}

public int lastTimeSlotModificationDate;
        public uint lastTimeSlotModificationAuthorGuildId;
        public uint lastTimeSlotModificationAuthorId;
        public string lastTimeSlotModificationAuthorName;
        public uint[] modulesItemIds;
        

public AllianceInsiderPrismInformation()
{
}

public AllianceInsiderPrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount, int lastTimeSlotModificationDate, uint lastTimeSlotModificationAuthorGuildId, uint lastTimeSlotModificationAuthorId, string lastTimeSlotModificationAuthorName, uint[] modulesItemIds)
         : base(typeId, state, nextVulnerabilityDate, placementDate, rewardTokenCount)
        {
            this.lastTimeSlotModificationDate = lastTimeSlotModificationDate;
            this.lastTimeSlotModificationAuthorGuildId = lastTimeSlotModificationAuthorGuildId;
            this.lastTimeSlotModificationAuthorId = lastTimeSlotModificationAuthorId;
            this.lastTimeSlotModificationAuthorName = lastTimeSlotModificationAuthorName;
            this.modulesItemIds = modulesItemIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(lastTimeSlotModificationDate);
            writer.WriteVaruhint(lastTimeSlotModificationAuthorGuildId);
            writer.WriteVaruhint(lastTimeSlotModificationAuthorId);
            writer.WriteUTF(lastTimeSlotModificationAuthorName);
            writer.WriteUShort((ushort)modulesItemIds.Length);
            foreach (var entry in modulesItemIds)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            lastTimeSlotModificationDate = reader.ReadInt();
            if (lastTimeSlotModificationDate < 0)
                throw new Exception("Forbidden value on lastTimeSlotModificationDate = " + lastTimeSlotModificationDate + ", it doesn't respect the following condition : lastTimeSlotModificationDate < 0");
            lastTimeSlotModificationAuthorGuildId = reader.ReadVaruhint();
            if (lastTimeSlotModificationAuthorGuildId < 0)
                throw new Exception("Forbidden value on lastTimeSlotModificationAuthorGuildId = " + lastTimeSlotModificationAuthorGuildId + ", it doesn't respect the following condition : lastTimeSlotModificationAuthorGuildId < 0");
            lastTimeSlotModificationAuthorId = reader.ReadVaruhint();
            if (lastTimeSlotModificationAuthorId < 0)
                throw new Exception("Forbidden value on lastTimeSlotModificationAuthorId = " + lastTimeSlotModificationAuthorId + ", it doesn't respect the following condition : lastTimeSlotModificationAuthorId < 0");
            lastTimeSlotModificationAuthorName = reader.ReadUTF();
            var limit = reader.ReadUShort();
            modulesItemIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 modulesItemIds[i] = reader.ReadVaruhint();
            }
            

}


}


}