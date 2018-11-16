


















// Generated on 06/26/2015 11:42:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GuildEmblem
{

public const short Id = 87;
public virtual short TypeId
{
    get { return Id; }
}

public ushort symbolShape;
        public int symbolColor;
        public sbyte backgroundShape;
        public int backgroundColor;
        

public GuildEmblem()
{
}

public GuildEmblem(ushort symbolShape, int symbolColor, sbyte backgroundShape, int backgroundColor)
        {
            this.symbolShape = symbolShape;
            this.symbolColor = symbolColor;
            this.backgroundShape = backgroundShape;
            this.backgroundColor = backgroundColor;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(symbolShape);
            writer.WriteInt(symbolColor);
            writer.WriteSByte(backgroundShape);
            writer.WriteInt(backgroundColor);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

symbolShape = reader.ReadVaruhshort();
            if (symbolShape < 0)
                throw new Exception("Forbidden value on symbolShape = " + symbolShape + ", it doesn't respect the following condition : symbolShape < 0");
            symbolColor = reader.ReadInt();
            backgroundShape = reader.ReadSByte();
            if (backgroundShape < 0)
                throw new Exception("Forbidden value on backgroundShape = " + backgroundShape + ", it doesn't respect the following condition : backgroundShape < 0");
            backgroundColor = reader.ReadInt();
            

}


}


}