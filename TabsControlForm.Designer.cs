namespace Myprojeck
{
    partial class TabsControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tapMain = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tapAddStudent = new System.Windows.Forms.TabPage();
            this.nuAge = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoFamle = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSpeclalization = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tapSeach = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblGenderInfo = new System.Windows.Forms.Label();
            this.lblSpecInfo = new System.Windows.Forms.Label();
            this.lblAgeInfo = new System.Windows.Forms.Label();
            this.lblPhoneInfo = new System.Windows.Forms.Label();
            this.lblEmailInfo = new System.Windows.Forms.Label();
            this.lblFullNameInfo = new System.Windows.Forms.Label();
            this.lblIDInfo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tapstudentList = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tapMain.SuspendLayout();
            this.tapAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuAge)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tapSeach.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tapstudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tapMain);
            this.tabControl1.Controls.Add(this.tapAddStudent);
            this.tabControl1.Controls.Add(this.tapSeach);
            this.tabControl1.Controls.Add(this.tapstudentList);
            this.tabControl1.Location = new System.Drawing.Point(-3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tapMain
            // 
            this.tapMain.Controls.Add(this.button2);
            this.tapMain.Controls.Add(this.pictureBox1);
            this.tapMain.Location = new System.Drawing.Point(4, 28);
            this.tapMain.Name = "tapMain";
            this.tapMain.Padding = new System.Windows.Forms.Padding(3);
            this.tapMain.Size = new System.Drawing.Size(996, 480);
            this.tapMain.TabIndex = 0;
            this.tapMain.Text = "main";
            this.tapMain.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(307, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tapAddStudent
            // 
            this.tapAddStudent.Controls.Add(this.nuAge);
            this.tapAddStudent.Controls.Add(this.button1);
            this.tapAddStudent.Controls.Add(this.groupBox2);
            this.tapAddStudent.Controls.Add(this.groupBox1);
            this.tapAddStudent.Controls.Add(this.lblGender);
            this.tapAddStudent.Controls.Add(this.lblSpeclalization);
            this.tapAddStudent.Controls.Add(this.txtPhone);
            this.tapAddStudent.Controls.Add(this.txtEmail);
            this.tapAddStudent.Controls.Add(this.txtFullName);
            this.tapAddStudent.Controls.Add(this.txtID);
            this.tapAddStudent.Controls.Add(this.lblAge);
            this.tapAddStudent.Controls.Add(this.lblPhone);
            this.tapAddStudent.Controls.Add(this.lblEmail);
            this.tapAddStudent.Controls.Add(this.lblFullName);
            this.tapAddStudent.Controls.Add(this.lblID);
            this.tapAddStudent.Controls.Add(this.label1);
            this.tapAddStudent.Location = new System.Drawing.Point(4, 28);
            this.tapAddStudent.Name = "tapAddStudent";
            this.tapAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tapAddStudent.Size = new System.Drawing.Size(996, 480);
            this.tapAddStudent.TabIndex = 1;
            this.tapAddStudent.Text = "Add Student";
            this.tapAddStudent.UseVisualStyleBackColor = true;
            // 
            // nuAge
            // 
            this.nuAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuAge.Location = new System.Drawing.Point(173, 321);
            this.nuAge.Name = "nuAge";
            this.nuAge.Size = new System.Drawing.Size(228, 32);
            this.nuAge.TabIndex = 16;
            this.nuAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nuAge_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(42, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoFamle);
            this.groupBox2.Controls.Add(this.rdoMale);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(678, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 60);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // rdoFamle
            // 
            this.rdoFamle.AutoSize = true;
            this.rdoFamle.Location = new System.Drawing.Point(165, 26);
            this.rdoFamle.Name = "rdoFamle";
            this.rdoFamle.Size = new System.Drawing.Size(92, 28);
            this.rdoFamle.TabIndex = 17;
            this.rdoFamle.Text = "Famle";
            this.rdoFamle.UseVisualStyleBackColor = true;
            this.rdoFamle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdoFamle_KeyDown);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(16, 26);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(79, 28);
            this.rdoMale.TabIndex = 16;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            this.rdoMale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdoMale_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(678, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 61);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(165, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 28);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "Literary";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.DragEnter += new System.Windows.Forms.DragEventHandler(this.radioButton2_DragEnter);
            this.radioButton2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radioButton2_KeyDown);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Seicntific";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radioButton1_KeyDown);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Location = new System.Drawing.Point(554, 247);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(91, 24);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSpeclalization
            // 
            this.lblSpeclalization.AutoSize = true;
            this.lblSpeclalization.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSpeclalization.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSpeclalization.Location = new System.Drawing.Point(481, 99);
            this.lblSpeclalization.Name = "lblSpeclalization";
            this.lblSpeclalization.Size = new System.Drawing.Size(158, 24);
            this.lblSpeclalization.TabIndex = 11;
            this.lblSpeclalization.Text = "Speclalization:";
            this.lblSpeclalization.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPhone.Location = new System.Drawing.Point(177, 276);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(225, 32);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEmail.Location = new System.Drawing.Point(177, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 32);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFullName.Location = new System.Drawing.Point(177, 164);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(225, 32);
            this.txtFullName.TabIndex = 7;
            this.txtFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFullName_KeyDown);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtID.Location = new System.Drawing.Point(177, 110);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(225, 32);
            this.txtID.TabIndex = 6;
            this.txtID.Click += new System.EventHandler(this.txtID_Click);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAge.Location = new System.Drawing.Point(91, 316);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(56, 24);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age:";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAge.Click += new System.EventHandler(this.lblAge_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhone.Location = new System.Drawing.Point(63, 266);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(80, 24);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(71, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 24);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFullName.Location = new System.Drawing.Point(20, 154);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(118, 24);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblID.Location = new System.Drawing.Point(111, 100);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 24);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(294, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tapSeach
            // 
            this.tapSeach.Controls.Add(this.groupBox3);
            this.tapSeach.Controls.Add(this.button3);
            this.tapSeach.Controls.Add(this.txtStudentName);
            this.tapSeach.Controls.Add(this.label4);
            this.tapSeach.Controls.Add(this.lblSearch);
            this.tapSeach.Location = new System.Drawing.Point(4, 28);
            this.tapSeach.Name = "tapSeach";
            this.tapSeach.Size = new System.Drawing.Size(996, 480);
            this.tapSeach.TabIndex = 2;
            this.tapSeach.Text = "search";
            this.tapSeach.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.lblGenderInfo);
            this.groupBox3.Controls.Add(this.lblSpecInfo);
            this.groupBox3.Controls.Add(this.lblAgeInfo);
            this.groupBox3.Controls.Add(this.lblPhoneInfo);
            this.groupBox3.Controls.Add(this.lblEmailInfo);
            this.groupBox3.Controls.Add(this.lblFullNameInfo);
            this.groupBox3.Controls.Add(this.lblIDInfo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(553, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 404);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Info";
            // 
            // lblGenderInfo
            // 
            this.lblGenderInfo.AutoSize = true;
            this.lblGenderInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblGenderInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGenderInfo.Location = new System.Drawing.Point(237, 370);
            this.lblGenderInfo.Name = "lblGenderInfo";
            this.lblGenderInfo.Size = new System.Drawing.Size(0, 24);
            this.lblGenderInfo.TabIndex = 26;
            this.lblGenderInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGenderInfo.Click += new System.EventHandler(this.label18_Click);
            // 
            // lblSpecInfo
            // 
            this.lblSpecInfo.AutoSize = true;
            this.lblSpecInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSpecInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSpecInfo.Location = new System.Drawing.Point(237, 328);
            this.lblSpecInfo.Name = "lblSpecInfo";
            this.lblSpecInfo.Size = new System.Drawing.Size(0, 24);
            this.lblSpecInfo.TabIndex = 25;
            this.lblSpecInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAgeInfo
            // 
            this.lblAgeInfo.AutoSize = true;
            this.lblAgeInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAgeInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgeInfo.Location = new System.Drawing.Point(237, 295);
            this.lblAgeInfo.Name = "lblAgeInfo";
            this.lblAgeInfo.Size = new System.Drawing.Size(0, 24);
            this.lblAgeInfo.TabIndex = 24;
            this.lblAgeInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPhoneInfo
            // 
            this.lblPhoneInfo.AutoSize = true;
            this.lblPhoneInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPhoneInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhoneInfo.Location = new System.Drawing.Point(237, 260);
            this.lblPhoneInfo.Name = "lblPhoneInfo";
            this.lblPhoneInfo.Size = new System.Drawing.Size(0, 24);
            this.lblPhoneInfo.TabIndex = 23;
            this.lblPhoneInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmailInfo
            // 
            this.lblEmailInfo.AutoSize = true;
            this.lblEmailInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEmailInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmailInfo.Location = new System.Drawing.Point(237, 224);
            this.lblEmailInfo.Name = "lblEmailInfo";
            this.lblEmailInfo.Size = new System.Drawing.Size(0, 24);
            this.lblEmailInfo.TabIndex = 22;
            this.lblEmailInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFullNameInfo
            // 
            this.lblFullNameInfo.AutoSize = true;
            this.lblFullNameInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFullNameInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFullNameInfo.Location = new System.Drawing.Point(237, 186);
            this.lblFullNameInfo.Name = "lblFullNameInfo";
            this.lblFullNameInfo.Size = new System.Drawing.Size(0, 24);
            this.lblFullNameInfo.TabIndex = 21;
            this.lblFullNameInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIDInfo
            // 
            this.lblIDInfo.AutoSize = true;
            this.lblIDInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIDInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIDInfo.Location = new System.Drawing.Point(237, 142);
            this.lblIDInfo.Name = "lblIDInfo";
            this.lblIDInfo.Size = new System.Drawing.Size(0, 24);
            this.lblIDInfo.TabIndex = 20;
            this.lblIDInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(56, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Gender:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(107, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Age:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(12, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Speclalization:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(90, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phone:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(91, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(45, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Full Name:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(105, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(32, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 71);
            this.button3.TabIndex = 16;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtStudentName.Location = new System.Drawing.Point(170, 92);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(164, 32);
            this.txtStudentName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Student Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSearch.Location = new System.Drawing.Point(305, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(236, 72);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tapstudentList
            // 
            this.tapstudentList.Controls.Add(this.listView1);
            this.tapstudentList.Controls.Add(this.comboBox1);
            this.tapstudentList.Controls.Add(this.label3);
            this.tapstudentList.Controls.Add(this.label2);
            this.tapstudentList.Location = new System.Drawing.Point(4, 28);
            this.tapstudentList.Name = "tapstudentList";
            this.tapstudentList.Size = new System.Drawing.Size(996, 480);
            this.tapstudentList.TabIndex = 3;
            this.tapstudentList.Text = "student List";
            this.tapstudentList.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 149);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(993, 332);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 249;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Full Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 175;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone";
            this.columnHeader4.Width = 144;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Age";
            this.columnHeader5.Width = 61;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Speclalization";
            this.columnHeader6.Width = 106;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Gender";
            this.columnHeader7.Width = 120;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Detils",
            "Large Icon",
            "List",
            "Small Icon",
            "Tilt",
            "search"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox1.Items.AddRange(new object[] {
            "Detils",
            "Large Icon",
            "List",
            "Small Icon",
            "Tilt",
            "search"});
            this.comboBox1.Location = new System.Drawing.Point(117, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "View:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(247, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Managment_System.Properties.Resources.SchoolMaim;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(993, 482);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::School_Managment_System.Properties.Resources.FamlePNG;
            this.pictureBox2.Location = new System.Drawing.Point(301, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // TabsControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 508);
            this.Controls.Add(this.tabControl1);
            this.Name = "TabsControlForm";
            this.Text = "TabsControlForm";
            this.Load += new System.EventHandler(this.TabsControlForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tapMain.ResumeLayout(false);
            this.tapAddStudent.ResumeLayout(false);
            this.tapAddStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuAge)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tapSeach.ResumeLayout(false);
            this.tapSeach.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tapstudentList.ResumeLayout(false);
            this.tapstudentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tapMain;
        private System.Windows.Forms.TabPage tapAddStudent;
        private System.Windows.Forms.TabPage tapSeach;
        private System.Windows.Forms.TabPage tapstudentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSpeclalization;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoFamle;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nuAge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAgeInfo;
        private System.Windows.Forms.Label lblPhoneInfo;
        private System.Windows.Forms.Label lblEmailInfo;
        private System.Windows.Forms.Label lblFullNameInfo;
        private System.Windows.Forms.Label lblIDInfo;
        private System.Windows.Forms.Label lblGenderInfo;
        private System.Windows.Forms.Label lblSpecInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}