


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SpellForgottenMessage : NetworkMessage
{

public const uint Id = 5834;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] spellsId;
        public ushort boostPoint;
        

public SpellForgottenMessage()
{
}

public SpellForgottenMessage(ushort[] spellsId, ushort boostPoint)
        {
            this.spellsId = spellsId;
            this.boostPoint = boostPoint;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)spellsId.Length);
            foreach (var entry in spellsId)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteVaruhshort(boostPoint);
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            spellsId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 spellsId[i] = reader.ReadVaruhshort();
            }
            boostPoint = reader.ReadVaruhshort();
            if (boostPoint < 0)
                throw new Exception("Forbidden value on boostPoint = " + boostPoint + ", it doesn't respect the following condition : boostPoint < 0");
            

}


}


}