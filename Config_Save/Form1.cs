using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Config_Save
{
    public partial class Form1 : Form
    {
        public static FolderBrowserDialog fd = new FolderBrowserDialog();

        SystemConfig config = SystemConfig.Instance;

        private string csvPath = null;
        private string pythonExe = null ;
        private string pythonScript = null;
        private string saveLocation = null ;
        private string ip = null;
        private string port = null;
        private string id = null;
        private string pw = null;
        private string database = null;
        private string table = null;

        public Form1()
        {
            InitializeComponent();
            ConfigToUI();
                                                      
        }

        private bool NullCheck()
        {
            string[] configs = 
                { csvPath, pythonExe, pythonScript, saveLocation, ip, port, id, pw, database, table };
            
            foreach(string item in configs)
            {
                if (item == null || item.Trim() == "") { return false; }
            }

            return true;
        }

        private void btn_location1_Click(object sender, EventArgs e)
        {
            lbl_csvPath.Text = SelectLocation();            
        }

        private void btn_location2_Click(object sender, EventArgs e)
        {
            lbl_pythonExe.Text = SelectLocation();
        }

        private void btn_location3_Click(object sender, EventArgs e)
        {
            lbl_pythonScript.Text = SelectLocation();
        }

        private void btn_location4_Click(object sender, EventArgs e)
        {
            lbl_saveLocation.Text = SelectLocation();            
        }
        private string SelectLocation()
        {//경로지정
            fd.ShowDialog();
            string path = fd.SelectedPath;
            return path;
        }


        private void btn_cencel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (UIToConfig())
            {
                config.Save();
                Close();
            }            
            else
            {
                MessageBox.Show("설정값과 DB정보를 모두 입력해주세요");
                return;
            }
        }

        private void InputInfo()
        {
            csvPath = lbl_csvPath.Text;
            pythonExe = lbl_pythonExe.Text;
            pythonScript = lbl_pythonScript.Text;
            saveLocation = lbl_saveLocation.Text;


            ip = txt_db_ip.Text;
            port = txt_db_port.Text;
            id = txt_db_id.Text;
            pw = txt_db_pw.Text;
            database = txt_db_db.Text;
            table = txt_db_tbl.Text;
        }

        public void ConfigToUI()
        {
            lbl_csvPath.Text = config.CsvPath;
            lbl_pythonExe.Text = config.PythonExe;
            lbl_pythonScript.Text = config.PythonScript;
            lbl_saveLocation.Text = config.SaveLocation;

            txt_db_ip.Text = config.Ip;
            txt_db_port.Text = config.Port;
            txt_db_id.Text = config.Id;
            txt_db_pw.Text = config.Pw;
            txt_db_db.Text = config.Database;
            txt_db_tbl.Text = config.Table;
        }

        public bool UIToConfig()
        {
            InputInfo();

            if (NullCheck())
            {
                config.CsvPath = csvPath;
                config.PythonExe = pythonExe;
                config.PythonScript = pythonScript;
                config.SaveLocation = saveLocation;
                config.Ip = ip;
                config.Port = port;
                config.Id = id;
                config.Pw = pw;
                config.Database = database;
                config.Table = table;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
