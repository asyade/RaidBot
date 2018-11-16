


















// Generated on 06/26/2015 11:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeStartOkJobIndexMessage : NetworkMessage
{

public const uint Id = 5819;
public override uint MessageId
{
    get { return Id; }
}

public uint[] jobs;
        

public ExchangeStartOkJobIndexMessage()
{
}

public ExchangeStartOkJobIndexMessage(uint[] jobs)
        {
            this.jobs = jobs;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)jobs.Length);
            foreach (var entry in jobs)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            jobs = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 jobs[i] = reader.ReadVaruhint();
            }
            

}


}


}