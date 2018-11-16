


















// Generated on 06/26/2015 11:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildInfosUpgradeMessage : NetworkMessage
{

public const uint Id = 5636;
public override uint MessageId
{
    get { return Id; }
}

public sbyte maxTaxCollectorsCount;
        public sbyte taxCollectorsCount;
        public ushort taxCollectorLifePoints;
        public ushort taxCollectorDamagesBonuses;
        public ushort taxCollectorPods;
        public ushort taxCollectorProspecting;
        public ushort taxCollectorWisdom;
        public ushort boostPoints;
        public ushort[] spellId;
        public sbyte[] spellLevel;
        

public GuildInfosUpgradeMessage()
{
}

public GuildInfosUpgradeMessage(sbyte maxTaxCollectorsCount, sbyte taxCollectorsCount, ushort taxCollectorLifePoints, ushort taxCollectorDamagesBonuses, ushort taxCollectorPods, ushort taxCollectorProspecting, ushort taxCollectorWisdom, ushort boostPoints, ushort[] spellId, sbyte[] spellLevel)
        {
            this.maxTaxCollectorsCount = maxTaxCollectorsCount;
            this.taxCollectorsCount = taxCollectorsCount;
            this.taxCollectorLifePoints = taxCollectorLifePoints;
            this.taxCollectorDamagesBonuses = taxCollectorDamagesBonuses;
            this.taxCollectorPods = taxCollectorPods;
            this.taxCollectorProspecting = taxCollectorProspecting;
            this.taxCollectorWisdom = taxCollectorWisdom;
            this.boostPoints = boostPoints;
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(maxTaxCollectorsCount);
            writer.WriteSByte(taxCollectorsCount);
            writer.WriteVaruhshort(taxCollectorLifePoints);
            writer.WriteVaruhshort(taxCollectorDamagesBonuses);
            writer.WriteVaruhshort(taxCollectorPods);
            writer.WriteVaruhshort(taxCollectorProspecting);
            writer.WriteVaruhshort(taxCollectorWisdom);
            writer.WriteVaruhshort(boostPoints);
            writer.WriteUShort((ushort)spellId.Length);
            foreach (var entry in spellId)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)spellLevel.Length);
            foreach (var entry in spellLevel)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

maxTaxCollectorsCount = reader.ReadSByte();
            if (maxTaxCollectorsCount < 0)
                throw new Exception("Forbidden value on maxTaxCollectorsCount = " + maxTaxCollectorsCount + ", it doesn't respect the following condition : maxTaxCollectorsCount < 0");
            taxCollectorsCount = reader.ReadSByte();
            if (taxCollectorsCount < 0)
                throw new Exception("Forbidden value on taxCollectorsCount = " + taxCollectorsCount + ", it doesn't respect the following condition : taxCollectorsCount < 0");
            taxCollectorLifePoints = reader.ReadVaruhshort();
            if (taxCollectorLifePoints < 0)
                throw new Exception("Forbidden value on taxCollectorLifePoints = " + taxCollectorLifePoints + ", it doesn't respect the following condition : taxCollectorLifePoints < 0");
            taxCollectorDamagesBonuses = reader.ReadVaruhshort();
            if (taxCollectorDamagesBonuses < 0)
                throw new Exception("Forbidden value on taxCollectorDamagesBonuses = " + taxCollectorDamagesBonuses + ", it doesn't respect the following condition : taxCollectorDamagesBonuses < 0");
            taxCollectorPods = reader.ReadVaruhshort();
            if (taxCollectorPods < 0)
                throw new Exception("Forbidden value on taxCollectorPods = " + taxCollectorPods + ", it doesn't respect the following condition : taxCollectorPods < 0");
            taxCollectorProspecting = reader.ReadVaruhshort();
            if (taxCollectorProspecting < 0)
                throw new Exception("Forbidden value on taxCollectorProspecting = " + taxCollectorProspecting + ", it doesn't respect the following condition : taxCollectorProspecting < 0");
            taxCollectorWisdom = reader.ReadVaruhshort();
            if (taxCollectorWisdom < 0)
                throw new Exception("Forbidden value on taxCollectorWisdom = " + taxCollectorWisdom + ", it doesn't respect the following condition : taxCollectorWisdom < 0");
            boostPoints = reader.ReadVaruhshort();
            if (boostPoints < 0)
                throw new Exception("Forbidden value on boostPoints = " + boostPoints + ", it doesn't respect the following condition : boostPoints < 0");
            var limit = reader.ReadUShort();
            spellId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 spellId[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            spellLevel = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 spellLevel[i] = reader.ReadSByte();
            }
            

}


}


}