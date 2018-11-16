


















// Generated on 06/26/2015 11:40:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class HelloConnect : NetworkMessage
{

public const uint Id = 3;
public override uint MessageId
{
    get { return Id; }
}

public string salt;
        public sbyte[] key;
        

public HelloConnect()
{
}

public HelloConnect(string salt, sbyte[] key)
        {
            this.salt = salt;
            this.key = key;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(salt);
            writer.WriteVarint((ushort)key.Length);
            foreach (var entry in key)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

salt = reader.ReadUTF();
			var limit = reader.ReadVarint();
            key = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 key[i] = reader.ReadSByte();
            }
            

}


}


}