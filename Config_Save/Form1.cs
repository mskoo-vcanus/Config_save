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

        SystemConfig sysConfig = SystemConfig.Instance;
        
        private bool isValid = true;

        public Form1()
        {
            InitializeComponent();
            ConfigToUI();
                                                      
        }
        //private void NullCheck(string path)
        //{//path값 null 체크
        //    if (path != null)
        //    {
        //        isNull = false;
        //    }
            
        //}

        private void NullCheck(JObject jObj)
        {
            try
            {
                for (int i = 0; i < jObj.Count; i++)
                {
                    JToken token = jObj[i];
                    jObj.HasValues
                    if (token.HasValues == false) { isValid = false; }
                }
                

            }catch(Exception ex)
            {
                MessageBox.Show("NullCheck : " + ex.Message);
            }
                       
            
        }
        private void btn_location1_Click(object sender, EventArgs e)
        {
            lbl_path1.Text = sysConfig.CsvPath = SelectLocation();
            
            
        }

        private void btn_location2_Click(object sender, EventArgs e)
        {
            lbl_path2.Text = sysConfig.PythonExe = SelectLocation();
        }

        private void btn_location3_Click(object sender, EventArgs e)
        {
            lbl_path3.Text = sysConfig.PythonScript = SelectLocation();
        }

        private void btn_location4_Click(object sender, EventArgs e)
        {
            lbl_path4.Text = sysConfig.SaveLocation = SelectLocation();            
        }
        private string SelectLocation()
        {//경로지정
            fd.ShowDialog();
            string path = fd.SelectedPath;
            return path;
        }


        private void btn_cencel_Click(object sender, EventArgs e)
        {//취소
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            UIToConfig();
            SystemConfig.Instance.Save();     

        }


        public void ConfigToUI()
        {
            SystemConfig config = SystemConfig.Instance;
        }

        public void UIToConfig()
        {
            SystemConfig config = SystemConfig.Instance;

        }
    }
}
