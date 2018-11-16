


















// Generated on 06/26/2015 11:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyInvitationMessage : AbstractPartyMessage
{

public const uint Id = 5586;
public override uint MessageId
{
    get { return Id; }
}

public sbyte partyType;
        public string partyName;
        public sbyte maxParticipants;
        public uint fromId;
        public string fromName;
        public uint toId;
        

public PartyInvitationMessage()
{
}

public PartyInvitationMessage(uint partyId, sbyte partyType, string partyName, sbyte maxParticipants, uint fromId, string fromName, uint toId)
         : base(partyId)
        {
            this.partyType = partyType;
            this.partyName = partyName;
            this.maxParticipants = maxParticipants;
            this.fromId = fromId;
            this.fromName = fromName;
            this.toId = toId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(partyType);
            writer.WriteUTF(partyName);
            writer.WriteSByte(maxParticipants);
            writer.WriteVaruhint(fromId);
            writer.WriteUTF(fromName);
            writer.WriteVaruhint(toId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            partyType = reader.ReadSByte();
            if (partyType < 0)
                throw new Exception("Forbidden value on partyType = " + partyType + ", it doesn't respect the following condition : partyType < 0");
            partyName = reader.ReadUTF();
            maxParticipants = reader.ReadSByte();
            if (maxParticipants < 0)
                throw new Exception("Forbidden value on maxParticipants = " + maxParticipants + ", it doesn't respect the following condition : maxParticipants < 0");
            fromId = reader.ReadVaruhint();
            if (fromId < 0)
                throw new Exception("Forbidden value on fromId = " + fromId + ", it doesn't respect the following condition : fromId < 0");
            fromName = reader.ReadUTF();
            toId = reader.ReadVaruhint();
            if (toId < 0)
                throw new Exception("Forbidden value on toId = " + toId + ", it doesn't respect the following condition : toId < 0");
            

}


}


}