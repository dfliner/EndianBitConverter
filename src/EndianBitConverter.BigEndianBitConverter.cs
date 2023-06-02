using System.Text;

namespace System;

public partial class EndianBitConverter
{
    internal class BigEndianBitConverter : EndianBitConverter
    {
        public override byte[] GetBytes(bool value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public override byte[] GetBytes(char value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public override byte[] GetBytes(short value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public override byte[] GetBytes(ushort value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public override byte[] GetBytes(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public override byte[] GetBytes(uint value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public override byte[] GetBytes(long value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public override byte[] GetBytes(ulong value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public override byte[] GetBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public override byte[] GetBytes(double value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public override byte[] GetBytes(decimal value)
        {
            byte[] bytes = base.GetBytes(value);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public override byte[] GetUnicodeBytes(string value)
        {
            return Encoding.BigEndianUnicode.GetBytes(value);
        }

        public override bool ToBoolean(byte[] bytes, int startIndex = 0)
        {
            return BitConverter.ToBoolean(bytes, startIndex);
        }

        public override char ToChar(byte[] bytes, int startIndex = 0)
        {
            if (BitConverter.IsLittleEndian)
            {
                byte[] buf = Reverse(bytes, startIndex, 2);
                return BitConverter.ToChar(buf, 0);
            }

            return BitConverter.ToChar(bytes, startIndex);
        }

        public override decimal ToDecimal(byte[] bytes, int startIndex = 0)
        {
            if (BitConverter.IsLittleEndian)
            {
                byte[] buf = Reverse(bytes, startIndex, 16);
                return base.ToDecimal(buf, 0);
            }

            return base.ToDecimal(bytes, startIndex);
        }

        public override double ToDouble(byte[] bytes, int startIndex = 0)
        {
            if (BitConverter.IsLittleEndian)
            {
                byte[] buf = Reverse(bytes, startIndex, 8);
                return BitConverter.ToDouble(buf, 0);
            }

            return BitConverter.ToDouble(bytes, startIndex);
        }

        public override short ToInt16(byte[] bytes, int startIndex = 0)
        {
            if (BitConverter.IsLittleEndian)
            {
                byte[] buf = Reverse(bytes, startIndex, 2);
                return BitConverter.ToInt16(buf, 0);
            }

            return BitConverter.ToInt16(bytes, startIndex);
        }

        public override int ToInt32(byte[] bytes, int startIndex = 0)
        {
            if (BitConverter.IsLittleEndian)
            {
                byte[] buf = Reverse(bytes, startIndex, 4);
                return BitConverter.ToInt32(buf, 0);
            }

            return BitConverter.ToInt32(bytes, startIndex);
        }

        public override long ToInt64(byte[] bytes, int startIndex = 0)
        {
            if (BitConverter.IsLittleEndian)
            {
                byte[] buf = Reverse(bytes, startIndex, 8);
                return BitConverter.ToInt64(buf, 0);
            }

            return BitConverter.ToInt64(bytes, startIndex);
        }

        public override float ToSingle(byte[] bytes, int startIndex = 0)
        {
            if (BitConverter.IsLittleEndian)
            {
                byte[] buf = Reverse(bytes, startIndex, 4);
                return BitConverter.ToSingle(buf, 0);
            }

            return BitConverter.ToSingle(bytes, startIndex);
        }

        public override string ToString(byte[] bytes, int startIndex, int count)
        {
            return Encoding.BigEndianUnicode.GetString(bytes, startIndex, count);
        }

        public override ushort ToUInt16(byte[] bytes, int startIndex = 0)
        {
            if (BitConverter.IsLittleEndian)
            {
                byte[] buf = Reverse(bytes, startIndex, 2);
                return BitConverter.ToUInt16(buf, 0);
            }

            return BitConverter.ToUInt16(bytes, startIndex);
        }

        public override uint ToUInt32(byte[] bytes, int startIndex = 0)
        {
            if (BitConverter.IsLittleEndian)
            {
                byte[] buf = Reverse(bytes, startIndex, 4);
                return BitConverter.ToUInt32(buf, 0);
            }

            return BitConverter.ToUInt32(bytes, startIndex);
        }

        public override ulong ToUInt64(byte[] bytes, int startIndex = 0)
        {
            if (BitConverter.IsLittleEndian)
            {
                byte[] buf = Reverse(bytes, startIndex, 8);
                return BitConverter.ToUInt64(buf, 0);
            }

            return BitConverter.ToUInt64(bytes, startIndex);
        }
    }
}
