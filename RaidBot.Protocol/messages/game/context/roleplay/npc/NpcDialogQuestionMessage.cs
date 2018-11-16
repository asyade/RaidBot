


















// Generated on 06/26/2015 11:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class NpcDialogQuestionMessage : NetworkMessage
{

public const uint Id = 5617;
public override uint MessageId
{
    get { return Id; }
}

public ushort messageId;
        public string[] dialogParams;
        public ushort[] visibleReplies;
        

public NpcDialogQuestionMessage()
{
}

public NpcDialogQuestionMessage(ushort messageId, string[] dialogParams, ushort[] visibleReplies)
        {
            this.messageId = messageId;
            this.dialogParams = dialogParams;
            this.visibleReplies = visibleReplies;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(messageId);
            writer.WriteUShort((ushort)dialogParams.Length);
            foreach (var entry in dialogParams)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteUShort((ushort)visibleReplies.Length);
            foreach (var entry in visibleReplies)
            {
                 writer.WriteVaruhshort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

messageId = reader.ReadVaruhshort();
            if (messageId < 0)
                throw new Exception("Forbidden value on messageId = " + messageId + ", it doesn't respect the following condition : messageId < 0");
            var limit = reader.ReadUShort();
            dialogParams = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 dialogParams[i] = reader.ReadUTF();
            }
            limit = reader.ReadUShort();
            visibleReplies = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 visibleReplies[i] = reader.ReadVaruhshort();
            }
            

}


}


}