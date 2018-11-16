


















// Generated on 06/26/2015 11:41:12
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class EnabledChannelsMessage : NetworkMessage
{

public const uint Id = 892;
public override uint MessageId
{
    get { return Id; }
}

public sbyte[] channels;
        public sbyte[] disallowed;
        

public EnabledChannelsMessage()
{
}

public EnabledChannelsMessage(sbyte[] channels, sbyte[] disallowed)
        {
            this.channels = channels;
            this.disallowed = disallowed;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)channels.Length);
            foreach (var entry in channels)
            {
                 writer.WriteSByte(entry);
            }
            writer.WriteUShort((ushort)disallowed.Length);
            foreach (var entry in disallowed)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            channels = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 channels[i] = reader.ReadSByte();
            }
            limit = reader.ReadUShort();
            disallowed = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 disallowed[i] = reader.ReadSByte();
            }
            

}


}


}