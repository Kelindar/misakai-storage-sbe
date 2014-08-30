/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Misakai.Storage.Sbe;

namespace Misakai.Storage.Sbe.PerfTests.Bench.SBE.FIX
{
    [Flags]
    public enum TradeCondition : byte
    {
        OpeningTrade = 1,
        CmeGlobexPrice = 2,
    }
}
