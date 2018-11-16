


















// Generated on 06/26/2015 11:41:22
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class EmotePlayMessage : EmotePlayAbstractMessage
{

public const uint Id = 5683;
public override uint MessageId
{
    get { return Id; }
}

public int actorId;
        public int accountId;
        

public EmotePlayMessage()
{
}

public EmotePlayMessage(byte emoteId, double emoteStartTime, int actorId, int accountId)
         : base(emoteId, emoteStartTime)
        {
            this.actorId = actorId;
            this.accountId = accountId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(actorId);
            writer.WriteInt(accountId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            actorId = reader.ReadInt();
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            

}


}


}