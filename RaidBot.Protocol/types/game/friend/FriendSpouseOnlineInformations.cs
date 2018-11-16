


















// Generated on 06/26/2015 11:42:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FriendSpouseOnlineInformations : FriendSpouseInformations
{

public const short Id = 93;
public override short TypeId
{
    get { return Id; }
}

public bool inFight;
        public bool followSpouse;
        public int mapId;
        public ushort subAreaId;
        

public FriendSpouseOnlineInformations()
{
}

public FriendSpouseOnlineInformations(int spouseAccountId, uint spouseId, string spouseName, byte spouseLevel, sbyte breed, sbyte sex, Types.EntityLook spouseEntityLook, Types.BasicGuildInformations guildInfo, sbyte alignmentSide, bool inFight, bool followSpouse, int mapId, ushort subAreaId)
         : base(spouseAccountId, spouseId, spouseName, spouseLevel, breed, sex, spouseEntityLook, guildInfo, alignmentSide)
        {
            this.inFight = inFight;
            this.followSpouse = followSpouse;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, inFight);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, followSpouse);
            writer.WriteByte(flag1);
            writer.WriteInt(mapId);
            writer.WriteVaruhshort(subAreaId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            inFight = BooleanByteWrapper.GetFlag(flag1, 0);
            followSpouse = BooleanByteWrapper.GetFlag(flag1, 1);
            mapId = reader.ReadInt();
            if (mapId < 0)
                throw new Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
            subAreaId = reader.ReadVaruhshort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            

}


}


}