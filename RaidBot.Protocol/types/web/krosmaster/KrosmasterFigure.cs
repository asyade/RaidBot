


















// Generated on 06/26/2015 11:42:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class KrosmasterFigure
{

public const short Id = 397;
public virtual short TypeId
{
    get { return Id; }
}

public string uid;
        public ushort figure;
        public ushort pedestal;
        public bool bound;
        

public KrosmasterFigure()
{
}

public KrosmasterFigure(string uid, ushort figure, ushort pedestal, bool bound)
        {
            this.uid = uid;
            this.figure = figure;
            this.pedestal = pedestal;
            this.bound = bound;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(uid);
            writer.WriteVaruhshort(figure);
            writer.WriteVaruhshort(pedestal);
            writer.WriteBoolean(bound);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

uid = reader.ReadUTF();
            figure = reader.ReadVaruhshort();
            if (figure < 0)
                throw new Exception("Forbidden value on figure = " + figure + ", it doesn't respect the following condition : figure < 0");
            pedestal = reader.ReadVaruhshort();
            if (pedestal < 0)
                throw new Exception("Forbidden value on pedestal = " + pedestal + ", it doesn't respect the following condition : pedestal < 0");
            bound = reader.ReadBoolean();
            

}


}


}