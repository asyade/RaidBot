


















// Generated on 06/26/2015 11:40:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SelectedServerRefusedMessage : NetworkMessage
{

public const uint Id = 41;
public override uint MessageId
{
    get { return Id; }
}

public ushort serverId;
        public sbyte error;
        public sbyte serverStatus;
        

public SelectedServerRefusedMessage()
{
}

public SelectedServerRefusedMessage(ushort serverId, sbyte error, sbyte serverStatus)
        {
            this.serverId = serverId;
            this.error = error;
            this.serverStatus = serverStatus;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(serverId);
            writer.WriteSByte(error);
            writer.WriteSByte(serverStatus);
            

}

public override void Deserialize(ICustomDataReader reader)
{

serverId = reader.ReadVaruhshort();
            if (serverId < 0)
                throw new Exception("Forbidden value on serverId = " + serverId + ", it doesn't respect the following condition : serverId < 0");
            error = reader.ReadSByte();
            if (error < 0)
                throw new Exception("Forbidden value on error = " + error + ", it doesn't respect the following condition : error < 0");
            serverStatus = reader.ReadSByte();
            if (serverStatus < 0)
                throw new Exception("Forbidden value on serverStatus = " + serverStatus + ", it doesn't respect the following condition : serverStatus < 0");
            

}


}


}