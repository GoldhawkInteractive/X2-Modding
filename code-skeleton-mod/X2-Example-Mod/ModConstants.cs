using System.Reflection;
using Artitas.Utils;
using log4net;

namespace X2SkeletonMod {
    
    public class ModConstants {
        
        #region Logging

        public static readonly ILog Log = ArtitasLogger.GetLogger(MethodBase.GetCurrentMethod()!.DeclaringType);

        public static readonly bool IsWarnEnabled = Log.IsWarnEnabled;
        public static readonly bool IsInfoEnabled = Log.IsInfoEnabled;

        #endregion
        
    }
}