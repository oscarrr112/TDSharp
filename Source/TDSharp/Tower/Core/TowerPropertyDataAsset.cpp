// Fill out your copyright notice in the Description page of Project Settings.


#include "TowerPropertyDataAsset.h"

#include "TowerEffectComponent.h"

#if WITH_EDITOR
void UTowerPropertyDataAsset::PostEditChangeProperty(struct FPropertyChangedEvent& PropertyChangedEvent)
{
	Super::PostEditChangeProperty(PropertyChangedEvent);

	if (!PropertyChangedEvent.Property) { return; }

	const FName PropertyName = PropertyChangedEvent.Property->GetFName();
	const static FName TowerEffectsName = GET_MEMBER_NAME_CHECKED(UTowerPropertyDataAsset, TowerEffects);

	if (PropertyName == TowerEffectsName)
	{
		ValidateAndUpdateTowerEffects();
	}
}

void UTowerPropertyDataAsset::ValidateAndUpdateTowerEffects()
{
	TArray<TSubclassOf<UTowerEffectComponent>> KeysToUpdate;
    
	// 检查现有的配置项
	for (auto& Pair : TowerEffects)
	{
		TSubclassOf<UTowerEffectComponent> ObjectClass = Pair.Key;
		FInstancedStruct& ConfigData = Pair.Value;
        
		if (!ObjectClass)
		{
			continue;
		}
        
		// 获取该类应该使用的结构体类型
		UScriptStruct* RequiredStructType = GetRequiredStructType(ObjectClass);
        
		if (!RequiredStructType)
		{
			continue;
		}
        
		// 如果当前的结构体类型不匹配，需要更新
		if (!ConfigData.IsValid() || ConfigData.GetScriptStruct() != RequiredStructType)
		{
			KeysToUpdate.Add(ObjectClass);
		}
	}
    
	// 更新需要修正的配置项
	for (TSubclassOf<UTowerEffectComponent> ObjectClass : KeysToUpdate)
	{
		UpdateEffectEntry(ObjectClass);
	}
}


void UTowerPropertyDataAsset::AddEffectEntry(TSubclassOf<UTowerEffectComponent> TowerEffect)
{
	if (!TowerEffect)
	{
		return;
	}
    
	// 如果已经存在，先移除
	if (TowerEffects.Contains(TowerEffect))
	{
		TowerEffects.Remove(TowerEffect);
	}
    
	// 创建新的配置项
	UpdateEffectEntry(TowerEffect);
}

void UTowerPropertyDataAsset::RemoveEffectEntry(TSubclassOf<UTowerEffectComponent> TowerEffect)
{
	TowerEffects.Remove(TowerEffect);
}

void UTowerPropertyDataAsset::UpdateEffectEntry(TSubclassOf<UTowerEffectComponent> TowerEffect)
{
	UScriptStruct* RequiredStructType = GetRequiredStructType(TowerEffect);
    
	if (!RequiredStructType)
	{
		return;
	}
    
	// 尝试保留现有数据
	FInstancedStruct* ExistingData = TowerEffects.Find(TowerEffect);
	FInstancedStruct NewData(RequiredStructType);
    
	// 如果有现有数据且类型匹配，保留它
	if (ExistingData && ExistingData->IsValid() && 
		ExistingData->GetScriptStruct() == RequiredStructType)
	{
		return; // 类型已经正确，无需更新
	}
    
	// // 尝试从CDO获取默认数据
	// if (UObject* CDO = TowerEffect->GetDefaultObject())
	// {
	// 	if (UTowerEffectComponent* EffectComponent = TowerEffects.GetDefaultObject())
	// 	{
	// 		EffectComponent->GetEffectStruct();
	// 	}
	// }
    
	// 更新映射
	TowerEffects.FindOrAdd(TowerEffect) = NewData;
}
#endif


FInstancedStruct& UTowerPropertyDataAsset::GetOrCreateTowerEffect(TSubclassOf<UTowerEffectComponent> ClassKey)
{
	if (!TowerEffects.Contains(ClassKey))
	{
#if WITH_EDITOR
		AddEffectEntry(ClassKey);
#endif

		UScriptStruct* RequiredStructType = GetRequiredStructType(ClassKey);
		if (RequiredStructType)
		{
			TowerEffects.Add(ClassKey, FInstancedStruct(RequiredStructType));
		}
		else
		{
			static FInstancedStruct EmptyStruct;
			TowerEffects.Add(ClassKey, EmptyStruct);
		}
	}

	return TowerEffects[ClassKey];
}

bool UTowerPropertyDataAsset::HasTowerEffect(TSubclassOf<UTowerEffectComponent> ClassKey) const
{
	return TowerEffects.Contains(ClassKey) && TowerEffects[ClassKey].IsValid();
}

UScriptStruct* UTowerPropertyDataAsset::GetRequiredStructType(TSubclassOf<UTowerEffectComponent> ClassKey) const
{
	if (!ClassKey)
	{
		return nullptr;
	}

	if (UTowerEffectComponent* EffectComponent = ClassKey.GetDefaultObject())
	{
		return EffectComponent->GetEffectStruct();
	}

	return nullptr;
}
