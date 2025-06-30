# X2SkeletonMod - Xenonauts 2 Game Code Mod Template

A skeleton project for creating mods for Xenonauts 2 using Harmony, for Unity 2022.3.

## Project Structure

```
X2-Example-Mod/
├── Properties/
│   └── AssemblyInfo.cs
├── Patches/
│   └── ExamplePatch.cs        (Specific Harmony patches)
├── $NameModLifecycle.cs       (Main mod entry point & lifecycle)
```

## Setup Instructions

### Prerequisites

- Visual Studio 2022 or JetBrains Rider
- .NET Framework 4.8 SDK
- Xenonauts 2 installed

### Linking Game DLLs

1. Edit the `Directory.Build.props` file in the solution directory and update the three paths which now contain placeholder paths:

```xml
<Project>
  <PropertyGroup>
        <!-- Path to Xenonauts 2 DLLs: Replace this path with the path to Xenonaut's installation folder -->
        <GameFolder>$xenonauts_2_install/Xenonauts2_Data/Managed</GameFolder>
        <!-- Path to all external DLLs: Replace this path with either the path to Xenonaut's installation folder or your local cache folder if you are compiling against the code base. -->
        <CacheFolder>$mod_repo/binaries</CacheFolder>
        <!-- Mod root folder in your home directory: Replace this with the path to your mod's root folder (E.g. My Games/Xenonauts 2/Mods/<mod_name>) so the binaries will auto-copy on build.  -->
        <ModInstanceFolder>$home_dir/My Games/Xenonauts 2-Editor/Mods/$mod_identifier</ModInstanceFolder>
  </PropertyGroup>
</Project>
```

2. This will allow the project to: 
    1. find the required DLLs from your game installation:
      - `Assembly-CSharp.dll` - Main game assembly
      - `UnityEngine.dll` - Unity engine core
      - `UnityEngine.CoreModule.dll` - Unity engine core module
      - `0Harmony.dll` - Harmony library (may be included with the game or mod loader)
      - 
    2. auto-copy the DLLs into the mod folder upon recompile.

## Using the Mod Template

### IModLifecycle Interface

The `IModLifecycle` interface defines three methods that are called at different points in the game's execution:

- `Create(Mod mod, Harmony patcher)` - Called when the mod is first loaded
- `Destroy()` - Called when the mod is unloaded
- `OnWorldCreate(IModLifecycle.Section section, WeakReference<World> world)` - Called when the game enters a specific screen and creates the world for it.
- `OnWorldDispose(IModLifecycle.Section section, WeakReference<World> world)` - Called when the screen is shut down and the world is disposed.

### Creating Harmony Patches

1. Identify the game class and method you want to patch
2. Create a new class in the `Patches` folder
3. Use Harmony attributes to define your patches
4. See `ExamplePatch.cs` for examples of prefix and postfix patches

## Troubleshooting

- **Missing DLLs**: Ensure your `GameFolder` path is correct in the `Directory.Build.props` file

## Resources

- [Harmony Documentation](https://harmony.pardeike.net/articles/intro.html)
- [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/)