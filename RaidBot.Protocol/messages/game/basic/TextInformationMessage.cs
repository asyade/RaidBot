


















// Generated on 06/26/2015 11:41:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TextInformationMessage : NetworkMessage
{

public const uint Id = 780;
public override uint MessageId
{
    get { return Id; }
}

public sbyte msgType;
        public ushort msgId;
        public string[] parameters;
        

public TextInformationMessage()
{
}

public TextInformationMessage(sbyte msgType, ushort msgId, string[] parameters)
        {
            this.msgType = msgType;
            this.msgId = msgId;
            this.parameters = parameters;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(msgType);
            writer.WriteVaruhshort(msgId);
            writer.WriteUShort((ushort)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

msgType = reader.ReadSByte();
            if (msgType < 0)
                throw new Exception("Forbidden value on msgType = " + msgType + ", it doesn't respect the following condition : msgType < 0");
            msgId = reader.ReadVaruhshort();
            if (msgId < 0)
                throw new Exception("Forbidden value on msgId = " + msgId + ", it doesn't respect the following condition : msgId < 0");
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            

}


}


}