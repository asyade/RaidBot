


















// Generated on 06/26/2015 11:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyMemberInFightMessage : AbstractPartyMessage
{

public const uint Id = 6342;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        public uint memberId;
        public int memberAccountId;
        public string memberName;
        public int fightId;
        public Types.MapCoordinatesExtended fightMap;
        public short timeBeforeFightStart;
        

public PartyMemberInFightMessage()
{
}

public PartyMemberInFightMessage(uint partyId, sbyte reason, uint memberId, int memberAccountId, string memberName, int fightId, Types.MapCoordinatesExtended fightMap, short timeBeforeFightStart)
         : base(partyId)
        {
            this.reason = reason;
            this.memberId = memberId;
            this.memberAccountId = memberAccountId;
            this.memberName = memberName;
            this.fightId = fightId;
            this.fightMap = fightMap;
            this.timeBeforeFightStart = timeBeforeFightStart;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(reason);
            writer.WriteVaruhint(memberId);
            writer.WriteInt(memberAccountId);
            writer.WriteUTF(memberName);
            writer.WriteInt(fightId);
            fightMap.Serialize(writer);
            writer.WriteVarshort(timeBeforeFightStart);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            reason = reader.ReadSByte();
            if (reason < 0)
                throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            memberId = reader.ReadVaruhint();
            if (memberId < 0)
                throw new Exception("Forbidden value on memberId = " + memberId + ", it doesn't respect the following condition : memberId < 0");
            memberAccountId = reader.ReadInt();
            if (memberAccountId < 0)
                throw new Exception("Forbidden value on memberAccountId = " + memberAccountId + ", it doesn't respect the following condition : memberAccountId < 0");
            memberName = reader.ReadUTF();
            fightId = reader.ReadInt();
            fightMap = new Types.MapCoordinatesExtended();
            fightMap.Deserialize(reader);
            timeBeforeFightStart = reader.ReadVarshort();
            

}


}


}