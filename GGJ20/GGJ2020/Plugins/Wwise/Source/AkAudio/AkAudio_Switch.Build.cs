// Copyright 1998-2011 Epic Games, Inc. All Rights Reserved.
using UnrealBuildTool;
using System;
using System.IO;
using System.Collections.Generic;

public class AkUEPlatform_Switch : AkUEPlatform
{
	public AkUEPlatform_Switch(ReadOnlyTargetRules in_TargetRules, string in_ThirdPartyFolder) : base(in_TargetRules, in_ThirdPartyFolder) {}

#if !UE_4_24_OR_LATER
	public override string SanitizeLibName(string in_libName)
	{
		return in_libName;
	}
#endif

	public override string GetLibraryFullPath(string LibName, string LibPath)
	{
		return Path.Combine(LibPath, "lib" + LibName + ".a");
	}

	public override bool SupportsAkAutobahn { get { return false; } }
	
	public override bool SupportsCommunication { get { return true; } }

	public override List<string> GetPublicLibraryPaths()
	{
		return new List<string>
		{
			Path.Combine(ThirdPartyFolder, "NX64", akConfigurationDir, "lib")
		};
	}
	
	public override List<string> GetAdditionalWwiseLibs()
	{
		return new List<string> 
		{
			"AkOpusNXDecoder"
		};
	}

	public override List<string> GetPublicSystemLibraries()
	{
		return new List<string>();
	}
	
	public override List<string> GetPublicDefinitions()
	{
		return new List<string>
		{
			"NN_NINTENDO_SDK"
		};
	}
	
	public override List<string> GetPublicAdditionalFrameworks()
	{
		return new List<string>();
	}
}
