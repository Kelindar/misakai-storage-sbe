/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Misakai.Storage.Sbe;

namespace Misakai.Storage.Sbe.Tests.Generated
{
    public enum HaltReason : byte
    {
        GroupSchedule = 0,
        SurveillanceIntervention = 1,
        MarketEvent = 2,
        InstrumentActivation = 3,
        InstrumentExpiration = 4,
        Unknown = 5,
        NULL_VALUE = 255
    }
}
