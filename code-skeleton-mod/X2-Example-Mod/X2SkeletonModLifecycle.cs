using System;
using System.Reflection;
using Artitas;
using Artitas.Utils;
using Common.Modding;
using HarmonyLib;
using log4net;
using Xenonauts.Common.Settings;

namespace X2SkeletonMod {
    
    public class X2SkeletonModLifecycle : IModLifecycle {
        
        #region Logging

        private static readonly ILog Log = ArtitasLogger.GetLogger(MethodBase.GetCurrentMethod()!.DeclaringType);

        private static readonly bool IsWarnEnabled = Log.IsWarnEnabled;
        private static readonly bool IsInfoEnabled = Log.IsInfoEnabled;

        #endregion

        public void Create(Mod mod, Harmony patcher) {
            Log.Warn("[X2-Example-Mod] Started Example Mod!");
        }
        
        public void Destroy() {
            Log.Warn("[X2-Example-Mod] Destroyed Example Mod!");
        }
        
        public void OnWorldCreate(IModLifecycle.Section section, WeakReference<World> world) {
            Log.Warn($"[X2-Example-Mod] World Create: {section}");
        }
        
        public void OnWorldDispose(IModLifecycle.Section section, WeakReference<World> world) {
            Log.Warn($"[X2-Example-Mod] World Dispose: {section}");
        }
    }
    
}