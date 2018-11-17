using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaidBot.Common.IO.Types;

namespace RaidBot.Common.IO
{
    public class CustomDataWriter : BigEndianWriter, ICustomDataWriter
    {
        public void WriteVarInt(int value)
        {
            var local_5 = 0;
            BigEndianWriter local_2 = new BigEndianWriter();

            if (value >= 0 && value <= CustomDataConst.MASK_10000000)
            {
                local_2.WriteByte((byte)value);
                WriteBytes(local_2.Data);
                return;
            }

            int local_3 = value;
            BigEndianWriter local_4 = new BigEndianWriter();

            while (local_3 != 0)
            {
                local_4.WriteByte((byte)(local_3 & CustomDataConst.MASK_01111111));
                local_4.Position = local_4.Data.Length - 1;

                BigEndianReader local_4_reader = new BigEndianReader(local_4.Data);
                local_5 = local_4_reader.ReadByte();
                local_4 = new BigEndianWriter(local_4_reader.Data);

                local_3 = (int)((uint)local_3 >> CustomDataConst.CHUNCK_BIT_SIZE);
                if (local_3 > 0)
                {
                    local_5 = local_5 | CustomDataConst.MASK_10000000;
                }
                local_2.WriteByte((byte)local_5);
            }

            WriteBytes(local_2.Data);
        }

        public void WriteVarShort(short @int)
        {
            var local_5 = 0;
            if (@int > CustomDataConst.SHORT_MAX_VALUE || @int < CustomDataConst.SHORT_MIN_VALUE)
            {
                throw new System.Exception("Forbidden value");
            }
            else
            {
                BigEndianWriter local_2 = new BigEndianWriter();
                if (@int >= 0 && @int <=CustomDataConst.MASK_01111111 )
                {
                    local_2.WriteByte((byte)@int);
                    WriteBytes(local_2.Data);
                    return;
                }

                var local_3 = @int & 65535;
                BigEndianWriter local_4 = new BigEndianWriter();

                while (local_3 != 0)
                {
                    local_4.WriteByte((byte)(local_3 &CustomDataConst.MASK_01111111));
                    local_4.Position = local_4.Data.Length - 1;

                    BigEndianReader local_4_reader = new BigEndianReader(local_4.Data);
                    local_5 = local_4_reader.ReadByte();
                    local_4 = new BigEndianWriter(local_4_reader.Data);

                    local_3 = (int)((uint)(local_3 >>CustomDataConst.CHUNCK_BIT_SIZE));
                    if (local_3 > 0)
                    {
                        local_5 = local_5 | CustomDataConst.MASK_10000000;
                    }
                    local_2.WriteByte((byte)local_5);
                }
                WriteBytes(local_2.Data);
                return;
            }
        }


        public void WriteVarLong(double param1)
        {
            uint _loc3_ = 0;
            Types.Int64 _loc2_ = Types.Int64.fromNumber(param1);
            if (_loc2_.high == 0)
            {
                this.WriteInt32(_loc2_.low);
            }
            else
            {
                _loc3_ = 0;
                while (_loc3_ < 4)
                {
                    this.WriteByte((byte)(_loc2_.low & 127 | 128));
                    _loc2_.low = _loc2_.low >> 7;
                    _loc3_++;
                }
                if ((_loc2_.high & 268435455 << 3) == 0)
                {
                    this.WriteByte((byte)(_loc2_.high << 4 | _loc2_.low));
                }
                else
                {
                    this.WriteByte((byte)((_loc2_.high << 4 | _loc2_.low) & 127 | 128));
                    this.WriteInt32((uint)(_loc2_.high >> 3));
                }
            }
        }

        private void WriteInt32(uint param1)
        {
            while (param1 >= 128)
            {
                WriteByte((byte)(param1 & 127 | 128));
                param1 = param1 >> 7;
            }
            WriteByte((byte)param1);
        }


        public void WriteVaruhint(uint value)
        {
            WriteVarInt((int)value);
        }

        public void WriteVaruhshort(ushort value)
        {
            WriteVarShort((short)value);
        }

        public void WriteVaruhlong(ulong value)
        {
            WriteVarLong((long)value);
        }
    }
}