


















// Generated on 06/26/2015 11:41:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharactersListWithRemodelingMessage : CharactersListMessage
{

public const uint Id = 6550;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterToRemodelInformations[] charactersToRemodel;
        

public CharactersListWithRemodelingMessage()
{
}

public CharactersListWithRemodelingMessage(Types.CharacterBaseInformations[] characters, bool hasStartupActions, Types.CharacterToRemodelInformations[] charactersToRemodel)
         : base(characters, hasStartupActions)
        {
            this.charactersToRemodel = charactersToRemodel;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)charactersToRemodel.Length);
            foreach (var entry in charactersToRemodel)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            charactersToRemodel = new Types.CharacterToRemodelInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 charactersToRemodel[i] = new Types.CharacterToRemodelInformations();
                 charactersToRemodel[i].Deserialize(reader);
            }
            

}


}


}