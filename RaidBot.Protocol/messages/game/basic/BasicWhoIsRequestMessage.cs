


















// Generated on 06/26/2015 11:41:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class BasicWhoIsRequestMessage : NetworkMessage
{

public const uint Id = 181;
public override uint MessageId
{
    get { return Id; }
}

public bool verbose;
        public string search;
        

public BasicWhoIsRequestMessage()
{
}

public BasicWhoIsRequestMessage(bool verbose, string search)
        {
            this.verbose = verbose;
            this.search = search;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(verbose);
            writer.WriteUTF(search);
            

}

public override void Deserialize(ICustomDataReader reader)
{

verbose = reader.ReadBoolean();
            search = reader.ReadUTF();
            

}


}


}