using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace BonePatches
{
    [StaticConstructorOnStartup]
    public static class HarmonyPatches
    {
        static HarmonyPatches()
        {

            var harmony = new Harmony("Harmony_Bone_Patches");
            try
            {
                harmony.PatchAll(Assembly.GetExecutingAssembly());
                Log.Message("Bones in Medieval Overhauls patched");
            }
            catch (Exception e)
            {
                Log.Error($"Bone Patch in Medieval Overhaul exception: {e.Message}");
            }
        }

    }
}
