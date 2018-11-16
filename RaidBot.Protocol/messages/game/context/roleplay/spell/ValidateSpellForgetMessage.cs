


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ValidateSpellForgetMessage : NetworkMessage
{

public const uint Id = 1700;
public override uint MessageId
{
    get { return Id; }
}

public ushort spellId;
        

public ValidateSpellForgetMessage()
{
}

public ValidateSpellForgetMessage(ushort spellId)
        {
            this.spellId = spellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(spellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            

}


}


}