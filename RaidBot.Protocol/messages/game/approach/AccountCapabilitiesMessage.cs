


















// Generated on 06/26/2015 11:41:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AccountCapabilitiesMessage : NetworkMessage
{

public const uint Id = 6216;
public override uint MessageId
{
    get { return Id; }
}

public bool tutorialAvailable;
        public bool canCreateNewCharacter;
        public int accountId;
        public ushort breedsVisible;
        public ushort breedsAvailable;
        public sbyte status;
        

public AccountCapabilitiesMessage()
{
}

public AccountCapabilitiesMessage(bool tutorialAvailable, bool canCreateNewCharacter, int accountId, ushort breedsVisible, ushort breedsAvailable, sbyte status)
        {
            this.tutorialAvailable = tutorialAvailable;
            this.canCreateNewCharacter = canCreateNewCharacter;
            this.accountId = accountId;
            this.breedsVisible = breedsVisible;
            this.breedsAvailable = breedsAvailable;
            this.status = status;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, tutorialAvailable);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, canCreateNewCharacter);
            writer.WriteByte(flag1);
            writer.WriteInt(accountId);
            writer.WriteUShort(breedsVisible);
            writer.WriteUShort(breedsAvailable);
            writer.WriteSByte(status);
            

}

public override void Deserialize(ICustomDataReader reader)
{

byte flag1 = reader.ReadByte();
            tutorialAvailable = BooleanByteWrapper.GetFlag(flag1, 0);
            canCreateNewCharacter = BooleanByteWrapper.GetFlag(flag1, 1);
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            breedsVisible = reader.ReadUShort();
            if (breedsVisible < 0 || breedsVisible > 65535)
                throw new Exception("Forbidden value on breedsVisible = " + breedsVisible + ", it doesn't respect the following condition : breedsVisible < 0 || breedsVisible > 65535");
            breedsAvailable = reader.ReadUShort();
            if (breedsAvailable < 0 || breedsAvailable > 65535)
                throw new Exception("Forbidden value on breedsAvailable = " + breedsAvailable + ", it doesn't respect the following condition : breedsAvailable < 0 || breedsAvailable > 65535");
            status = reader.ReadSByte();
            

}


}


}