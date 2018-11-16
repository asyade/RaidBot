// Generated on 06/26/2015 11:40:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

    public class SelectedServerDataExtendedMessage : SelectedServerDataMessage
    {

        public const uint Id = 6469;
        public override uint MessageId
        {
            get { return Id; }
        }

        public ushort[] serverIds;


        public SelectedServerDataExtendedMessage()
        {
        }

        public SelectedServerDataExtendedMessage(ushort serverId, string address, ushort port, bool canCreateNewCharacter, sbyte[] ticket, ushort[] serverIds)
                 : base(serverId, address, port, canCreateNewCharacter, ticket)
        {
            this.serverIds = serverIds;
        }


        public override void Serialize(ICustomDataWriter writer)
        {

            base.Serialize(writer);
            writer.WriteUShort((ushort)serverIds.Length);
            foreach (var entry in serverIds)
            {
                writer.WriteVaruhshort(entry);
            }


        }

        public override void Deserialize(ICustomDataReader reader)
        {

            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            serverIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                serverIds[i] = reader.ReadVaruhshort();
            }
        }
    }
}