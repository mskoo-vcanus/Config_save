
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
            this.lbl_csvPath = new System.Windows.Forms.Label();
            this.lbl_pyExe = new System.Windows.Forms.Label();
            this.lbl_pyScript = new System.Windows.Forms.Label();
            this.lbl_savePosition = new System.Windows.Forms.Label();
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cencel = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_db = new System.Windows.Forms.Label();
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
            this.lbl_path1 = new System.Windows.Forms.Label();
            this.lbl_path2 = new System.Windows.Forms.Label();
            this.lbl_path3 = new System.Windows.Forms.Label();
            this.lbl_path4 = new System.Windows.Forms.Label();
            this.btn_location1 = new System.Windows.Forms.Button();
            this.btn_location2 = new System.Windows.Forms.Button();
            this.btn_location3 = new System.Windows.Forms.Button();
            this.btn_location4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_csvPath
            // 
            this.lbl_csvPath.AutoSize = true;
            this.lbl_csvPath.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_csvPath.Location = new System.Drawing.Point(10, 30);
            this.lbl_csvPath.Name = "lbl_csvPath";
            this.lbl_csvPath.Size = new System.Drawing.Size(100, 14);
            this.lbl_csvPath.TabIndex = 0;
            this.lbl_csvPath.Text = "[ csv path ]";
            // 
            // lbl_pyExe
            // 
            this.lbl_pyExe.AutoSize = true;
            this.lbl_pyExe.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_pyExe.Location = new System.Drawing.Point(10, 75);
            this.lbl_pyExe.Name = "lbl_pyExe";
            this.lbl_pyExe.Size = new System.Drawing.Size(120, 14);
            this.lbl_pyExe.TabIndex = 1;
            this.lbl_pyExe.Text = "[ python.exe ]";
            // 
            // lbl_pyScript
            // 
            this.lbl_pyScript.AutoSize = true;
            this.lbl_pyScript.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_pyScript.Location = new System.Drawing.Point(10, 123);
            this.lbl_pyScript.Name = "lbl_pyScript";
            this.lbl_pyScript.Size = new System.Drawing.Size(133, 14);
            this.lbl_pyScript.TabIndex = 2;
            this.lbl_pyScript.Text = "[ python csript ]";
            // 
            // lbl_savePosition
            // 
            this.lbl_savePosition.AutoSize = true;
            this.lbl_savePosition.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_savePosition.Location = new System.Drawing.Point(10, 170);
            this.lbl_savePosition.Name = "lbl_savePosition";
            this.lbl_savePosition.Size = new System.Drawing.Size(146, 14);
            this.lbl_savePosition.TabIndex = 3;
            this.lbl_savePosition.Text = "[ 설정값 저장위치 ]";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(142, 441);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "OK";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cencel
            // 
            this.btn_cencel.Location = new System.Drawing.Point(223, 441);
            this.btn_cencel.Name = "btn_cencel";
            this.btn_cencel.Size = new System.Drawing.Size(75, 23);
            this.btn_cencel.TabIndex = 5;
            this.btn_cencel.Text = "Cancel";
            this.btn_cencel.Click += new System.EventHandler(this.btn_cencel_Click);
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_db.Location = new System.Drawing.Point(10, 221);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(57, 14);
            this.lbl_db.TabIndex = 6;
            this.lbl_db.Text = "[ DB ]";
            // 
            // txt_db_ip
            // 
            this.txt_db_ip.Location = new System.Drawing.Point(142, 242);
            this.txt_db_ip.Name = "txt_db_ip";
            this.txt_db_ip.Size = new System.Drawing.Size(112, 21);
            this.txt_db_ip.TabIndex = 7;
            // 
            // lbl_db_ip
            // 
            this.lbl_db_ip.Location = new System.Drawing.Point(76, 243);
            this.lbl_db_ip.Name = "lbl_db_ip";
            this.lbl_db_ip.Size = new System.Drawing.Size(9, 14);
            this.lbl_db_ip.TabIndex = 8;
            this.lbl_db_ip.Text = "ip";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 273);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "port";
            // 
            // txt_db_port
            // 
            this.txt_db_port.Location = new System.Drawing.Point(142, 272);
            this.txt_db_port.Name = "txt_db_port";
            this.txt_db_port.Size = new System.Drawing.Size(112, 21);
            this.txt_db_port.TabIndex = 10;
            // 
            // txt_db_id
            // 
            this.txt_db_id.Location = new System.Drawing.Point(142, 302);
            this.txt_db_id.Name = "txt_db_id";
            this.txt_db_id.Size = new System.Drawing.Size(112, 21);
            this.txt_db_id.TabIndex = 11;
            // 
            // txt_db_pw
            // 
            this.txt_db_pw.Location = new System.Drawing.Point(142, 332);
            this.txt_db_pw.Name = "txt_db_pw";
            this.txt_db_pw.Size = new System.Drawing.Size(112, 21);
            this.txt_db_pw.TabIndex = 12;
            // 
            // txt_db_db
            // 
            this.txt_db_db.Location = new System.Drawing.Point(142, 362);
            this.txt_db_db.Name = "txt_db_db";
            this.txt_db_db.Size = new System.Drawing.Size(112, 21);
            this.txt_db_db.TabIndex = 13;
            // 
            // txt_db_tbl
            // 
            this.txt_db_tbl.Location = new System.Drawing.Point(142, 392);
            this.txt_db_tbl.Name = "txt_db_tbl";
            this.txt_db_tbl.Size = new System.Drawing.Size(112, 21);
            this.txt_db_tbl.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 363);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 14);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "database";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(68, 333);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 14);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Pw";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(74, 303);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(11, 14);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Id";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(58, 392);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 14);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "table";
            // 
            // lbl_path1
            // 
            this.lbl_path1.AutoSize = true;
            this.lbl_path1.Font = new System.Drawing.Font("굴림", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_path1.Location = new System.Drawing.Point(2, 55);
            this.lbl_path1.Name = "lbl_path1";
            this.lbl_path1.Size = new System.Drawing.Size(8, 10);
            this.lbl_path1.TabIndex = 19;
            this.lbl_path1.Text = ":";
            // 
            // lbl_path2
            // 
            this.lbl_path2.AutoSize = true;
            this.lbl_path2.Font = new System.Drawing.Font("굴림", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_path2.Location = new System.Drawing.Point(2, 100);
            this.lbl_path2.Name = "lbl_path2";
            this.lbl_path2.Size = new System.Drawing.Size(8, 10);
            this.lbl_path2.TabIndex = 20;
            this.lbl_path2.Text = ":";
            // 
            // lbl_path3
            // 
            this.lbl_path3.AutoSize = true;
            this.lbl_path3.Font = new System.Drawing.Font("굴림", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_path3.Location = new System.Drawing.Point(2, 147);
            this.lbl_path3.Name = "lbl_path3";
            this.lbl_path3.Size = new System.Drawing.Size(8, 10);
            this.lbl_path3.TabIndex = 21;
            this.lbl_path3.Text = ":";
            // 
            // lbl_path4
            // 
            this.lbl_path4.AutoSize = true;
            this.lbl_path4.Font = new System.Drawing.Font("굴림", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_path4.Location = new System.Drawing.Point(2, 193);
            this.lbl_path4.Name = "lbl_path4";
            this.lbl_path4.Size = new System.Drawing.Size(8, 10);
            this.lbl_path4.TabIndex = 22;
            this.lbl_path4.Text = ":";
            // 
            // btn_location1
            // 
            this.btn_location1.Location = new System.Drawing.Point(179, 26);
            this.btn_location1.Name = "btn_location1";
            this.btn_location1.Size = new System.Drawing.Size(75, 23);
            this.btn_location1.TabIndex = 23;
            this.btn_location1.Text = "button1";
            this.btn_location1.UseVisualStyleBackColor = true;
            this.btn_location1.Click += new System.EventHandler(this.btn_location1_Click);
            // 
            // btn_location2
            // 
            this.btn_location2.Location = new System.Drawing.Point(179, 71);
            this.btn_location2.Name = "btn_location2";
            this.btn_location2.Size = new System.Drawing.Size(75, 23);
            this.btn_location2.TabIndex = 24;
            this.btn_location2.Text = "button2";
            this.btn_location2.UseVisualStyleBackColor = true;
            this.btn_location2.Click += new System.EventHandler(this.btn_location2_Click);
            // 
            // btn_location3
            // 
            this.btn_location3.Location = new System.Drawing.Point(179, 119);
            this.btn_location3.Name = "btn_location3";
            this.btn_location3.Size = new System.Drawing.Size(75, 23);
            this.btn_location3.TabIndex = 25;
            this.btn_location3.Text = "button3";
            this.btn_location3.UseVisualStyleBackColor = true;
            this.btn_location3.Click += new System.EventHandler(this.btn_location3_Click);
            // 
            // btn_location4
            // 
            this.btn_location4.Location = new System.Drawing.Point(179, 166);
            this.btn_location4.Name = "btn_location4";
            this.btn_location4.Size = new System.Drawing.Size(75, 23);
            this.btn_location4.TabIndex = 26;
            this.btn_location4.Text = "button4";
            this.btn_location4.UseVisualStyleBackColor = true;
            this.btn_location4.Click += new System.EventHandler(this.btn_location4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 476);
            this.Controls.Add(this.btn_location4);
            this.Controls.Add(this.btn_location3);
            this.Controls.Add(this.btn_location2);
            this.Controls.Add(this.btn_location1);
            this.Controls.Add(this.lbl_path4);
            this.Controls.Add(this.lbl_path3);
            this.Controls.Add(this.lbl_path2);
            this.Controls.Add(this.lbl_path1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_db_tbl);
            this.Controls.Add(this.txt_db_db);
            this.Controls.Add(this.txt_db_pw);
            this.Controls.Add(this.txt_db_id);
            this.Controls.Add(this.txt_db_port);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbl_db_ip);
            this.Controls.Add(this.txt_db_ip);
            this.Controls.Add(this.lbl_db);
            this.Controls.Add(this.btn_cencel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_savePosition);
            this.Controls.Add(this.lbl_pyScript);
            this.Controls.Add(this.lbl_pyExe);
            this.Controls.Add(this.lbl_csvPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_csvPath;
        private System.Windows.Forms.Label lbl_pyExe;
        private System.Windows.Forms.Label lbl_pyScript;
        private System.Windows.Forms.Label lbl_savePosition;
        private DevExpress.XtraEditors.SimpleButton btn_ok;
        private DevExpress.XtraEditors.SimpleButton btn_cencel;
        private System.Windows.Forms.Label lbl_db;
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
        private System.Windows.Forms.Label lbl_path1;
        private System.Windows.Forms.Label lbl_path2;
        private System.Windows.Forms.Label lbl_path3;
        private System.Windows.Forms.Label lbl_path4;
        private System.Windows.Forms.Button btn_location1;
        private System.Windows.Forms.Button btn_location2;
        private System.Windows.Forms.Button btn_location3;
        private System.Windows.Forms.Button btn_location4;
    }
}

