


















// Generated on 06/26/2015 11:41:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TrustStatusMessage : NetworkMessage
{

public const uint Id = 6267;
public override uint MessageId
{
    get { return Id; }
}

public bool trusted;
        public bool certified;
        

public TrustStatusMessage()
{
}

public TrustStatusMessage(bool trusted, bool certified)
        {
            this.trusted = trusted;
            this.certified = certified;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, trusted);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, certified);
            writer.WriteByte(flag1);
            

}

public override void Deserialize(ICustomDataReader reader)
{

byte flag1 = reader.ReadByte();
            trusted = BooleanByteWrapper.GetFlag(flag1, 0);
            certified = BooleanByteWrapper.GetFlag(flag1, 1);
            

}


}


}