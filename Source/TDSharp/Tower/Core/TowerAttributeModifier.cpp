// Fill out your copyright notice in the Description page of Project Settings.


#include "TowerAttributeModifier.h"

#include "TowerAttributeComponent.h"

namespace GlobalActiveAttributeModifierHandles
{
	static TMap<FActiveAttributeModifierHandle, TWeakObjectPtr<UTowerAttributeComponent>> Map;
}

FActiveAttributeModifierHandle FActiveAttributeModifierHandle::GenerateNewHandle(UTowerAttributeComponent* OwningComponent)
{
	static int32 GHandleID = 0;
	FActiveAttributeModifierHandle NewHandle(GHandleID++);

	TWeakObjectPtr<UTowerAttributeComponent> WeakPtr(OwningComponent);
	GlobalActiveAttributeModifierHandles::Map.Add(NewHandle, WeakPtr);
	
	return NewHandle;
}

void FActiveAttributeModifierHandle::ResetGlobalHandleMap()
{
	GlobalActiveAttributeModifierHandles::Map.Reset();
}

UTowerAttributeComponent* FActiveAttributeModifierHandle::GetOwningAbilitySystemComponent()
{
	TWeakObjectPtr<UTowerAttributeComponent>* Ptr = GlobalActiveAttributeModifierHandles::Map.Find(*this);
	if (Ptr)
	{
		return Ptr->Get();
	}

	return nullptr;
}
