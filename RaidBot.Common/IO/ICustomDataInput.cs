using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidBot.Common.IO
{
    public interface ICustomDataReader:IDataReader
    {
        int ReadVarint();
        uint ReadVaruhint();
        short ReadVarshort();
        ushort ReadVaruhshort();
        Types.Int64 ReadVarlong();
        Types.UInt64 ReadVaruhlong();
    }
}