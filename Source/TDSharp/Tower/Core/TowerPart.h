// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "TowerAttributeModifier.h"
#include "GameFramework/Actor.h"
#include "TowerPart.generated.h"

UCLASS(Blueprintable, BlueprintType)
class TDSHARP_API ATowerPart : public AActor
{
	GENERATED_BODY()


public:
	// Sets default values for this actor's properties
	ATowerPart();

	UPROPERTY(BlueprintReadWrite, Category="Tower")
	ATowerPart* Parent;

	UPROPERTY(BlueprintReadWrite, Category="Tower")
	ATowerPart* Child;

	virtual void Tick(float DeltaSeconds) override;
protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:
	UFUNCTION(BlueprintCallable, Category = "Tower Management")
	bool CanInstallPart(ATowerPart* Part);

	UFUNCTION(BlueprintCallable, Category = "Tower Management")
	bool InstallPart(ATowerPart* Part);

	UFUNCTION(BlueprintCallable, Category = "Tower Management")
	bool RemovePart(ATowerPart* Part);

	UFUNCTION(BlueprintCallable, Category = "Tower Management")
	void OnInstalled();

	UFUNCTION(BlueprintCallable, Category = "Tower Management")
	void AttachPartToTower(ATowerPart* Part);

};
