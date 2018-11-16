


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TaxCollectorDialogQuestionExtendedMessage : TaxCollectorDialogQuestionBasicMessage
{

public const uint Id = 5615;
public override uint MessageId
{
    get { return Id; }
}

public ushort maxPods;
        public ushort prospecting;
        public ushort wisdom;
        public sbyte taxCollectorsCount;
        public int taxCollectorAttack;
        public uint kamas;
        public ulong experience;
        public uint pods;
        public uint itemsValue;
        

public TaxCollectorDialogQuestionExtendedMessage()
{
}

public TaxCollectorDialogQuestionExtendedMessage(Types.BasicGuildInformations guildInfo, ushort maxPods, ushort prospecting, ushort wisdom, sbyte taxCollectorsCount, int taxCollectorAttack, uint kamas, ulong experience, uint pods, uint itemsValue)
         : base(guildInfo)
        {
            this.maxPods = maxPods;
            this.prospecting = prospecting;
            this.wisdom = wisdom;
            this.taxCollectorsCount = taxCollectorsCount;
            this.taxCollectorAttack = taxCollectorAttack;
            this.kamas = kamas;
            this.experience = experience;
            this.pods = pods;
            this.itemsValue = itemsValue;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(maxPods);
            writer.WriteVaruhshort(prospecting);
            writer.WriteVaruhshort(wisdom);
            writer.WriteSByte(taxCollectorsCount);
            writer.WriteInt(taxCollectorAttack);
            writer.WriteVaruhint(kamas);
            writer.WriteVaruhlong(experience);
            writer.WriteVaruhint(pods);
            writer.WriteVaruhint(itemsValue);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            maxPods = reader.ReadVaruhshort();
            if (maxPods < 0)
                throw new Exception("Forbidden value on maxPods = " + maxPods + ", it doesn't respect the following condition : maxPods < 0");
            prospecting = reader.ReadVaruhshort();
            if (prospecting < 0)
                throw new Exception("Forbidden value on prospecting = " + prospecting + ", it doesn't respect the following condition : prospecting < 0");
            wisdom = reader.ReadVaruhshort();
            if (wisdom < 0)
                throw new Exception("Forbidden value on wisdom = " + wisdom + ", it doesn't respect the following condition : wisdom < 0");
            taxCollectorsCount = reader.ReadSByte();
            if (taxCollectorsCount < 0)
                throw new Exception("Forbidden value on taxCollectorsCount = " + taxCollectorsCount + ", it doesn't respect the following condition : taxCollectorsCount < 0");
            taxCollectorAttack = reader.ReadInt();
            kamas = reader.ReadVaruhint();
            if (kamas < 0)
                throw new Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0");
            experience = reader.ReadVaruhlong();
            if (experience < 0 || experience > 9.007199254740992E15)
                throw new Exception("Forbidden value on experience = " + experience + ", it doesn't respect the following condition : experience < 0 || experience > 9.007199254740992E15");
            pods = reader.ReadVaruhint();
            if (pods < 0)
                throw new Exception("Forbidden value on pods = " + pods + ", it doesn't respect the following condition : pods < 0");
            itemsValue = reader.ReadVaruhint();
            if (itemsValue < 0)
                throw new Exception("Forbidden value on itemsValue = " + itemsValue + ", it doesn't respect the following condition : itemsValue < 0");
            

}


}


}