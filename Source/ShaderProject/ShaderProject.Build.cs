// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ShaderProject : ModuleRules
{
	public ShaderProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
        // Might only need to add RenderCore below - RHI and Projects are RenderCore dependencies added for safety ?

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore",
            //SHADER EDIT START
            "RHI",
            "RenderCore"             
            //SHADER EDIT END
        });

		PrivateDependencyModuleNames.AddRange(new string[] {
           //SHADER EDIT START
             "Projects",
            //SHADER EDIT END
        });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
