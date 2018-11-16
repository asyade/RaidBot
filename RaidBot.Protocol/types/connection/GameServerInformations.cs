


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

    public class GameServerInformations
    {

        public const short Id = 25;
        public virtual short TypeId
        {
            get { return Id; }
        }

        public short id;
        public sbyte type;
        public bool isMonoAccount;
        public sbyte status;
        public sbyte completion;
        public bool isSelectable;
        public sbyte charactersCount;
        public sbyte charactersSlots;
        public double date;


        public GameServerInformations()
        {
        }

        public GameServerInformations(short id, sbyte status, sbyte completion, bool isSelectable, sbyte charactersCount, double date)
        {
            this.id = id;
            this.status = status;
            this.completion = completion;
            this.isSelectable = isSelectable;
            this.charactersCount = charactersCount;
            this.date = date;
        }


        public virtual void Serialize(ICustomDataWriter writer)
        {
            byte flags = 0;
            BooleanByteWrapper.SetFlag(flags, 0, this.isMonoAccount);
            BooleanByteWrapper.SetFlag(flags, 1, this.isSelectable);
            writer.WriteVarshort(id);
            writer.WriteSByte(type);
            writer.WriteSByte(status);
            writer.WriteSByte(completion);
            writer.WriteSByte(charactersCount);
            writer.WriteDouble(date);
        }

        public virtual void Deserialize(ICustomDataReader reader)
        {
            byte flags = reader.ReadByte();
            this.isMonoAccount = BooleanByteWrapper.GetFlag(flags, 0);
            this.isSelectable= BooleanByteWrapper.GetFlag(flags, 1);
            id = reader.ReadVarshort();
            type = reader.ReadSByte();
            status = reader.ReadSByte();
            completion = reader.ReadSByte();
            charactersCount = reader.ReadSByte();
            date = reader.ReadDouble();
        }
    }
}