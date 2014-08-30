/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Misakai.Storage.Sbe;

namespace Misakai.Storage.Sbe.Tests.Generated
{
    public enum SecurityTradingEvent : byte
    {
        NoEvent = 0,
        NoCancel = 1,
        ResetStatistics = 4,
        ImpliedMatchingON = 5,
        ImpliedMatchingOFF = 6,
        NULL_VALUE = 255
    }
}
