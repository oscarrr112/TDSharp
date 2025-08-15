// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "UObject/Object.h"
#include "TowerAttributeModifier.generated.h"

UENUM(BlueprintType)
enum class EModifierType : uint8
{
	Add,        // 直接相加
	Multiply,   // 乘法
	Override    // 覆盖（最后应用）
};

USTRUCT(BlueprintType)
struct FActiveAttributeModifierHandle
{
	GENERATED_BODY()

	FActiveAttributeModifierHandle(int32 InHandle)
		: Handle(InHandle) { }

	FActiveAttributeModifierHandle(): Handle(INDEX_NONE) {}

	static FActiveAttributeModifierHandle GenerateNewHandle(class UTowerAttributeComponent* OwningComponent);

	static void ResetGlobalHandleMap();

	UTowerAttributeComponent* GetOwningAbilitySystemComponent();

	bool IsValid() const { return Handle != INDEX_NONE; }
	bool operator==(const FActiveAttributeModifierHandle& Other) const { return Handle == Other.Handle; }
	bool operator!=(const FActiveAttributeModifierHandle& Other) const { return Handle != Other.Handle; }

	friend uint32 GetTypeHash(const FActiveAttributeModifierHandle& InHandle) { return InHandle.Handle; }

	FString ToString() const { return FString::Printf(TEXT("%d"), Handle); }

	void Invalidate() { Handle = INDEX_NONE; }

private:
	UPROPERTY()
	int32 Handle = INDEX_NONE;
};

USTRUCT(BlueprintType)
struct FAttributeModifier
{
	GENERATED_BODY()

public:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	FName AttributeName;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	float Value = 0.0f;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	EModifierType ModifierType = EModifierType::Add;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	int32 Priority = 0;

	FAttributeModifier() = default;
	FAttributeModifier(FName InName, float InValue, EModifierType InType = EModifierType::Add)
		: AttributeName(InName), Value(InValue), ModifierType(InType), Priority(InType == EModifierType::Override ? 0 : 1) {}
};
