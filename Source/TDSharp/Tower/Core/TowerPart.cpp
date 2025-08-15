// Fill out your copyright notice in the Description page of Project Settings.


#include "TowerPart.h"


// Sets default values
ATowerPart::ATowerPart() : Parent(nullptr), Child(nullptr)
{
	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = false;
}

void ATowerPart::BeginPlay()
{
	Super::BeginPlay();
	
}

void ATowerPart::Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
}

bool ATowerPart::CanInstallPart(ATowerPart* Part)
{
	return Child == nullptr;
}

bool ATowerPart::InstallPart(ATowerPart* Part)
{
	if (!CanInstallPart(Part)) return false;

	AttachPartToTower(Part);
	Part->OnInstalled();

	return true;
}

// todo 不确定要不要这个功能
bool ATowerPart::RemovePart(ATowerPart* Part)
{
	return false;
}

void ATowerPart::OnInstalled() 
{
}

void ATowerPart::AttachPartToTower(ATowerPart* Part)
{
	if (!Part) return;
    
	// 计算附着位置（在最后一个部件上方）
	FVector AttachLocation = GetActorLocation();
    
	Part->SetActorLocation(AttachLocation);
	Part->AttachToActor(this, FAttachmentTransformRules::KeepWorldTransform);
}
