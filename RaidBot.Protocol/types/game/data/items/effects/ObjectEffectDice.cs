


















// Generated on 06/26/2015 11:42:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectEffectDice : ObjectEffect
{

public const short Id = 73;
public override short TypeId
{
    get { return Id; }
}

public ushort diceNum;
        public ushort diceSide;
        public ushort diceConst;
        

public ObjectEffectDice()
{
}

public ObjectEffectDice(ushort actionId, ushort diceNum, ushort diceSide, ushort diceConst)
         : base(actionId)
        {
            this.diceNum = diceNum;
            this.diceSide = diceSide;
            this.diceConst = diceConst;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(diceNum);
            writer.WriteVaruhshort(diceSide);
            writer.WriteVaruhshort(diceConst);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            diceNum = reader.ReadVaruhshort();
            if (diceNum < 0)
                throw new Exception("Forbidden value on diceNum = " + diceNum + ", it doesn't respect the following condition : diceNum < 0");
            diceSide = reader.ReadVaruhshort();
            if (diceSide < 0)
                throw new Exception("Forbidden value on diceSide = " + diceSide + ", it doesn't respect the following condition : diceSide < 0");
            diceConst = reader.ReadVaruhshort();
            if (diceConst < 0)
                throw new Exception("Forbidden value on diceConst = " + diceConst + ", it doesn't respect the following condition : diceConst < 0");
            

}


}


}