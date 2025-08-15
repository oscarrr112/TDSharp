// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Engine/DataAsset.h"
#include "StructUtils/InstancedStruct.h"
#include "TowerPropertyDataAsset.generated.h"

class UTowerEffectComponent;

UCLASS()
class UTowerEffectDataAsset : public UDataAsset
{
	GENERATED_BODY()

public:
	
};
/**
 * 
 */
UCLASS()
class TDSHARP_API UTowerPropertyDataAsset : public UDataAsset
{
	GENERATED_BODY()

public:
	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Property", meta=(ShowOnlyInnerProperties, AllowPrivateAccess=true))
	TMap<TSubclassOf<UTowerEffectComponent>, FInstancedStruct> TowerEffects;

#if WITH_EDITOR
	virtual void PostEditChangeProperty(struct FPropertyChangedEvent& PropertyChangedEvent) override;
	void ValidateAndUpdateTowerEffects();

	void AddEffectEntry(TSubclassOf<UTowerEffectComponent> TowerEffect);
	void RemoveEffectEntry(TSubclassOf<UTowerEffectComponent> TowerEffect);
	void UpdateEffectEntry(TSubclassOf<UTowerEffectComponent> TowerEffect);

#endif

	UScriptStruct* GetRequiredStructType(TSubclassOf<UTowerEffectComponent> ClassKey) const;

	template<typename T>
	void SetTowerEffect(TSubclassOf<UTowerEffectComponent> ClassKey, const T& Data)
	{
		TowerEffects.FindOrAdd(ClassKey) = FInstancedStruct::Make<T>(Data);
	}

	FInstancedStruct& GetOrCreateTowerEffect(TSubclassOf<UTowerEffectComponent> ClassKey);

	bool HasTowerEffect(TSubclassOf<UTowerEffectComponent> ClassKey) const;
};
