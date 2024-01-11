using ScanDal;
using SQLAssistant10Common;
using SQLAssistant29Dal;
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
            string s = "";
            try
            {
                var config = Servers[CboDbServers.SelectedIndex];
                string s2 = DbTest.DoDbTest(config);
                s = "Connection successful!";
            }
            catch (Exception ex)
            {
                s = ex.Message;
            }
           
            MessageBox.Show(s);
        }

        private void BtnExecuteSql_Click(object sender, EventArgs e)
        {
            try
            {
                var config = Servers[CboDbServers.SelectedIndex];
                var processor = new DbProcessor(config);
                string sql = TxtSql.Text;
                if (SQLAssistantHelper.DoSelect(sql))
                {
                    var lst = processor.ExecuteSqlSelect(sql);
                    var output = SQLAssistantHelper.FormatResultsSimple(lst);
                    TxtResult.Text = output;
                }
                else
                {
                    TxtResult.Text = "Not select!";
                }
                
            }
            catch (Exception ex)
            {
                TxtResult.Text = ex.Message;
            }
        }
    }
}
