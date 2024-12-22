using UnrealBuildTool;

public class MazeEscapeClientTarget : TargetRules
{
	public MazeEscapeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MazeEscape");
	}
}
