// Fill out your copyright notice in the Description page of Project Settings.


#include "TowerEffectComponent.h"

UTowerEffectComponent::UTowerEffectComponent()
{
	PrimaryComponentTick.bCanEverTick = false;
	EffectStruct = FEmptyTowerEffectStruct::StaticStruct();
}
