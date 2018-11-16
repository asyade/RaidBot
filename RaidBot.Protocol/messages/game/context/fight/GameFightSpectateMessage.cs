


















// Generated on 06/26/2015 11:41:17
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightSpectateMessage : NetworkMessage
{

public const uint Id = 6069;
public override uint MessageId
{
    get { return Id; }
}

public Types.FightDispellableEffectExtendedInformations[] effects;
        public Types.GameActionMark[] marks;
        public ushort gameTurn;
        public int fightStart;
        public Types.Idol[] idols;
        

public GameFightSpectateMessage()
{
}

public GameFightSpectateMessage(Types.FightDispellableEffectExtendedInformations[] effects, Types.GameActionMark[] marks, ushort gameTurn, int fightStart, Types.Idol[] idols)
        {
            this.effects = effects;
            this.marks = marks;
            this.gameTurn = gameTurn;
            this.fightStart = fightStart;
            this.idols = idols;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)effects.Length);
            foreach (var entry in effects)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)marks.Length);
            foreach (var entry in marks)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVaruhshort(gameTurn);
            writer.WriteInt(fightStart);
            writer.WriteUShort((ushort)idols.Length);
            foreach (var entry in idols)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            effects = new Types.FightDispellableEffectExtendedInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = new Types.FightDispellableEffectExtendedInformations();
                 effects[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            marks = new Types.GameActionMark[limit];
            for (int i = 0; i < limit; i++)
            {
                 marks[i] = new Types.GameActionMark();
                 marks[i].Deserialize(reader);
            }
            gameTurn = reader.ReadVaruhshort();
            if (gameTurn < 0)
                throw new Exception("Forbidden value on gameTurn = " + gameTurn + ", it doesn't respect the following condition : gameTurn < 0");
            fightStart = reader.ReadInt();
            if (fightStart < 0)
                throw new Exception("Forbidden value on fightStart = " + fightStart + ", it doesn't respect the following condition : fightStart < 0");
            limit = reader.ReadUShort();
            idols = new Types.Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 idols[i] = new Types.Idol();
                 idols[i].Deserialize(reader);
            }
            

}


}


}