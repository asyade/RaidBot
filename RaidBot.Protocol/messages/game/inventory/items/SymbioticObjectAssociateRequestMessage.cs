


















// Generated on 06/26/2015 11:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SymbioticObjectAssociateRequestMessage : NetworkMessage
{

public const uint Id = 6522;
public override uint MessageId
{
    get { return Id; }
}

public uint symbioteUID;
        public byte symbiotePos;
        public uint hostUID;
        public byte hostPos;
        

public SymbioticObjectAssociateRequestMessage()
{
}

public SymbioticObjectAssociateRequestMessage(uint symbioteUID, byte symbiotePos, uint hostUID, byte hostPos)
        {
            this.symbioteUID = symbioteUID;
            this.symbiotePos = symbiotePos;
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(symbioteUID);
            writer.WriteByte(symbiotePos);
            writer.WriteVaruhint(hostUID);
            writer.WriteByte(hostPos);
            

}

public override void Deserialize(ICustomDataReader reader)
{

symbioteUID = reader.ReadVaruhint();
            if (symbioteUID < 0)
                throw new Exception("Forbidden value on symbioteUID = " + symbioteUID + ", it doesn't respect the following condition : symbioteUID < 0");
            symbiotePos = reader.ReadByte();
            if (symbiotePos < 0 || symbiotePos > 255)
                throw new Exception("Forbidden value on symbiotePos = " + symbiotePos + ", it doesn't respect the following condition : symbiotePos < 0 || symbiotePos > 255");
            hostUID = reader.ReadVaruhint();
            if (hostUID < 0)
                throw new Exception("Forbidden value on hostUID = " + hostUID + ", it doesn't respect the following condition : hostUID < 0");
            hostPos = reader.ReadByte();
            if (hostPos < 0 || hostPos > 255)
                throw new Exception("Forbidden value on hostPos = " + hostPos + ", it doesn't respect the following condition : hostPos < 0 || hostPos > 255");
            

}


}


}