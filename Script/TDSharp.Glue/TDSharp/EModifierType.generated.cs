using UnrealSharp.Attributes;
using UnrealSharp.Core.Attributes;
using UnrealSharp.Interop;
using UnrealSharp.Core.Marshallers;

namespace UnrealSharp.TDSharp;

[UEnum, GeneratedType("EModifierType", "UnrealSharp.TDSharp.EModifierType")]
public enum EModifierType : byte
{
    Add = 0,
    /// <summary>
    /// 直接相加
    /// </summary>
    Multiply = 1,
    /// <summary>
    /// 乘法
    /// </summary>
    Override = 2,
}