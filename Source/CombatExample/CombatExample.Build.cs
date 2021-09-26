/*
*  Copyright (c) 2021 Damody(t1238142000@gmail.com).
*  All rights reserved.
*  @ Date : 2021/09/26
*
*/
using UnrealBuildTool;

public class CombatExample : ModuleRules
{
	public CombatExample(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "AdvancedCombat" });
	}
}
