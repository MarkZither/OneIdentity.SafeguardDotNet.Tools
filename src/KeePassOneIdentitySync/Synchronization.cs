using KeePassLib;
using KeePassLib.Keys;
using KeePassLib.Serialization;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeePassOneIdentitySync {
    public class Synchronization {
        private static IOConnectionInfo connectionInfo = null;
        private static CompositeKey MasterKey = null;
        private static bool inSlave = false;
        private static List<string> EditedDatabases = new List<string>();

        private static string currentJob = "";
        public static void StartSync(PwDatabase sourceDb) {
        }
    }
}
