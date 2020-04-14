// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"

//SHADER EDIT START
#include "ModuleManager.h"

class FThisModuleAddsaVirtualShaderFolderModule
	: public IModuleInterface
{
public:
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};
//SHADER EDIT END
