// Copyright 2016-2019 Periscope Games SAS All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class PostScriptumTarget : TargetRules
{
	public PostScriptumTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "PostScriptum" } );
	}
}
