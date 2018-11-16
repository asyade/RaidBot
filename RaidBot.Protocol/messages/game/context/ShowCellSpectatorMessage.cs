


















// Generated on 06/26/2015 11:41:14
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ShowCellSpectatorMessage : ShowCellMessage
{

public const uint Id = 6158;
public override uint MessageId
{
    get { return Id; }
}

public string playerName;
        

public ShowCellSpectatorMessage()
{
}

public ShowCellSpectatorMessage(int sourceId, ushort cellId, string playerName)
         : base(sourceId, cellId)
        {
            this.playerName = playerName;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(playerName);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            playerName = reader.ReadUTF();
            

}


}


}