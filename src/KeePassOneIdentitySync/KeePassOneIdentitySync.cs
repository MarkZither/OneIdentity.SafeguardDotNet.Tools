using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeePass.Plugins;
using KeePass.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

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
            Debugger.Launch();
            if (host == null) return false;
            m_host = host;
            m_host.MainWindow.FileSaved += StartSync;
            return true;
        }

        public override ToolStripMenuItem GetMenuItem(PluginMenuType t) {
            // Provide a menu item for the main location(s)
            if (t == PluginMenuType.Main) {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Text = "OneIdentity Sync";
                tsmi.Click += this.OnOptionsClicked;
                return tsmi;
            }
            if (t == PluginMenuType.Group) {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Text = "OneIdentity Sync";
                tsmi.Click += this.OnOptionsClicked;
                return tsmi;
            }

            return null; // No menu items in other locations
        }

        private void OnOptionsClicked(object sender, EventArgs e) {
            Synchronization.StartSync(m_host.Database);
            m_host.MainWindow.Refresh();
            m_host.MainWindow.RefreshEntriesList();
        }

        public override void Terminate() {
            if (m_host != null) {
                m_host.MainWindow.FileSaved -= StartSync;
            }
        }

        private void StartSync(Object sender, FileSavedEventArgs args) {
            Synchronization.StartSync(args.Database);
            m_host.MainWindow.Refresh();
        }
    }
}
