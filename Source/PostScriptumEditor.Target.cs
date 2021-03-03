// Copyright 2016-2019 Periscope Games SAS All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class PostScriptumEditorTarget : TargetRules
{
	public PostScriptumEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "PostScriptum" } );
	}
}
