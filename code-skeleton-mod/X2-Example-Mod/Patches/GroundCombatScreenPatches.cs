using System;
using System.Collections.Generic;
using System.Diagnostics;
using Common.Screens.DataStructures;
using HarmonyLib;
using RSG;
using Xenonauts.GroundCombat;
using static X2SkeletonMod.ModConstants;

namespace X2SkeletonMod.Patches {
    
    [HarmonyPatch(typeof(GroundCombatScreen), "OnSetup")]
    public static class GroundCombatScreenPatches {
        
        /// <summary>
        /// Example of a Prefix patch.
        /// The patched method will be determined by the [HarmonyPatch] attribute parameters.
        /// </summary>
        [HarmonyPrefix]
        public static bool OnSetup(ref List<Func<IPromise>> __result, IScreenParameters parameters, IPromise loadCompletePromise)
        {
            // Log message to show this patch is working
            Log.Info($"[X2-Example-Mod] Intercepted GroundCombatScreen.OnSetup");
        
            // Modify parameters or return values
            // __result = true; // This would override the original method's return value
        
            // Return false to skip the original method, or true to run it after this prefix
            return true;
        }
    
    }
    
}