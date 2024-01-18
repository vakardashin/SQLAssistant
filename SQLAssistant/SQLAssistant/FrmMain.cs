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
            // Servers = DbServerHelper.GetServerList();
            Servers = ConfigHelper.ReadFromConfigFile();
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
                    var output = SQLAssistantHelper.FormatResults(lst);
                    TxtResult.Text = output;
                    // SELECT * FROM employee
                }
                else
                {
                    int i = processor.ExecuteSqlCommand(sql);
                    TxtResult.Text = "Records processed: " + i.ToString();
                }
                
            }
            catch (Exception ex)
            {
                TxtResult.Text = ex.Message;
            }
        }

        private void BtnExecuteFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open SQL File";
            theDialog.Filter = "SQL files|*.sql|All files|*.*";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var config = Servers[CboDbServers.SelectedIndex];
                    var processor = new DbProcessor(config);
                    string fileName = theDialog.FileName;
                    int i = processor.ExecuteSqlFile(fileName);
                    TxtResult.Text = "Records processed: " + i.ToString();
                }
                catch (Exception ex)
                {
                    TxtResult.Text = ex.Message;
                }
            }
        }

        private void BtnService_Click(object sender, EventArgs e)
        {
            var configs = Servers;
            ConfigHelper.WriteToConfigFile(configs);
            MessageBox.Show("OK");
        }
    }
}
