// Fill out your copyright notice in the Description page of Project Settings.


#include "TowerAttributeComponent.h"

void UTowerAttributeComponent::SetBaseAttribute(FName AttributeName, float Value)
{
	BaseAttributes[AttributeName] = Value;
}

float UTowerAttributeComponent::GetFinalAttribute(FName AttributeName) const
{
	return FinalAttributes[AttributeName];
}

void UTowerAttributeComponent::AddModifier(const FAttributeModifier& Modifier)
{
	Modifiers.Add(Modifier);
}

void UTowerAttributeComponent::ClearModifiers()
{
	Modifiers.Empty();
}

void UTowerAttributeComponent::RecalculateAttributes()
{
	TArray<FAttributeModifier> TmpModifiers = Modifiers;
	TmpModifiers.StableSort([](const FAttributeModifier& A, const FAttributeModifier& B) { return A.Priority < B.Priority; });

	for (auto& Pair: BaseAttributes)
	{
		for (const FAttributeModifier& Modifier: Modifiers)
		{
			if (Modifier.AttributeName != Pair.Key) { continue; }

			switch (Modifier.ModifierType)
			{
			case EModifierType::Add:
				{
					Pair.Value += Modifier.Value;
					break;
				}
			case EModifierType::Multiply:
				{
					Pair.Value *= Modifier.Value;
					break;
				}
			case EModifierType::Override:
				{
					Pair.Value = Modifier.Value;
					break;
				}
			}
		}
	}
}
