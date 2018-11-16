


















// Generated on 06/26/2015 11:41:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharactersListMessage : BasicCharactersListMessage
{

public const uint Id = 151;
public override uint MessageId
{
    get { return Id; }
}

public bool hasStartupActions;
        

public CharactersListMessage()
{
}

public CharactersListMessage(Types.CharacterBaseInformations[] characters, bool hasStartupActions)
         : base(characters)
        {
            this.hasStartupActions = hasStartupActions;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(hasStartupActions);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            hasStartupActions = reader.ReadBoolean();
            

}


}


}