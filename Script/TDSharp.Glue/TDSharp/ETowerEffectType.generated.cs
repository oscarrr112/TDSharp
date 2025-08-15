using UnrealSharp.Attributes;
using UnrealSharp.Core.Attributes;
using UnrealSharp.Interop;
using UnrealSharp.Core.Marshallers;

namespace UnrealSharp.TDSharp;

[UEnum, GeneratedType("ETowerEffectType", "UnrealSharp.TDSharp.ETowerEffectType")]
public enum ETowerEffectType
{
    OnInstalled = 0,
    OnPowered = 1,
    OnUnstalled = 2,
}