using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidBot.Common.IO
{
    public interface ICustomDataWriter:IDataWriter
    {
        void WriteVarint(int value);
        void WriteVarshort(short value);
        void WriteVarlong(double value);
        void WriteVaruhint(uint value);
        void WriteVaruhshort(ushort value);
        void WriteVaruhlong(ulong value);
    }
}
