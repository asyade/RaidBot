


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TaxCollectorMovementMessage : NetworkMessage
{

public const uint Id = 5633;
public override uint MessageId
{
    get { return Id; }
}

public bool hireOrFire;
        public Types.TaxCollectorBasicInformations basicInfos;
        public uint playerId;
        public string playerName;
        

public TaxCollectorMovementMessage()
{
}

public TaxCollectorMovementMessage(bool hireOrFire, Types.TaxCollectorBasicInformations basicInfos, uint playerId, string playerName)
        {
            this.hireOrFire = hireOrFire;
            this.basicInfos = basicInfos;
            this.playerId = playerId;
            this.playerName = playerName;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(hireOrFire);
            basicInfos.Serialize(writer);
            writer.WriteVaruhint(playerId);
            writer.WriteUTF(playerName);
            

}

public override void Deserialize(ICustomDataReader reader)
{

hireOrFire = reader.ReadBoolean();
            basicInfos = new Types.TaxCollectorBasicInformations();
            basicInfos.Deserialize(reader);
            playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            playerName = reader.ReadUTF();
            

}


}


}