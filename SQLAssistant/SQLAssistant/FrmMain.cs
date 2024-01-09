using ScanDal;
using SQLAssistant10Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLAssistant
{
    public partial class FrmMain : Form
    {
        private List<DbServerConfig> Servers {  get; set; }
        public FrmMain()
        {
            InitializeComponent();
            InitMe();
        }
        private void InitMe()
        {
            Servers = DbServerHelper.GetServerList();
            foreach (DbServerConfig server in Servers)
            {
                CboDbServers.Items.Add(server.ServerName);
            }
            CboDbServers.SelectedIndex = 0;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            var config = Servers[CboDbServers.SelectedIndex];
            string s = DbTest.DoDbTest(config);
            MessageBox.Show(s);
        }
    }
}
