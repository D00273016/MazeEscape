using UnrealBuildTool;

public class MazeEscapeServerTarget : TargetRules
{
	public MazeEscapeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MazeEscape");
	}
}
