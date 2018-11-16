


















// Generated on 06/26/2015 11:41:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharacterSelectionWithRemodelMessage : CharacterSelectionMessage
{

public const uint Id = 6549;
public override uint MessageId
{
    get { return Id; }
}

public Types.RemodelingInformation remodel;
        

public CharacterSelectionWithRemodelMessage()
{
}

public CharacterSelectionWithRemodelMessage(int id, Types.RemodelingInformation remodel)
         : base(id)
        {
            this.remodel = remodel;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            remodel.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            remodel = new Types.RemodelingInformation();
            remodel.Deserialize(reader);
            

}


}


}