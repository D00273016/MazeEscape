using UnrealBuildTool;

public class MazeEscapeEditorTarget : TargetRules
{
	public MazeEscapeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MazeEscape");
	}
}
