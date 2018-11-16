


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IdolSelectErrorMessage : NetworkMessage
{

public const uint Id = 6584;
public override uint MessageId
{
    get { return Id; }
}

public bool activate;
        public bool party;
        public sbyte reason;
        public ushort idolId;
        

public IdolSelectErrorMessage()
{
}

public IdolSelectErrorMessage(bool activate, bool party, sbyte reason, ushort idolId)
        {
            this.activate = activate;
            this.party = party;
            this.reason = reason;
            this.idolId = idolId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, activate);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, party);
            writer.WriteByte(flag1);
            writer.WriteSByte(reason);
            writer.WriteVaruhshort(idolId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

byte flag1 = reader.ReadByte();
            activate = BooleanByteWrapper.GetFlag(flag1, 0);
            party = BooleanByteWrapper.GetFlag(flag1, 1);
            reason = reader.ReadSByte();
            if (reason < 0)
                throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            idolId = reader.ReadVaruhshort();
            if (idolId < 0)
                throw new Exception("Forbidden value on idolId = " + idolId + ", it doesn't respect the following condition : idolId < 0");
            

}


}


}