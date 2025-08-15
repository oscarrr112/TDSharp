using UnrealSharp.Attributes;
using UnrealSharp.Core.Attributes;
using UnrealSharp.Interop;
using UnrealSharp.Core.Marshallers;

namespace UnrealSharp.TDSharp;

[UStruct, GeneratedType("AttributeModifier", "UnrealSharp.TDSharp.AttributeModifier")]
public partial struct FAttributeModifier : MarshalledStruct<FAttributeModifier>
{
    // AttributeName
    
    static int AttributeName_Offset;
    public FName AttributeName;
    
    // Value
    
    static int Value_Offset;
    public float Value;
    
    // ModifierType
    
    static int ModifierType_Offset;
    public UnrealSharp.TDSharp.EModifierType ModifierType;
    
    // Priority
    
    static int Priority_Offset;
    public int Priority;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FAttributeModifier()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName(typeof(FAttributeModifier).GetAssemblyName(), "UnrealSharp.TDSharp", "AttributeModifier");
        IntPtr AttributeName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AttributeName");
        AttributeName_Offset = FPropertyExporter.CallGetPropertyOffset(AttributeName_NativeProperty);
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        IntPtr ModifierType_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ModifierType");
        ModifierType_Offset = FPropertyExporter.CallGetPropertyOffset(ModifierType_NativeProperty);
        IntPtr Priority_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Priority");
        Priority_Offset = FPropertyExporter.CallGetPropertyOffset(Priority_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FAttributeModifier(IntPtr InNativeStruct)
    {
        unsafe
        {
            AttributeName = BlittableMarshaller<FName>.FromNative(IntPtr.Add(InNativeStruct, AttributeName_Offset), 0);
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
            ModifierType = EnumMarshaller<UnrealSharp.TDSharp.EModifierType>.FromNative(IntPtr.Add(InNativeStruct, ModifierType_Offset), 0);
            Priority = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Priority_Offset), 0);
        }
    }
    
    public static FAttributeModifier FromNative(IntPtr buffer) => new FAttributeModifier(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(buffer, AttributeName_Offset), 0, AttributeName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
            EnumMarshaller<UnrealSharp.TDSharp.EModifierType>.ToNative(IntPtr.Add(buffer, ModifierType_Offset), 0, ModifierType);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, Priority_Offset), 0, Priority);
        }
    }
}

public static class FAttributeModifierMarshaller
{
    public static FAttributeModifier FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FAttributeModifier(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FAttributeModifier obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FAttributeModifier.NativeDataSize;
    }
}