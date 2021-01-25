using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
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
        private string file_name = @"\path.json";
        Dictionary<string, string> dbInfo;
        string dbJson = null;
        string isNull = "notNull";

        public Form1()
        {
            InitializeComponent();
                                                      
        }
        private void NullCheck(string path)
        {
            if (path == null)
            {
                isNull = null;
            }
            
        }
        private void btn_location1_Click(object sender, EventArgs e)
        {
            path_csv = SelectLocation();
            NullCheck(path_csv);
            lbl_path1.Text = path_csv;
           
        }

        private void btn_location2_Click(object sender, EventArgs e)
        {
            path_pyExe = SelectLocation();
            NullCheck(path_pyExe);
            lbl_path2.Text = path_pyExe;
        }

        private void btn_location3_Click(object sender, EventArgs e)
        {
            path_pyScript = SelectLocation();
            NullCheck(path_pyScript);
            lbl_path3.Text = path_pyScript;
        }

        private void btn_location4_Click(object sender, EventArgs e)
        {
            path_save = SelectLocation();
            NullCheck(path_save);
            if(path_save!=null)
            {
                path_save += file_name;
            }
            lbl_path4.Text = path_save;
        }
        private string SelectLocation()
        {
            fd.ShowDialog();
            string path = fd.SelectedPath;
            return path;
        }

        private void InputDbInfo()
        {

            try
            {
                dbInfo = new Dictionary<string, string>();
                dbInfo.Add("ip", txt_db_ip.Text);
                dbInfo.Add("Port", txt_db_port.Text);
                dbInfo.Add("Id", txt_db_id.Text);
                dbInfo.Add("Pw", txt_db_pw.Text);
                dbInfo.Add("database", txt_db_db.Text);
                dbInfo.Add("table", txt_db_tbl.Text);

                dbJson = JsonConvert.SerializeObject(dbInfo, Formatting.Indented);
                dbJson = JValue.Parse(dbJson).ToString(Formatting.Indented);
                //dbJson = @dbJson.Replace("\r\n", "").Replace("\\", "").Replace(" ", "");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       

        }

        private void btn_cencel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt_db_ip.Text!=""&&txt_db_port.Text!=""&&txt_db_id.Text!=""&&txt_db_pw.Text!=""&& txt_db_db.Text !="" && txt_db_tbl.Text !="")
            {
                InputDbInfo();
            }
            else
            {
                MessageBox.Show("db정보를 모두 입력해주세요");
                return;
            }




            try
            {
                if (isNull != null)
                {
                    pathInfo = new JObject(
                    new JProperty("csv path", path_csv),
                    new JProperty("python.exe", path_pyExe),
                    new JProperty("python script", path_pyScript),
                    new JProperty("설정값 저장위치", path_save),
                    new JProperty("DB", dbJson)
                    );
                    File.WriteAllText(path_save, pathInfo.ToString());
                    Close();
                }
                else
                {
                    MessageBox.Show("위치를 모두 지정해주세요");
                    return;
                }           
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            

        }
    }
}
