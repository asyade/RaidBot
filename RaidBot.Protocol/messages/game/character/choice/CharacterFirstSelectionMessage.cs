


















// Generated on 06/26/2015 11:41:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharacterFirstSelectionMessage : CharacterSelectionMessage
{

public const uint Id = 6084;
public override uint MessageId
{
    get { return Id; }
}

public bool doTutorial;
        

public CharacterFirstSelectionMessage()
{
}

public CharacterFirstSelectionMessage(int id, bool doTutorial)
         : base(id)
        {
            this.doTutorial = doTutorial;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(doTutorial);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            doTutorial = reader.ReadBoolean();
            

}


}


}