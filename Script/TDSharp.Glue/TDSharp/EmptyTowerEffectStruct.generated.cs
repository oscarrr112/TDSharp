using UnrealSharp.Attributes;
using UnrealSharp.Core.Attributes;
using UnrealSharp.Interop;
using UnrealSharp.Core.Marshallers;

namespace UnrealSharp.TDSharp;

[UStruct, GeneratedType("EmptyTowerEffectStruct", "UnrealSharp.TDSharp.EmptyTowerEffectStruct")]
public partial struct FEmptyTowerEffectStruct : MarshalledStruct<FEmptyTowerEffectStruct>
{
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FEmptyTowerEffectStruct()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName(typeof(FEmptyTowerEffectStruct).GetAssemblyName(), "UnrealSharp.TDSharp", "EmptyTowerEffectStruct");
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FEmptyTowerEffectStruct(IntPtr InNativeStruct)
    {
        unsafe
        {
        }
    }
    
    public static FEmptyTowerEffectStruct FromNative(IntPtr buffer) => new FEmptyTowerEffectStruct(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
        }
    }
}

public static class FEmptyTowerEffectStructMarshaller
{
    public static FEmptyTowerEffectStruct FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FEmptyTowerEffectStruct(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FEmptyTowerEffectStruct obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FEmptyTowerEffectStruct.NativeDataSize;
    }
}