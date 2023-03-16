using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeePass.Plugins;
using KeePass.Forms;
using System.Drawing;

namespace KeePassOneIdentitySync
{
    public class KeePassOneIdentitySyncExt : Plugin {
        private IPluginHost m_host = null;

        public override Image SmallIcon {
            get { return null;  /*Resources.Icon16x16;*/ }
        }

        public override string UpdateUrl {
            get { return "https://github.com/MarkZither/OneIdentity.SafeguardDotNet.Tools/raw/master/keepass.version"; }
        }

        public override bool Initialize(IPluginHost host) {
            if (host == null) return false;
            m_host = host;
            m_host.MainWindow.FileSaved += StartSync;
            return true;
        }

        public override void Terminate() {
            if (m_host != null) {
                m_host.MainWindow.FileSaved -= StartSync;
            }
        }

        private void StartSync(Object sender, FileSavedEventArgs args) {
            //Sync.StartSync(args.Database);
        }
    }
}
