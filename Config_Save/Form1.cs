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
        JObject pathInfo;
        private string path_csv = null;
        private string path_pyExe = null;
        private string path_pyScript = null;
        private string path_save = null;
        Dictionary<string, string> dbInfo;


        public Form1()
        {
            InitializeComponent();

        }

        private void btn_location1_Click(object sender, EventArgs e)
        {
            path_csv = SelectLocation();
            lbl_path1.Text = path_csv;
            
        }

        private void btn_location2_Click(object sender, EventArgs e)
        {
            path_pyExe = SelectLocation();
            lbl_path2.Text = path_pyExe;
        }

        private void btn_location3_Click(object sender, EventArgs e)
        {
            path_pyScript = SelectLocation();
            lbl_path3.Text = path_pyScript;
        }

        private void btn_location4_Click(object sender, EventArgs e)
        {
            path_save = SelectLocation();
            lbl_path4.Text = path_save;
        }
        private string SelectLocation()
        {
            fd.ShowDialog();
            string path = fd.SelectedPath;
            return path;
        }

        private void setDbInfo()
        {
            try
            {
                dbInfo = new Dictionary<string, string>();
                dbInfo.Add("ip", txt_db_ip.ToString());
                dbInfo.Add("Port", txt_db_port.ToString());
                dbInfo.Add("Id", txt_db_id.ToString());
                dbInfo.Add("Pw", txt_db_pw.ToString());
                dbInfo.Add("database", txt_db_db.ToString());
                dbInfo.Add("table", txt_db_tbl.ToString());
            }catch(Exception e)
            {
                
            }
            

        }

        private void btn_cencel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            setDbInfo();

            pathInfo = new JObject(
                new JProperty("csv path", path_csv),
                new JProperty("python.exe", path_pyExe),
                new JProperty("python script", path_pyScript),
                new JProperty("설정값 저장위치", path_save),
                new JProperty("DB", dbInfo.ToString())
            );

            File.WriteAllText(path_save, pathInfo.ToString());
            Close();
        }
    }
}
