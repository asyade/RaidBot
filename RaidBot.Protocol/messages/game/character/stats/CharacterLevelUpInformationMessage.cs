


















// Generated on 06/26/2015 11:41:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharacterLevelUpInformationMessage : CharacterLevelUpMessage
{

public const uint Id = 6076;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public uint id;
        

public CharacterLevelUpInformationMessage()
{
}

public CharacterLevelUpInformationMessage(byte newLevel, string name, uint id)
         : base(newLevel)
        {
            this.name = name;
            this.id = id;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteVaruhint(id);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            id = reader.ReadVaruhint();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            

}


}


}