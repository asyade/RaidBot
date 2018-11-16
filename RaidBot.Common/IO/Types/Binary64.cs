using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidBot.Common.IO.Types
{
    public class Binary64
    {

        public static uint CHAR_CODE_0 = (uint)'0';
        public static uint CHAR_CODE_9 = (uint)'9';
        public static uint CHAR_CODE_A = (uint)'a';
        public static uint CHAR_CODE_Z = (uint)'z';
        public uint low;

        private uint internalHigh;
        public Binary64(uint param1, uint param2)
        {
            this.low = param1;
            this.internalHigh = param2;
        }

        public uint div(uint param1)
        {
            uint _loc2_ = 0;
            _loc2_ = this.internalHigh % param1;
            uint _loc3_ = (this.low % param1 + _loc2_ * 6) % param1;
            this.internalHigh = this.internalHigh / param1;
            double _loc4_ = (_loc2_ * 4.294967296E9 + this.low) / param1;
            this.internalHigh = this.internalHigh + (uint)(_loc4_ / 4.294967296E9);
            this.low = (uint)_loc4_;
            return _loc3_;
        }

        public void mul(uint param1)
        {
            long _loc2_ = this.low * param1;
            this.internalHigh = this.internalHigh * param1;
            this.internalHigh = Convert.ToUInt32(this.internalHigh + _loc2_ / 4.294967296E9);
            this.low = this.low * param1;
        }

        public void add(uint count)
        {
            long newLow = low + count;
            internalHigh = Convert.ToUInt32(internalHigh + newLow / 4.294967296E9);
            this.low = Convert.ToUInt32(newLow);
        }

    }
}
