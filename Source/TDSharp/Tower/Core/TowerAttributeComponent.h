// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "TowerAttributeModifier.h"
#include "UObject/Object.h"
#include "TowerAttributeComponent.generated.h"

/**
 * 
 */
UCLASS()
class TDSHARP_API UTowerAttributeComponent : public UObject
{
	GENERATED_BODY()

public:
	// 基础接口
	UFUNCTION(BlueprintCallable, Category = "Attributes")
	void SetBaseAttribute(FName AttributeName, float Value);

	UFUNCTION(BlueprintPure, Category = "Attributes")
	float GetFinalAttribute(FName AttributeName) const;

	UFUNCTION(BlueprintCallable, Category = "Attributes")
	void AddModifier(const FAttributeModifier& Modifier);

	UFUNCTION(BlueprintCallable, Category = "Attributes")
	void ClearModifiers();

	UFUNCTION(BlueprintCallable, Category = "Attributes")
	void RecalculateAttributes();

private:

	UPROPERTY(EditAnywhere, BlueprintReadWrite, meta = (AllowPrivateAccess = "true"))
	TMap<FName, float> BaseAttributes;

	UPROPERTY(BlueprintReadOnly, meta = (AllowPrivateAccess = "true"))
	TMap<FName, float> FinalAttributes;

	UPROPERTY(BlueprintReadOnly, meta = (AllowPrivateAccess = "true"))
	TArray<FAttributeModifier> Modifiers;

	TArray<FActiveAttributeModifierHandle> ActiveModifiersHandles;
};
