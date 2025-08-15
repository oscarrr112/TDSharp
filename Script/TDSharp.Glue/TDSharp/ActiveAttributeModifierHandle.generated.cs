using UnrealSharp.Attributes;
using UnrealSharp.Core.Attributes;
using UnrealSharp.Interop;
using UnrealSharp.Core.Marshallers;

namespace UnrealSharp.TDSharp;

[UStruct, GeneratedType("ActiveAttributeModifierHandle", "UnrealSharp.TDSharp.ActiveAttributeModifierHandle")]
public partial struct FActiveAttributeModifierHandle : MarshalledStruct<FActiveAttributeModifierHandle>
{
    // Handle
    
    static int Handle_Offset;
    private int Handle;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FActiveAttributeModifierHandle()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName(typeof(FActiveAttributeModifierHandle).GetAssemblyName(), "UnrealSharp.TDSharp", "ActiveAttributeModifierHandle");
        IntPtr Handle_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Handle");
        Handle_Offset = FPropertyExporter.CallGetPropertyOffset(Handle_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FActiveAttributeModifierHandle(IntPtr InNativeStruct)
    {
        unsafe
        {
            Handle = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Handle_Offset), 0);
        }
    }
    
    public static FActiveAttributeModifierHandle FromNative(IntPtr buffer) => new FActiveAttributeModifierHandle(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, Handle_Offset), 0, Handle);
        }
    }
}

public static class FActiveAttributeModifierHandleMarshaller
{
    public static FActiveAttributeModifierHandle FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FActiveAttributeModifierHandle(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FActiveAttributeModifierHandle obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FActiveAttributeModifierHandle.NativeDataSize;
    }
}