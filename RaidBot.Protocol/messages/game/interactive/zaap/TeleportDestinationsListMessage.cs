


















// Generated on 06/26/2015 11:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TeleportDestinationsListMessage : NetworkMessage
{

public const uint Id = 5960;
public override uint MessageId
{
    get { return Id; }
}

public sbyte teleporterType;
        public int[] mapIds;
        public ushort[] subAreaIds;
        public ushort[] costs;
        public sbyte[] destTeleporterType;
        

public TeleportDestinationsListMessage()
{
}

public TeleportDestinationsListMessage(sbyte teleporterType, int[] mapIds, ushort[] subAreaIds, ushort[] costs, sbyte[] destTeleporterType)
        {
            this.teleporterType = teleporterType;
            this.mapIds = mapIds;
            this.subAreaIds = subAreaIds;
            this.costs = costs;
            this.destTeleporterType = destTeleporterType;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(teleporterType);
            writer.WriteUShort((ushort)mapIds.Length);
            foreach (var entry in mapIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteUShort((ushort)subAreaIds.Length);
            foreach (var entry in subAreaIds)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)costs.Length);
            foreach (var entry in costs)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)destTeleporterType.Length);
            foreach (var entry in destTeleporterType)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

teleporterType = reader.ReadSByte();
            if (teleporterType < 0)
                throw new Exception("Forbidden value on teleporterType = " + teleporterType + ", it doesn't respect the following condition : teleporterType < 0");
            var limit = reader.ReadUShort();
            mapIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 mapIds[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            subAreaIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 subAreaIds[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            costs = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 costs[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            destTeleporterType = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 destTeleporterType[i] = reader.ReadSByte();
            }
            

}


}


}