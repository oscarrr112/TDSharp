using UnrealSharp.Attributes;
using UnrealSharp.Core.Attributes;
using UnrealSharp.Interop;
using UnrealSharp.Core.Marshallers;

namespace UnrealSharp.TDSharp;

[UClass, GeneratedType("TowerAttributeComponent", "UnrealSharp.TDSharp.TowerAttributeComponent")]
public partial class UTowerAttributeComponent : UnrealSharp.CoreUObject.UObject
{
    static readonly IntPtr NativeClassPtr;
    static UTowerAttributeComponent()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName(typeof(UTowerAttributeComponent).GetAssemblyName(), "UnrealSharp.TDSharp", "TowerAttributeComponent");
        BaseAttributes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "BaseAttributes");
        BaseAttributes_Offset = FPropertyExporter.CallGetPropertyOffset(BaseAttributes_NativeProperty);
        FinalAttributes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FinalAttributes");
        FinalAttributes_Offset = FPropertyExporter.CallGetPropertyOffset(FinalAttributes_NativeProperty);
        Modifiers_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Modifiers");
        Modifiers_Offset = FPropertyExporter.CallGetPropertyOffset(Modifiers_NativeProperty);
        SetBaseAttribute_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBaseAttribute");
        SetBaseAttribute_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBaseAttribute_NativeFunction);
        SetBaseAttribute_AttributeName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBaseAttribute_NativeFunction, "AttributeName");
        SetBaseAttribute_Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBaseAttribute_NativeFunction, "Value");
        GetFinalAttribute_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFinalAttribute");
        GetFinalAttribute_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFinalAttribute_NativeFunction);
        GetFinalAttribute_AttributeName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFinalAttribute_NativeFunction, "AttributeName");
        GetFinalAttribute_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFinalAttribute_NativeFunction, "ReturnValue");
        AddModifier_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddModifier");
        AddModifier_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddModifier_NativeFunction);
        AddModifier_Modifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddModifier_NativeFunction, "Modifier");
        ClearModifiers_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearModifiers");
        RecalculateAttributes_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RecalculateAttributes");
    }
    
    static int BaseAttributes_Offset;
    static IntPtr BaseAttributes_NativeProperty;
    MapMarshaller<FName, float> BaseAttributes_Marshaller = null;
    
    public System.Collections.Generic.IDictionary<FName, float> BaseAttributes
    {
        get
        {
            BaseAttributes_Marshaller ??= new MapMarshaller<FName, float>(BaseAttributes_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative, BlittableMarshaller<float>.ToNative, BlittableMarshaller<float>.FromNative);
            return BaseAttributes_Marshaller.FromNative(IntPtr.Add(NativeObject, BaseAttributes_Offset), 0);
        }
        set
        {
            BaseAttributes_Marshaller ??= new MapMarshaller<FName, float>(BaseAttributes_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative, BlittableMarshaller<float>.ToNative, BlittableMarshaller<float>.FromNative);
            BaseAttributes_Marshaller.ToNative(IntPtr.Add(NativeObject, BaseAttributes_Offset), 0, value);
        }
    }
    
    
    static int FinalAttributes_Offset;
    static IntPtr FinalAttributes_NativeProperty;
    MapReadOnlyMarshaller<FName, float> FinalAttributes_Marshaller = null;
    
    public System.Collections.Generic.IReadOnlyDictionary<FName, float> FinalAttributes
    {
        get
        {
            FinalAttributes_Marshaller ??= new MapReadOnlyMarshaller<FName, float>(FinalAttributes_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative, BlittableMarshaller<float>.ToNative, BlittableMarshaller<float>.FromNative);
            return FinalAttributes_Marshaller.FromNative(IntPtr.Add(NativeObject, FinalAttributes_Offset), 0);
        }
    }
    
    
    static int Modifiers_Offset;
    static IntPtr Modifiers_NativeProperty;
    ArrayReadOnlyMarshaller<UnrealSharp.TDSharp.FAttributeModifier> Modifiers_Marshaller = null;
    
    public System.Collections.Generic.IReadOnlyList<UnrealSharp.TDSharp.FAttributeModifier> Modifiers
    {
        get
        {
            Modifiers_Marshaller ??= new ArrayReadOnlyMarshaller<UnrealSharp.TDSharp.FAttributeModifier>(Modifiers_NativeProperty, StructMarshaller<UnrealSharp.TDSharp.FAttributeModifier>.ToNative, StructMarshaller<UnrealSharp.TDSharp.FAttributeModifier>.FromNative);
            return Modifiers_Marshaller.FromNative(IntPtr.Add(NativeObject, Modifiers_Offset), 0);
        }
    }
    
    // SetBaseAttribute
    static IntPtr SetBaseAttribute_NativeFunction;
    static int SetBaseAttribute_ParamsSize;
    static int SetBaseAttribute_AttributeName_Offset;
    static int SetBaseAttribute_Value_Offset;
    
    /// <summary>
    /// 基础接口
    /// </summary>
    [UFunction, GeneratedType("SetBaseAttribute")]
    public void SetBaseAttribute(FName attributeName, float value)
    {
        unsafe
        {
            byte* paramsBufferAllocation = stackalloc byte[SetBaseAttribute_ParamsSize];
            nint paramsBuffer = (nint) paramsBufferAllocation;
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(paramsBuffer, SetBaseAttribute_AttributeName_Offset), 0, attributeName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(paramsBuffer, SetBaseAttribute_Value_Offset), 0, value);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBaseAttribute_NativeFunction, paramsBuffer, IntPtr.Zero);
            
        }
    }
    
    // GetFinalAttribute
    static IntPtr GetFinalAttribute_NativeFunction;
    static int GetFinalAttribute_ParamsSize;
    static int GetFinalAttribute_AttributeName_Offset;
    static int GetFinalAttribute_ReturnValue_Offset;
    
    [UFunction, GeneratedType("GetFinalAttribute")]
    public float GetFinalAttribute(FName attributeName)
    {
        unsafe
        {
            byte* paramsBufferAllocation = stackalloc byte[GetFinalAttribute_ParamsSize];
            nint paramsBuffer = (nint) paramsBufferAllocation;
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(paramsBuffer, GetFinalAttribute_AttributeName_Offset), 0, attributeName);
            
            UObjectExporter.CallInvokeNativeFunctionOutParms(NativeObject, GetFinalAttribute_NativeFunction, paramsBuffer, paramsBuffer + GetFinalAttribute_ReturnValue_Offset);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(paramsBuffer, GetFinalAttribute_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AddModifier
    static IntPtr AddModifier_NativeFunction;
    static int AddModifier_ParamsSize;
    static int AddModifier_Modifier_Offset;
    
    [UFunction, GeneratedType("AddModifier")]
    public void AddModifier(UnrealSharp.TDSharp.FAttributeModifier modifier)
    {
        unsafe
        {
            byte* paramsBufferAllocation = stackalloc byte[AddModifier_ParamsSize];
            nint paramsBuffer = (nint) paramsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AddModifier_NativeFunction, paramsBuffer);
            StructMarshaller<UnrealSharp.TDSharp.FAttributeModifier>.ToNative(IntPtr.Add(paramsBuffer, AddModifier_Modifier_Offset), 0, modifier);
            
            UObjectExporter.CallInvokeNativeFunctionOutParms(NativeObject, AddModifier_NativeFunction, paramsBuffer, IntPtr.Zero);
            
            
        }
    }
    
    // ClearModifiers
    static IntPtr ClearModifiers_NativeFunction;
    
    [UFunction, GeneratedType("ClearModifiers")]
    public void ClearModifiers()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ClearModifiers_NativeFunction, IntPtr.Zero, IntPtr.Zero);
        }
    }
    
    // RecalculateAttributes
    static IntPtr RecalculateAttributes_NativeFunction;
    
    [UFunction, GeneratedType("RecalculateAttributes")]
    public void RecalculateAttributes()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RecalculateAttributes_NativeFunction, IntPtr.Zero, IntPtr.Zero);
        }
    }
    
    
}