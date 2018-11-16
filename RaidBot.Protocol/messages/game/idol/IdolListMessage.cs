


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IdolListMessage : NetworkMessage
{

public const uint Id = 6585;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] chosenIdols;
        public ushort[] partyChosenIdols;
        public Types.PartyIdol[] partyIdols;
        

public IdolListMessage()
{
}

public IdolListMessage(ushort[] chosenIdols, ushort[] partyChosenIdols, Types.PartyIdol[] partyIdols)
        {
            this.chosenIdols = chosenIdols;
            this.partyChosenIdols = partyChosenIdols;
            this.partyIdols = partyIdols;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)chosenIdols.Length);
            foreach (var entry in chosenIdols)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)partyChosenIdols.Length);
            foreach (var entry in partyChosenIdols)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)partyIdols.Length);
            foreach (var entry in partyIdols)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            chosenIdols = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 chosenIdols[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            partyChosenIdols = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 partyChosenIdols[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            partyIdols = new Types.PartyIdol[limit];
            for (int i = 0; i < limit; i++)
            {
                 partyIdols[i] = Types.ProtocolTypeManager.GetInstance<Types.PartyIdol>(reader.ReadShort());
                 partyIdols[i].Deserialize(reader);
            }
            

}


}


}