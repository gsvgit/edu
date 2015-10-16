﻿$solution_name = Read-Host "What is your solution name?"
$project_name = Read-Host "Would you like named your project?" 
New-Item -Type Directory -Path src/$project_name | Out-Null
"<?xml version=`"1.0`" encoding=`"utf-8`"?>
<Project ToolsVersion=`"14.0`" DefaultTargets=`"Build`" xmlns=`"http://schemas.microsoft.com/developer/msbuild/2003`">
  <Import Project=`"`$(MSBuildExtensionsPath)\`$(MSBuildToolsVersion)\Microsoft.Common.props`" Condition=`"Exists('`$(MSBuildExtensionsPath)\`$(MSBuildToolsVersion)\Microsoft.Common.props')`" />
  <PropertyGroup>
    <Configuration Condition=`" '`$(Configuration)' == '' `">Debug</Configuration>
    <Platform Condition=`" '`$(Platform)' == '' `">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>bf72cd30-570c-4224-9c5c-6f6a0f5e77af</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>$project_name</RootNamespace>
    <AssemblyName>$project_name</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <TargetFSharpCoreVersion>4.3.0.0</TargetFSharpCoreVersion>
    <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>
    <Name>Task2</Name>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition=`" '`$(Configuration)|`$(Platform)' == 'Debug|AnyCPU' `">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <Tailcalls>false</Tailcalls>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <WarningLevel>3</WarningLevel>
    <DocumentationFile>bin\Debug\$project_name.XML</DocumentationFile>
  </PropertyGroup>
  <PropertyGroup Condition=`" '`$(Configuration)|`$(Platform)' == 'Release|AnyCPU' `">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <Tailcalls>true</Tailcalls>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <WarningLevel>3</WarningLevel>
    <DocumentationFile>bin\Release\$project_name.XML</DocumentationFile>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include=`"mscorlib`" />
    <Reference Include=`"FSharp.Core, Version=`$(TargetFSharpCoreVersion), Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`">
      <Private>True</Private>
    </Reference>
    <Reference Include=`"System`" />
    <Reference Include=`"System.Core`" />
    <Reference Include=`"System.Numerics`" />
  </ItemGroup>
  <ItemGroup>                             
    <Compile Include=`"AssemblyInfo.fs`" />
    <Compile Include=`"$project_name.fs`" />
    <None Include=`"paket.references`" />
  </ItemGroup>
  <PropertyGroup>
    <MinimumVisualStudioVersion Condition=`"'`$(MinimumVisualStudioVersion)' == ''`">11</MinimumVisualStudioVersion>
  </PropertyGroup>
  <Choose>
    <When Condition=`"'`$(VisualStudioVersion)' == '11.0'`">
      <PropertyGroup Condition=`"Exists('`$(MSBuildExtensionsPath32)\..\Microsoft SDKs\F#\3.0\Framework\v4.0\Microsoft.FSharp.Targets')`">
        <FSharpTargetsPath>`$(MSBuildExtensionsPath32)\..\Microsoft SDKs\F#\3.0\Framework\v4.0\Microsoft.FSharp.Targets</FSharpTargetsPath>
      </PropertyGroup>
    </When>
    <Otherwise>
      <PropertyGroup Condition=`"Exists('`$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v`$(VisualStudioVersion)\FSharp\Microsoft.FSharp.Targets')`">
        <FSharpTargetsPath>`$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v`$(VisualStudioVersion)\FSharp\Microsoft.FSharp.Targets</FSharpTargetsPath>
      </PropertyGroup>
    </Otherwise>
  </Choose>
  <Import Project=`"`$(FSharpTargetsPath)`" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name=`"BeforeBuild`">
  </Target>
  <Target Name=`"AfterBuild`">
  </Target>
  -->
</Project>" | Out-File -FilePath "src/$project_name/$project_name.fsproj" -Encoding utf8

"
Project(`"`{bf72cd30-570c-4224-9c5c-6f6a0f5e77af`}`") = `"$project_name`", `"src/$project_name/$project_name.fsproj`", `"{3704d9ed-05dc-4cf4-bdb4-6ba36a283b72}`"
EndProject
" | Out-File -FilePath "$solution_name.sln" -Encoding utf8 -Append