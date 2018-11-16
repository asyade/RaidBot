


















// Generated on 06/26/2015 11:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class WrapperObjectDissociateRequestMessage : NetworkMessage
{

public const uint Id = 6524;
public override uint MessageId
{
    get { return Id; }
}

public uint hostUID;
        public byte hostPos;
        

public WrapperObjectDissociateRequestMessage()
{
}

public WrapperObjectDissociateRequestMessage(uint hostUID, byte hostPos)
        {
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(hostUID);
            writer.WriteByte(hostPos);
            

}

public override void Deserialize(ICustomDataReader reader)
{

hostUID = reader.ReadVaruhint();
            if (hostUID < 0)
                throw new Exception("Forbidden value on hostUID = " + hostUID + ", it doesn't respect the following condition : hostUID < 0");
            hostPos = reader.ReadByte();
            if (hostPos < 0 || hostPos > 255)
                throw new Exception("Forbidden value on hostPos = " + hostPos + ", it doesn't respect the following condition : hostPos < 0 || hostPos > 255");
            

}


}


}