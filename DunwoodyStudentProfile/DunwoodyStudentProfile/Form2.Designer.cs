namespace DunwoodyStudentProfile
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.b_Logout = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_StudentName = new MetroFramework.Controls.MetroTextBox();
            this.txt_CourseName = new MetroFramework.Controls.MetroTextBox();
            this.b_Show = new MetroFramework.Controls.MetroButton();
            this.b_AddNew = new MetroFramework.Controls.MetroButton();
            this.b_Delete = new MetroFramework.Controls.MetroButton();
            this.b_Save = new MetroFramework.Controls.MetroButton();
            this.b_Cancel = new MetroFramework.Controls.MetroButton();
            this.b_ImgUpload = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_Search = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.b_Search = new MetroFramework.Controls.MetroButton();
            this.dataGrid_DispRep = new System.Windows.Forms.DataGridView();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dunwoodyStudentProfileDBDataSet1 = new DunwoodyStudentProfile.DunwoodyStudentProfileDBDataSet1();
            this.b_DisplayAll = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_Edit = new MetroFramework.Controls.MetroButton();
            this.dunwoodyStudentProfileDBDataSet = new DunwoodyStudentProfile.DunwoodyStudentProfileDBDataSet();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileTableAdapter = new DunwoodyStudentProfile.DunwoodyStudentProfileDBDataSetTableAdapters.ProfileTableAdapter();
            this.profileTableAdapter1 = new DunwoodyStudentProfile.DunwoodyStudentProfileDBDataSet1TableAdapters.ProfileTableAdapter();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dunwoodyStudentProfileDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dunwoodyStudentProfileDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 826);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(368, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // b_Logout
            // 
            this.b_Logout.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b_Logout.Location = new System.Drawing.Point(1164, 902);
            this.b_Logout.Name = "b_Logout";
            this.b_Logout.Size = new System.Drawing.Size(143, 46);
            this.b_Logout.TabIndex = 9;
            this.b_Logout.Text = "Logout";
            this.b_Logout.UseSelectable = true;
            this.b_Logout.Click += new System.EventHandler(this.b_Exit_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(214, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(154, 25);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "STUDENT NAME:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(214, 251);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(143, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "COURSE NAME:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(287, 352);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 13;
            // 
            // txt_StudentName
            // 
            // 
            // 
            // 
            this.txt_StudentName.CustomButton.Image = null;
            this.txt_StudentName.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.txt_StudentName.CustomButton.Name = "";
            this.txt_StudentName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_StudentName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_StudentName.CustomButton.TabIndex = 1;
            this.txt_StudentName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_StudentName.CustomButton.UseSelectable = true;
            this.txt_StudentName.CustomButton.Visible = false;
            this.txt_StudentName.Lines = new string[0];
            this.txt_StudentName.Location = new System.Drawing.Point(456, 171);
            this.txt_StudentName.MaxLength = 32767;
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.PasswordChar = '\0';
            this.txt_StudentName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_StudentName.SelectedText = "";
            this.txt_StudentName.SelectionLength = 0;
            this.txt_StudentName.SelectionStart = 0;
            this.txt_StudentName.ShortcutsEnabled = true;
            this.txt_StudentName.Size = new System.Drawing.Size(322, 23);
            this.txt_StudentName.TabIndex = 14;
            this.txt_StudentName.UseSelectable = true;
            this.txt_StudentName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_StudentName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_CourseName
            // 
            // 
            // 
            // 
            this.txt_CourseName.CustomButton.Image = null;
            this.txt_CourseName.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.txt_CourseName.CustomButton.Name = "";
            this.txt_CourseName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_CourseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_CourseName.CustomButton.TabIndex = 1;
            this.txt_CourseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_CourseName.CustomButton.UseSelectable = true;
            this.txt_CourseName.CustomButton.Visible = false;
            this.txt_CourseName.Lines = new string[0];
            this.txt_CourseName.Location = new System.Drawing.Point(456, 253);
            this.txt_CourseName.MaxLength = 32767;
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.PasswordChar = '\0';
            this.txt_CourseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_CourseName.SelectedText = "";
            this.txt_CourseName.SelectionLength = 0;
            this.txt_CourseName.SelectionStart = 0;
            this.txt_CourseName.ShortcutsEnabled = true;
            this.txt_CourseName.Size = new System.Drawing.Size(322, 23);
            this.txt_CourseName.TabIndex = 15;
            this.txt_CourseName.UseSelectable = true;
            this.txt_CourseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_CourseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // b_Show
            // 
            this.b_Show.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b_Show.Location = new System.Drawing.Point(100, 393);
            this.b_Show.Name = "b_Show";
            this.b_Show.Size = new System.Drawing.Size(143, 46);
            this.b_Show.TabIndex = 16;
            this.b_Show.Text = "Show";
            this.b_Show.UseSelectable = true;
            this.b_Show.Click += new System.EventHandler(this.b_Show_Click);
            // 
            // b_AddNew
            // 
            this.b_AddNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b_AddNew.Location = new System.Drawing.Point(287, 393);
            this.b_AddNew.Name = "b_AddNew";
            this.b_AddNew.Size = new System.Drawing.Size(143, 46);
            this.b_AddNew.TabIndex = 17;
            this.b_AddNew.Text = "Add New";
            this.b_AddNew.UseSelectable = true;
            this.b_AddNew.Click += new System.EventHandler(this.b_AddNew_Click);
            // 
            // b_Delete
            // 
            this.b_Delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b_Delete.Location = new System.Drawing.Point(635, 393);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(143, 46);
            this.b_Delete.TabIndex = 18;
            this.b_Delete.Text = "Delete";
            this.b_Delete.UseSelectable = true;
            this.b_Delete.Click += new System.EventHandler(this.b_Delete_Click);
            // 
            // b_Save
            // 
            this.b_Save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b_Save.Location = new System.Drawing.Point(287, 393);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(143, 46);
            this.b_Save.TabIndex = 19;
            this.b_Save.Text = "Save";
            this.b_Save.UseSelectable = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b_Cancel.Location = new System.Drawing.Point(539, 393);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(143, 46);
            this.b_Cancel.TabIndex = 20;
            this.b_Cancel.Text = "Cancel";
            this.b_Cancel.UseSelectable = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // b_ImgUpload
            // 
            this.b_ImgUpload.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.b_ImgUpload.Location = new System.Drawing.Point(909, 393);
            this.b_ImgUpload.Name = "b_ImgUpload";
            this.b_ImgUpload.Size = new System.Drawing.Size(126, 46);
            this.b_ImgUpload.TabIndex = 21;
            this.b_ImgUpload.Text = "Add new photo...";
            this.b_ImgUpload.UseSelectable = true;
            this.b_ImgUpload.Click += new System.EventHandler(this.b_ImgUpload_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(528, 104);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(181, 25);
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Text = "Administrator User";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // txt_Search
            // 
            // 
            // 
            // 
            this.txt_Search.CustomButton.Image = null;
            this.txt_Search.CustomButton.Location = new System.Drawing.Point(419, 1);
            this.txt_Search.CustomButton.Name = "";
            this.txt_Search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Search.CustomButton.TabIndex = 1;
            this.txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Search.CustomButton.UseSelectable = true;
            this.txt_Search.CustomButton.Visible = false;
            this.txt_Search.Lines = new string[0];
            this.txt_Search.Location = new System.Drawing.Point(407, 518);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.ShortcutsEnabled = true;
            this.txt_Search.Size = new System.Drawing.Size(441, 23);
            this.txt_Search.TabIndex = 38;
            this.txt_Search.UseSelectable = true;
            this.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(358, 507);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // b_Search
            // 
            this.b_Search.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.b_Search.Location = new System.Drawing.Point(898, 495);
            this.b_Search.Name = "b_Search";
            this.b_Search.Size = new System.Drawing.Size(126, 46);
            this.b_Search.TabIndex = 40;
            this.b_Search.Text = "Search";
            this.b_Search.UseSelectable = true;
            this.b_Search.Click += new System.EventHandler(this.b_Search_Click);
            // 
            // dataGrid_DispRep
            // 
            this.dataGrid_DispRep.AutoGenerateColumns = false;
            this.dataGrid_DispRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_DispRep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dataGrid_DispRep.DataSource = this.profileBindingSource1;
            this.dataGrid_DispRep.Location = new System.Drawing.Point(438, 583);
            this.dataGrid_DispRep.Name = "dataGrid_DispRep";
            this.dataGrid_DispRep.RowTemplate.Height = 24;
            this.dataGrid_DispRep.Size = new System.Drawing.Size(326, 216);
            this.dataGrid_DispRep.TabIndex = 41;
            this.dataGrid_DispRep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_DispRep_CellContentClick);
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            // 
            // profileBindingSource1
            // 
            this.profileBindingSource1.DataMember = "Profile";
            this.profileBindingSource1.DataSource = this.dunwoodyStudentProfileDBDataSet1;
            // 
            // dunwoodyStudentProfileDBDataSet1
            // 
            this.dunwoodyStudentProfileDBDataSet1.DataSetName = "DunwoodyStudentProfileDBDataSet1";
            this.dunwoodyStudentProfileDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b_DisplayAll
            // 
            this.b_DisplayAll.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.b_DisplayAll.Location = new System.Drawing.Point(549, 845);
            this.b_DisplayAll.Name = "b_DisplayAll";
            this.b_DisplayAll.Size = new System.Drawing.Size(160, 46);
            this.b_DisplayAll.TabIndex = 42;
            this.b_DisplayAll.Text = "Display All Records";
            this.b_DisplayAll.UseSelectable = true;
            this.b_DisplayAll.Click += new System.EventHandler(this.b_DisplayAll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(857, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // b_Edit
            // 
            this.b_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_Edit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.b_Edit.Location = new System.Drawing.Point(470, 393);
            this.b_Edit.Name = "b_Edit";
            this.b_Edit.Size = new System.Drawing.Size(126, 46);
            this.b_Edit.TabIndex = 44;
            this.b_Edit.Text = "Edit";
            this.b_Edit.UseSelectable = true;
            this.b_Edit.Click += new System.EventHandler(this.b_Edit_Click_1);
            // 
            // dunwoodyStudentProfileDBDataSet
            // 
            this.dunwoodyStudentProfileDBDataSet.DataSetName = "DunwoodyStudentProfileDBDataSet";
            this.dunwoodyStudentProfileDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profileBindingSource
            // 
            this.profileBindingSource.DataMember = "Profile";
            this.profileBindingSource.DataSource = this.dunwoodyStudentProfileDBDataSet;
            // 
            // profileTableAdapter
            // 
            this.profileTableAdapter.ClearBeforeFill = true;
            // 
            // profileTableAdapter1
            // 
            this.profileTableAdapter1.ClearBeforeFill = true;
            // 
            // msmMain
            // 
            this.msmMain.Owner = null;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(857, 128);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(245, 224);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1372, 932);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.b_Edit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_DisplayAll);
            this.Controls.Add(this.dataGrid_DispRep);
            this.Controls.Add(this.b_Search);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.b_ImgUpload);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_AddNew);
            this.Controls.Add(this.b_Show);
            this.Controls.Add(this.txt_CourseName);
            this.Controls.Add(this.txt_StudentName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.b_Logout);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form2";
            this.Text = "Dunwoody Student Profile";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dunwoodyStudentProfileDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dunwoodyStudentProfileDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton b_Logout;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_StudentName;
        private MetroFramework.Controls.MetroTextBox txt_CourseName;
        private MetroFramework.Controls.MetroButton b_Show;
        private MetroFramework.Controls.MetroButton b_AddNew;
        private MetroFramework.Controls.MetroButton b_Delete;
        private MetroFramework.Controls.MetroButton b_Save;
        private MetroFramework.Controls.MetroButton b_Cancel;
        private MetroFramework.Controls.MetroButton b_ImgUpload;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_Search;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroButton b_Search;
        private System.Windows.Forms.DataGridView dataGrid_DispRep;
        private MetroFramework.Controls.MetroButton b_DisplayAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton b_Edit;
        private DunwoodyStudentProfileDBDataSet dunwoodyStudentProfileDBDataSet;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private DunwoodyStudentProfileDBDataSetTableAdapters.ProfileTableAdapter profileTableAdapter;
        private DunwoodyStudentProfileDBDataSet1 dunwoodyStudentProfileDBDataSet1;
        private System.Windows.Forms.BindingSource profileBindingSource1;
        private DunwoodyStudentProfileDBDataSet1TableAdapters.ProfileTableAdapter profileTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}