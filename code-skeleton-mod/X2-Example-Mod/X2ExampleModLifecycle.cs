using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Artitas;
using Artitas.Utils;
using Common.Content;
using Common.Modding;
using HarmonyLib;
using log4net;

namespace X2ExampleMod {
    
    public class X2ExampleModLifecycle : IModLifecycle {
        
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

        public IEnumerable<Descriptor> GetRequiredAssets(IModLifecycle.Section section) {
            return Enumerable.Empty<Descriptor>();
        }

        public void OnWorldDispose(IModLifecycle.Section section, WeakReference<World> world) {
            Log.Warn($"[X2-Example-Mod] World Dispose: {section}");
        }
    }
    
}