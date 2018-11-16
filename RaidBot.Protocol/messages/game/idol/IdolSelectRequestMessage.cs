


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IdolSelectRequestMessage : NetworkMessage
{

public const uint Id = 6587;
public override uint MessageId
{
    get { return Id; }
}

public bool activate;
        public bool party;
        public ushort idolId;
        

public IdolSelectRequestMessage()
{
}

public IdolSelectRequestMessage(bool activate, bool party, ushort idolId)
        {
            this.activate = activate;
            this.party = party;
            this.idolId = idolId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, activate);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, party);
            writer.WriteByte(flag1);
            writer.WriteVaruhshort(idolId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

byte flag1 = reader.ReadByte();
            activate = BooleanByteWrapper.GetFlag(flag1, 0);
            party = BooleanByteWrapper.GetFlag(flag1, 1);
            idolId = reader.ReadVaruhshort();
            if (idolId < 0)
                throw new Exception("Forbidden value on idolId = " + idolId + ", it doesn't respect the following condition : idolId < 0");
            

}


}


}