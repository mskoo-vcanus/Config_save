
namespace Config_Save
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cencel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_db_ip = new System.Windows.Forms.TextBox();
            this.lbl_db_ip = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_db_port = new System.Windows.Forms.TextBox();
            this.txt_db_id = new System.Windows.Forms.TextBox();
            this.txt_db_pw = new System.Windows.Forms.TextBox();
            this.txt_db_db = new System.Windows.Forms.TextBox();
            this.txt_db_tbl = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_csvPath = new System.Windows.Forms.Label();
            this.lbl_pythonExe = new System.Windows.Forms.Label();
            this.lbl_pythonScript = new System.Windows.Forms.Label();
            this.lbl_saveLocation = new System.Windows.Forms.Label();
            this.btn_location1 = new System.Windows.Forms.Button();
            this.btn_location2 = new System.Windows.Forms.Button();
            this.btn_location3 = new System.Windows.Forms.Button();
            this.btn_location4 = new System.Windows.Forms.Button();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panel_path = new System.Windows.Forms.Panel();
            this.panel_db = new System.Windows.Forms.Panel();
            this.panel_path.SuspendLayout();
            this.panel_db.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(305, 412);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 31);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "등록";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cencel
            // 
            this.btn_cencel.Location = new System.Drawing.Point(386, 412);
            this.btn_cencel.Name = "btn_cencel";
            this.btn_cencel.Size = new System.Drawing.Size(75, 31);
            this.btn_cencel.TabIndex = 5;
            this.btn_cencel.Text = "취소";
            this.btn_cencel.Click += new System.EventHandler(this.btn_cencel_Click);
            // 
            // txt_db_ip
            // 
            this.txt_db_ip.Location = new System.Drawing.Point(129, 28);
            this.txt_db_ip.Name = "txt_db_ip";
            this.txt_db_ip.Size = new System.Drawing.Size(284, 21);
            this.txt_db_ip.TabIndex = 7;
            // 
            // lbl_db_ip
            // 
            this.lbl_db_ip.Location = new System.Drawing.Point(93, 28);
            this.lbl_db_ip.Name = "lbl_db_ip";
            this.lbl_db_ip.Size = new System.Drawing.Size(9, 14);
            this.lbl_db_ip.TabIndex = 8;
            this.lbl_db_ip.Text = "ip";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(79, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "port";
            // 
            // txt_db_port
            // 
            this.txt_db_port.Location = new System.Drawing.Point(129, 58);
            this.txt_db_port.Name = "txt_db_port";
            this.txt_db_port.Size = new System.Drawing.Size(284, 21);
            this.txt_db_port.TabIndex = 10;
            // 
            // txt_db_id
            // 
            this.txt_db_id.Location = new System.Drawing.Point(129, 88);
            this.txt_db_id.Name = "txt_db_id";
            this.txt_db_id.Size = new System.Drawing.Size(284, 21);
            this.txt_db_id.TabIndex = 11;
            // 
            // txt_db_pw
            // 
            this.txt_db_pw.Location = new System.Drawing.Point(129, 118);
            this.txt_db_pw.Name = "txt_db_pw";
            this.txt_db_pw.Size = new System.Drawing.Size(284, 21);
            this.txt_db_pw.TabIndex = 12;
            // 
            // txt_db_db
            // 
            this.txt_db_db.Location = new System.Drawing.Point(129, 148);
            this.txt_db_db.Name = "txt_db_db";
            this.txt_db_db.Size = new System.Drawing.Size(284, 21);
            this.txt_db_db.TabIndex = 13;
            // 
            // txt_db_tbl
            // 
            this.txt_db_tbl.Location = new System.Drawing.Point(129, 178);
            this.txt_db_tbl.Name = "txt_db_tbl";
            this.txt_db_tbl.Size = new System.Drawing.Size(284, 21);
            this.txt_db_tbl.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 148);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 14);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "database";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(85, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 14);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Pw";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(91, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(11, 14);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Id";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(75, 177);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 14);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "table";
            // 
            // lbl_csvPath
            // 
            this.lbl_csvPath.AutoSize = true;
            this.lbl_csvPath.Font = new System.Drawing.Font("굴림", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_csvPath.Location = new System.Drawing.Point(117, 37);
            this.lbl_csvPath.Name = "lbl_csvPath";
            this.lbl_csvPath.Size = new System.Drawing.Size(14, 10);
            this.lbl_csvPath.TabIndex = 19;
            this.lbl_csvPath.Text = "\\";
            // 
            // lbl_pythonExe
            // 
            this.lbl_pythonExe.AutoSize = true;
            this.lbl_pythonExe.Font = new System.Drawing.Font("굴림", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_pythonExe.Location = new System.Drawing.Point(117, 66);
            this.lbl_pythonExe.Name = "lbl_pythonExe";
            this.lbl_pythonExe.Size = new System.Drawing.Size(14, 10);
            this.lbl_pythonExe.TabIndex = 20;
            this.lbl_pythonExe.Text = "\\";
            // 
            // lbl_pythonScript
            // 
            this.lbl_pythonScript.AutoSize = true;
            this.lbl_pythonScript.Font = new System.Drawing.Font("굴림", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_pythonScript.Location = new System.Drawing.Point(117, 95);
            this.lbl_pythonScript.Name = "lbl_pythonScript";
            this.lbl_pythonScript.Size = new System.Drawing.Size(14, 10);
            this.lbl_pythonScript.TabIndex = 21;
            this.lbl_pythonScript.Text = "\\";
            // 
            // lbl_saveLocation
            // 
            this.lbl_saveLocation.AutoSize = true;
            this.lbl_saveLocation.Font = new System.Drawing.Font("굴림", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_saveLocation.Location = new System.Drawing.Point(117, 124);
            this.lbl_saveLocation.Name = "lbl_saveLocation";
            this.lbl_saveLocation.Size = new System.Drawing.Size(14, 10);
            this.lbl_saveLocation.TabIndex = 22;
            this.lbl_saveLocation.Text = "\\";
            // 
            // btn_location1
            // 
            this.btn_location1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_location1.Location = new System.Drawing.Point(6, 30);
            this.btn_location1.Name = "btn_location1";
            this.btn_location1.Size = new System.Drawing.Size(105, 23);
            this.btn_location1.TabIndex = 23;
            this.btn_location1.Text = "csv path";
            this.btn_location1.UseVisualStyleBackColor = false;
            this.btn_location1.Click += new System.EventHandler(this.btn_location1_Click);
            // 
            // btn_location2
            // 
            this.btn_location2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_location2.Location = new System.Drawing.Point(6, 59);
            this.btn_location2.Name = "btn_location2";
            this.btn_location2.Size = new System.Drawing.Size(105, 23);
            this.btn_location2.TabIndex = 24;
            this.btn_location2.Text = "python.exe";
            this.btn_location2.UseVisualStyleBackColor = false;
            this.btn_location2.Click += new System.EventHandler(this.btn_location2_Click);
            // 
            // btn_location3
            // 
            this.btn_location3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_location3.Location = new System.Drawing.Point(6, 88);
            this.btn_location3.Name = "btn_location3";
            this.btn_location3.Size = new System.Drawing.Size(105, 23);
            this.btn_location3.TabIndex = 25;
            this.btn_location3.Text = "python script";
            this.btn_location3.UseVisualStyleBackColor = false;
            this.btn_location3.Click += new System.EventHandler(this.btn_location3_Click);
            // 
            // btn_location4
            // 
            this.btn_location4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_location4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_location4.Location = new System.Drawing.Point(6, 117);
            this.btn_location4.Name = "btn_location4";
            this.btn_location4.Size = new System.Drawing.Size(105, 23);
            this.btn_location4.TabIndex = 26;
            this.btn_location4.Text = "설정값 저장위치";
            this.btn_location4.UseVisualStyleBackColor = false;
            this.btn_location4.Click += new System.EventHandler(this.btn_location4_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(6, 7);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 17);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "1. 설정값 추가";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(6, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 17);
            this.labelControl7.TabIndex = 28;
            this.labelControl7.Text = "2. DB 정보 추가";
            // 
            // panel_path
            // 
            this.panel_path.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_path.Controls.Add(this.labelControl6);
            this.panel_path.Controls.Add(this.btn_location4);
            this.panel_path.Controls.Add(this.btn_location3);
            this.panel_path.Controls.Add(this.btn_location2);
            this.panel_path.Controls.Add(this.btn_location1);
            this.panel_path.Controls.Add(this.lbl_saveLocation);
            this.panel_path.Controls.Add(this.lbl_pythonScript);
            this.panel_path.Controls.Add(this.lbl_pythonExe);
            this.panel_path.Controls.Add(this.lbl_csvPath);
            this.panel_path.Location = new System.Drawing.Point(12, 21);
            this.panel_path.Name = "panel_path";
            this.panel_path.Size = new System.Drawing.Size(451, 152);
            this.panel_path.TabIndex = 29;
            // 
            // panel_db
            // 
            this.panel_db.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_db.Controls.Add(this.labelControl7);
            this.panel_db.Controls.Add(this.labelControl5);
            this.panel_db.Controls.Add(this.labelControl4);
            this.panel_db.Controls.Add(this.labelControl3);
            this.panel_db.Controls.Add(this.labelControl2);
            this.panel_db.Controls.Add(this.txt_db_tbl);
            this.panel_db.Controls.Add(this.txt_db_db);
            this.panel_db.Controls.Add(this.txt_db_pw);
            this.panel_db.Controls.Add(this.txt_db_id);
            this.panel_db.Controls.Add(this.txt_db_port);
            this.panel_db.Controls.Add(this.labelControl1);
            this.panel_db.Controls.Add(this.lbl_db_ip);
            this.panel_db.Controls.Add(this.txt_db_ip);
            this.panel_db.Location = new System.Drawing.Point(12, 185);
            this.panel_db.Name = "panel_db";
            this.panel_db.Size = new System.Drawing.Size(449, 210);
            this.panel_db.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 455);
            this.ControlBox = false;
            this.Controls.Add(this.panel_db);
            this.Controls.Add(this.panel_path);
            this.Controls.Add(this.btn_cencel);
            this.Controls.Add(this.btn_ok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_path.ResumeLayout(false);
            this.panel_path.PerformLayout();
            this.panel_db.ResumeLayout(false);
            this.panel_db.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_ok;
        private DevExpress.XtraEditors.SimpleButton btn_cencel;
        private System.Windows.Forms.TextBox txt_db_ip;
        private DevExpress.XtraEditors.LabelControl lbl_db_ip;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txt_db_port;
        private System.Windows.Forms.TextBox txt_db_id;
        private System.Windows.Forms.TextBox txt_db_pw;
        private System.Windows.Forms.TextBox txt_db_db;
        private System.Windows.Forms.TextBox txt_db_tbl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Label lbl_csvPath;
        private System.Windows.Forms.Label lbl_pythonExe;
        private System.Windows.Forms.Label lbl_pythonScript;
        private System.Windows.Forms.Label lbl_saveLocation;
        private System.Windows.Forms.Button btn_location1;
        private System.Windows.Forms.Button btn_location2;
        private System.Windows.Forms.Button btn_location3;
        private System.Windows.Forms.Button btn_location4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Panel panel_path;
        private System.Windows.Forms.Panel panel_db;
    }
}

