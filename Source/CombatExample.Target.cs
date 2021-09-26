/*
*  Copyright (c) 2021 Damody(t1238142000@gmail.com).
*  All rights reserved.
*  @ Date : 2021/09/26
*
*/
using UnrealBuildTool;
using System.Collections.Generic;

public class CombatExampleTarget : TargetRules
{
	public CombatExampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("CombatExample");
	}
}
