using UnrealBuildTool;

public class MazeEscapeTarget : TargetRules
{
	public MazeEscapeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MazeEscape");
	}
}
