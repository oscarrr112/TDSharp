using UnrealSharp.Attributes;
using UnrealSharp.Core.Attributes;
using UnrealSharp.Interop;
using UnrealSharp.Core.Marshallers;

namespace UnrealSharp.TDSharp;

[UClass, GeneratedType("TowerPart", "UnrealSharp.TDSharp.TowerPart")]
public partial class ATowerPart : UnrealSharp.Engine.AActor
{
    static readonly IntPtr NativeClassPtr;
    static ATowerPart()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName(typeof(ATowerPart).GetAssemblyName(), "UnrealSharp.TDSharp", "TowerPart");
        IntPtr Parent_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Parent");
        Parent_Offset = FPropertyExporter.CallGetPropertyOffset(Parent_NativeProperty);
        IntPtr Child_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Child");
        Child_Offset = FPropertyExporter.CallGetPropertyOffset(Child_NativeProperty);
        CanInstallPart_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CanInstallPart");
        CanInstallPart_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CanInstallPart_NativeFunction);
        CanInstallPart_Part_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CanInstallPart_NativeFunction, "Part");
        CanInstallPart_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CanInstallPart_NativeFunction, "ReturnValue");
        InstallPart_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "InstallPart");
        InstallPart_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(InstallPart_NativeFunction);
        InstallPart_Part_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(InstallPart_NativeFunction, "Part");
        InstallPart_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(InstallPart_NativeFunction, "ReturnValue");
        RemovePart_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemovePart");
        RemovePart_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemovePart_NativeFunction);
        RemovePart_Part_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemovePart_NativeFunction, "Part");
        RemovePart_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemovePart_NativeFunction, "ReturnValue");
        OnInstalled_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnInstalled");
        AttachPartToTower_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AttachPartToTower");
        AttachPartToTower_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AttachPartToTower_NativeFunction);
        AttachPartToTower_Part_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AttachPartToTower_NativeFunction, "Part");
    }
    
    static int Parent_Offset;
    
    public UnrealSharp.TDSharp.ATowerPart Parent
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.TDSharp.ATowerPart>.FromNative(IntPtr.Add(NativeObject, Parent_Offset), 0);
        }
        set
        {
            ObjectMarshaller<UnrealSharp.TDSharp.ATowerPart>.ToNative(IntPtr.Add(NativeObject, Parent_Offset), 0, value);
        }
    }
    
    
    static int Child_Offset;
    
    public UnrealSharp.TDSharp.ATowerPart Child
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.TDSharp.ATowerPart>.FromNative(IntPtr.Add(NativeObject, Child_Offset), 0);
        }
        set
        {
            ObjectMarshaller<UnrealSharp.TDSharp.ATowerPart>.ToNative(IntPtr.Add(NativeObject, Child_Offset), 0, value);
        }
    }
    
    // CanInstallPart
    static IntPtr CanInstallPart_NativeFunction;
    static int CanInstallPart_ParamsSize;
    static int CanInstallPart_Part_Offset;
    static int CanInstallPart_ReturnValue_Offset;
    
    [UFunction, GeneratedType("CanInstallPart")]
    public bool CanInstallPart(UnrealSharp.TDSharp.ATowerPart part)
    {
        unsafe
        {
            byte* paramsBufferAllocation = stackalloc byte[CanInstallPart_ParamsSize];
            nint paramsBuffer = (nint) paramsBufferAllocation;
            ObjectMarshaller<UnrealSharp.TDSharp.ATowerPart>.ToNative(IntPtr.Add(paramsBuffer, CanInstallPart_Part_Offset), 0, part);
            
            UObjectExporter.CallInvokeNativeFunctionOutParms(NativeObject, CanInstallPart_NativeFunction, paramsBuffer, paramsBuffer + CanInstallPart_ReturnValue_Offset);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(paramsBuffer, CanInstallPart_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // InstallPart
    static IntPtr InstallPart_NativeFunction;
    static int InstallPart_ParamsSize;
    static int InstallPart_Part_Offset;
    static int InstallPart_ReturnValue_Offset;
    
    [UFunction, GeneratedType("InstallPart")]
    public bool InstallPart(UnrealSharp.TDSharp.ATowerPart part)
    {
        unsafe
        {
            byte* paramsBufferAllocation = stackalloc byte[InstallPart_ParamsSize];
            nint paramsBuffer = (nint) paramsBufferAllocation;
            ObjectMarshaller<UnrealSharp.TDSharp.ATowerPart>.ToNative(IntPtr.Add(paramsBuffer, InstallPart_Part_Offset), 0, part);
            
            UObjectExporter.CallInvokeNativeFunctionOutParms(NativeObject, InstallPart_NativeFunction, paramsBuffer, paramsBuffer + InstallPart_ReturnValue_Offset);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(paramsBuffer, InstallPart_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // RemovePart
    static IntPtr RemovePart_NativeFunction;
    static int RemovePart_ParamsSize;
    static int RemovePart_Part_Offset;
    static int RemovePart_ReturnValue_Offset;
    
    [UFunction, GeneratedType("RemovePart")]
    public bool RemovePart(UnrealSharp.TDSharp.ATowerPart part)
    {
        unsafe
        {
            byte* paramsBufferAllocation = stackalloc byte[RemovePart_ParamsSize];
            nint paramsBuffer = (nint) paramsBufferAllocation;
            ObjectMarshaller<UnrealSharp.TDSharp.ATowerPart>.ToNative(IntPtr.Add(paramsBuffer, RemovePart_Part_Offset), 0, part);
            
            UObjectExporter.CallInvokeNativeFunctionOutParms(NativeObject, RemovePart_NativeFunction, paramsBuffer, paramsBuffer + RemovePart_ReturnValue_Offset);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(paramsBuffer, RemovePart_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // OnInstalled
    static IntPtr OnInstalled_NativeFunction;
    
    [UFunction, GeneratedType("OnInstalled")]
    public void OnInstalled()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnInstalled_NativeFunction, IntPtr.Zero, IntPtr.Zero);
        }
    }
    
    // AttachPartToTower
    static IntPtr AttachPartToTower_NativeFunction;
    static int AttachPartToTower_ParamsSize;
    static int AttachPartToTower_Part_Offset;
    
    [UFunction, GeneratedType("AttachPartToTower")]
    public void AttachPartToTower(UnrealSharp.TDSharp.ATowerPart part)
    {
        unsafe
        {
            byte* paramsBufferAllocation = stackalloc byte[AttachPartToTower_ParamsSize];
            nint paramsBuffer = (nint) paramsBufferAllocation;
            ObjectMarshaller<UnrealSharp.TDSharp.ATowerPart>.ToNative(IntPtr.Add(paramsBuffer, AttachPartToTower_Part_Offset), 0, part);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AttachPartToTower_NativeFunction, paramsBuffer, IntPtr.Zero);
            
        }
    }
    
    
}