


















// Generated on 06/26/2015 11:41:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TitlesAndOrnamentsListMessage : NetworkMessage
{

public const uint Id = 6367;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] titles;
        public ushort[] ornaments;
        public ushort activeTitle;
        public ushort activeOrnament;
        

public TitlesAndOrnamentsListMessage()
{
}

public TitlesAndOrnamentsListMessage(ushort[] titles, ushort[] ornaments, ushort activeTitle, ushort activeOrnament)
        {
            this.titles = titles;
            this.ornaments = ornaments;
            this.activeTitle = activeTitle;
            this.activeOrnament = activeOrnament;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)titles.Length);
            foreach (var entry in titles)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)ornaments.Length);
            foreach (var entry in ornaments)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteVaruhshort(activeTitle);
            writer.WriteVaruhshort(activeOrnament);
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            titles = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 titles[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            ornaments = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 ornaments[i] = reader.ReadVaruhshort();
            }
            activeTitle = reader.ReadVaruhshort();
            if (activeTitle < 0)
                throw new Exception("Forbidden value on activeTitle = " + activeTitle + ", it doesn't respect the following condition : activeTitle < 0");
            activeOrnament = reader.ReadVaruhshort();
            if (activeOrnament < 0)
                throw new Exception("Forbidden value on activeOrnament = " + activeOrnament + ", it doesn't respect the following condition : activeOrnament < 0");
            

}


}


}