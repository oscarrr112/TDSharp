using UnrealSharp.Attributes;
using UnrealSharp.Core.Attributes;
using UnrealSharp.Interop;
using UnrealSharp.Core.Marshallers;

namespace UnrealSharp.TDSharp;

[UClass, GeneratedType("TowerPropertyDataAsset", "UnrealSharp.TDSharp.TowerPropertyDataAsset")]
public partial class UTowerPropertyDataAsset : UnrealSharp.Engine.UDataAsset
{
    static readonly IntPtr NativeClassPtr;
    static UTowerPropertyDataAsset()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName(typeof(UTowerPropertyDataAsset).GetAssemblyName(), "UnrealSharp.TDSharp", "TowerPropertyDataAsset");
        TowerEffects_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "TowerEffects");
        TowerEffects_Offset = FPropertyExporter.CallGetPropertyOffset(TowerEffects_NativeProperty);
    }
    
    static int TowerEffects_Offset;
    static IntPtr TowerEffects_NativeProperty;
    MapMarshaller<TSubclassOf<UnrealSharp.TDSharp.UTowerEffectComponent>, UnrealSharp.CoreUObject.FInstancedStruct> TowerEffects_Marshaller = null;
    
    public System.Collections.Generic.IDictionary<TSubclassOf<UnrealSharp.TDSharp.UTowerEffectComponent>, UnrealSharp.CoreUObject.FInstancedStruct> TowerEffects
    {
        get
        {
            TowerEffects_Marshaller ??= new MapMarshaller<TSubclassOf<UnrealSharp.TDSharp.UTowerEffectComponent>, UnrealSharp.CoreUObject.FInstancedStruct>(TowerEffects_NativeProperty, SubclassOfMarshaller<UnrealSharp.TDSharp.UTowerEffectComponent>.ToNative, SubclassOfMarshaller<UnrealSharp.TDSharp.UTowerEffectComponent>.FromNative, StructMarshaller<UnrealSharp.CoreUObject.FInstancedStruct>.ToNative, StructMarshaller<UnrealSharp.CoreUObject.FInstancedStruct>.FromNative);
            return TowerEffects_Marshaller.FromNative(IntPtr.Add(NativeObject, TowerEffects_Offset), 0);
        }
        set
        {
            TowerEffects_Marshaller ??= new MapMarshaller<TSubclassOf<UnrealSharp.TDSharp.UTowerEffectComponent>, UnrealSharp.CoreUObject.FInstancedStruct>(TowerEffects_NativeProperty, SubclassOfMarshaller<UnrealSharp.TDSharp.UTowerEffectComponent>.ToNative, SubclassOfMarshaller<UnrealSharp.TDSharp.UTowerEffectComponent>.FromNative, StructMarshaller<UnrealSharp.CoreUObject.FInstancedStruct>.ToNative, StructMarshaller<UnrealSharp.CoreUObject.FInstancedStruct>.FromNative);
            TowerEffects_Marshaller.ToNative(IntPtr.Add(NativeObject, TowerEffects_Offset), 0, value);
        }
    }
    
    
}