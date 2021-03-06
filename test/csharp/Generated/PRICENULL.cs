/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Misakai.Storage.Sbe;

namespace Misakai.Storage.Sbe.Tests.Generated
{
    public class PRICENULL
    {
        private DirectBuffer _buffer;
        private int _offset;
        private int _actingVersion;

        public void Wrap(DirectBuffer buffer, int offset, int actingVersion)
        {
            _offset = offset;
            _actingVersion = actingVersion;
            _buffer = buffer;
        }

        public const int Size = 8;

    public const long MantissaNullValue = 9223372036854775807L;

    public const long MantissaMinValue = -9223372036854775807L;

    public const long MantissaMaxValue = 9223372036854775807L;

    public long Mantissa
    {
        get
        {
            return _buffer.Int64GetLittleEndian(_offset + 0);
        }
        set
        {
            _buffer.Int64PutLittleEndian(_offset + 0, value);
        }
    }


    public const sbyte ExponentNullValue = (sbyte)-128;

    public const sbyte ExponentMinValue = (sbyte)-127;

    public const sbyte ExponentMaxValue = (sbyte)127;

    public sbyte Exponent { get { return (sbyte)-7; } }
    }
}
