// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"
#include "TowerEffectComponent.generated.h"

USTRUCT(BlueprintType)
struct FEmptyTowerEffectStruct
{
	GENERATED_BODY()
};

UENUM()
enum ETowerEffectType
{
	OnInstalled,
	OnPowered,
	OnUnstalled
};

class UTowerEffectDataAsset;

UCLASS(ClassGroup=(Custom), meta=(BlueprintSpawnableComponent))
class TDSHARP_API UTowerEffectComponent : public UActorComponent
{
	GENERATED_BODY()

public:
	// Sets default values for this component's properties
	UTowerEffectComponent();

	virtual void ApplyEffect() {}

	TObjectPtr<UScriptStruct> EffectStruct;

	virtual UScriptStruct* GetEffectStruct() { return EffectStruct; }

private:
	
};
