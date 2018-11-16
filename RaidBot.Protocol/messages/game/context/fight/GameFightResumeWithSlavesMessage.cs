


















// Generated on 06/26/2015 11:41:16
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightResumeWithSlavesMessage : GameFightResumeMessage
{

public const uint Id = 6215;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameFightResumeSlaveInfo[] slavesInfo;
        

public GameFightResumeWithSlavesMessage()
{
}

public GameFightResumeWithSlavesMessage(Types.FightDispellableEffectExtendedInformations[] effects, Types.GameActionMark[] marks, ushort gameTurn, int fightStart, Types.Idol[] idols, Types.GameFightSpellCooldown[] spellCooldowns, sbyte summonCount, sbyte bombCount, Types.GameFightResumeSlaveInfo[] slavesInfo)
         : base(effects, marks, gameTurn, fightStart, idols, spellCooldowns, summonCount, bombCount)
        {
            this.slavesInfo = slavesInfo;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)slavesInfo.Length);
            foreach (var entry in slavesInfo)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            slavesInfo = new Types.GameFightResumeSlaveInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 slavesInfo[i] = new Types.GameFightResumeSlaveInfo();
                 slavesInfo[i].Deserialize(reader);
            }
            

}


}


}