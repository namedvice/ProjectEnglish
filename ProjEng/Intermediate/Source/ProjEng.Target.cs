using UnrealBuildTool;

public class ProjEngTarget : TargetRules
{
	public ProjEngTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjEng");
	}
}
