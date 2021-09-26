// Copyright Epic Games, Inc. All Rights Reserved.

#include "CombatExampleGameMode.h"
#include "CombatExampleCharacter.h"
#include "UObject/ConstructorHelpers.h"

ACombatExampleGameMode::ACombatExampleGameMode()
{
	// set default pawn class to our Blueprinted character
	//static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
// 	if (PlayerPawnBPClass.Class != NULL)
// 	{
// 		DefaultPawnClass = PlayerPawnBPClass.Class;
// 	}
}
