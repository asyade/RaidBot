


















// Generated on 06/26/2015 11:41:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class BasicCharactersListMessage : NetworkMessage
{

public const uint Id = 6475;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterBaseInformations[] characters;
        

public BasicCharactersListMessage()
{
}

public BasicCharactersListMessage(Types.CharacterBaseInformations[] characters)
        {
            this.characters = characters;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)characters.Length);
            foreach (var entry in characters)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            characters = new Types.CharacterBaseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 characters[i] = Types.ProtocolTypeManager.GetInstance<Types.CharacterBaseInformations>(reader.ReadShort());
                 characters[i].Deserialize(reader);
            }
            

}


}


}