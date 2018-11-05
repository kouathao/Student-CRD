namespace DunwoodyStudentProfile
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.b_Edit = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_DisplayAll = new MetroFramework.Controls.MetroButton();
            this.dataGrid_DispRep = new System.Windows.Forms.DataGridView();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dunwoodyStudentProfileDBDataSet3 = new DunwoodyStudentProfile.DunwoodyStudentProfileDBDataSet3();
            this.b_Search = new MetroFramework.Controls.MetroButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_Search = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.b_ImgUpload = new MetroFramework.Controls.MetroButton();
            this.b_Cancel = new MetroFramework.Controls.MetroButton();
            this.b_Save = new MetroFramework.Controls.MetroButton();
            this.b_Delete = new MetroFramework.Controls.MetroButton();
            this.b_AddNew = new MetroFramework.Controls.MetroButton();
            this.b_Show = new MetroFramework.Controls.MetroButton();
            this.txt_CourseName = new MetroFramework.Controls.MetroTextBox();
            this.txt_StudentName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.b_Logout = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.dunwoodyStudentProfileDBDataSet2 = new DunwoodyStudentProfile.DunwoodyStudentProfileDBDataSet2();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileTableAdapter = new DunwoodyStudentProfile.DunwoodyStudentProfileDBDataSet2TableAdapters.ProfileTableAdapter();
            this.profileTableAdapter1 = new DunwoodyStudentProfile.DunwoodyStudentProfileDBDataSet3TableAdapters.ProfileTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dunwoodyStudentProfileDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dunwoodyStudentProfileDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // b_Edit
            // 
            this.b_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_Edit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.b_Edit.Location = new System.Drawing.Point(473, 374);
            this.b_Edit.Name = "b_Edit";
            this.b_Edit.Size = new System.Drawing.Size(126, 46);
            this.b_Edit.TabIndex = 65;
            this.b_Edit.Text = "Edit";
            this.b_Edit.UseSelectable = true;
            this.b_Edit.Click += new System.EventHandler(this.b_Edit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(849, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // b_DisplayAll
            // 
            this.b_DisplayAll.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.b_DisplayAll.Location = new System.Drawing.Point(549, 826);
            this.b_DisplayAll.Name = "b_DisplayAll";
            this.b_DisplayAll.Size = new System.Drawing.Size(160, 46);
            this.b_DisplayAll.TabIndex = 63;
            this.b_DisplayAll.Text = "Display All Records";
            this.b_DisplayAll.UseSelectable = true;
            this.b_DisplayAll.Click += new System.EventHandler(this.b_DisplayAll_Click_1);
            // 
            // dataGrid_DispRep
            // 
            this.dataGrid_DispRep.AutoGenerateColumns = false;
            this.dataGrid_DispRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_DispRep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dataGrid_DispRep.DataSource = this.profileBindingSource1;
            this.dataGrid_DispRep.Location = new System.Drawing.Point(440, 556);
            this.dataGrid_DispRep.Name = "dataGrid_DispRep";
            this.dataGrid_DispRep.RowTemplate.Height = 24;
            this.dataGrid_DispRep.Size = new System.Drawing.Size(326, 216);
            this.dataGrid_DispRep.TabIndex = 62;
            this.dataGrid_DispRep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_DispRep_CellContentClick_1);
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
            this.profileBindingSource1.DataSource = this.dunwoodyStudentProfileDBDataSet3;
            // 
            // dunwoodyStudentProfileDBDataSet3
            // 
            this.dunwoodyStudentProfileDBDataSet3.DataSetName = "DunwoodyStudentProfileDBDataSet3";
            this.dunwoodyStudentProfileDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b_Search
            // 
            this.b_Search.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.b_Search.Location = new System.Drawing.Point(898, 476);
            this.b_Search.Name = "b_Search";
            this.b_Search.Size = new System.Drawing.Size(126, 46);
            this.b_Search.TabIndex = 61;
            this.b_Search.Text = "Search";
            this.b_Search.UseSelectable = true;
            this.b_Search.Click += new System.EventHandler(this.b_Search_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(358, 488);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
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
            this.txt_Search.Location = new System.Drawing.Point(407, 499);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.ShortcutsEnabled = true;
            this.txt_Search.Size = new System.Drawing.Size(441, 23);
            this.txt_Search.TabIndex = 59;
            this.txt_Search.UseSelectable = true;
            this.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(528, 85);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(146, 25);
            this.metroLabel4.TabIndex = 58;
            this.metroLabel4.Text = "Instructor User";
            // 
            // b_ImgUpload
            // 
            this.b_ImgUpload.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.b_ImgUpload.Location = new System.Drawing.Point(909, 374);
            this.b_ImgUpload.Name = "b_ImgUpload";
            this.b_ImgUpload.Size = new System.Drawing.Size(126, 46);
            this.b_ImgUpload.TabIndex = 57;
            this.b_ImgUpload.Text = "Add new photo...";
            this.b_ImgUpload.UseSelectable = true;
            this.b_ImgUpload.Click += new System.EventHandler(this.b_ImgUpload_Click_1);
            // 
            // b_Cancel
            // 
            this.b_Cancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b_Cancel.Location = new System.Drawing.Point(658, 374);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(143, 46);
            this.b_Cancel.TabIndex = 56;
            this.b_Cancel.Text = "Cancel";
            this.b_Cancel.UseSelectable = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click_1);
            // 
            // b_Save
            // 
            this.b_Save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b_Save.Location = new System.Drawing.Point(456, 374);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(143, 46);
            this.b_Save.TabIndex = 55;
            this.b_Save.Text = "Save";
            this.b_Save.UseSelectable = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click_1);
            // 
            // b_Delete
            // 
            this.b_Delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b_Delete.Location = new System.Drawing.Point(1142, 365);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(143, 46);
            this.b_Delete.TabIndex = 54;
            this.b_Delete.Text = "Delete";
            this.b_Delete.UseSelectable = true;
            this.b_Delete.Click += new System.EventHandler(this.b_Delete_Click_1);
            // 
            // b_AddNew
            // 
            this.b_AddNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b_AddNew.Location = new System.Drawing.Point(456, 374);
            this.b_AddNew.Name = "b_AddNew";
            this.b_AddNew.Size = new System.Drawing.Size(143, 46);
            this.b_AddNew.TabIndex = 53;
            this.b_AddNew.Text = "Add New";
            this.b_AddNew.UseSelectable = true;
            this.b_AddNew.Click += new System.EventHandler(this.b_AddNew_Click_1);
            // 
            // b_Show
            // 
            this.b_Show.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b_Show.Location = new System.Drawing.Point(258, 374);
            this.b_Show.Name = "b_Show";
            this.b_Show.Size = new System.Drawing.Size(143, 46);
            this.b_Show.TabIndex = 52;
            this.b_Show.Text = "Show";
            this.b_Show.UseSelectable = true;
            this.b_Show.Click += new System.EventHandler(this.b_Show_Click);
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
            this.txt_CourseName.Location = new System.Drawing.Point(456, 234);
            this.txt_CourseName.MaxLength = 32767;
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.PasswordChar = '\0';
            this.txt_CourseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_CourseName.SelectedText = "";
            this.txt_CourseName.SelectionLength = 0;
            this.txt_CourseName.SelectionStart = 0;
            this.txt_CourseName.ShortcutsEnabled = true;
            this.txt_CourseName.Size = new System.Drawing.Size(322, 23);
            this.txt_CourseName.TabIndex = 51;
            this.txt_CourseName.UseSelectable = true;
            this.txt_CourseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_CourseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_StudentName.Location = new System.Drawing.Point(456, 152);
            this.txt_StudentName.MaxLength = 32767;
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.PasswordChar = '\0';
            this.txt_StudentName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_StudentName.SelectedText = "";
            this.txt_StudentName.SelectionLength = 0;
            this.txt_StudentName.SelectionStart = 0;
            this.txt_StudentName.ShortcutsEnabled = true;
            this.txt_StudentName.Size = new System.Drawing.Size(322, 23);
            this.txt_StudentName.TabIndex = 50;
            this.txt_StudentName.UseSelectable = true;
            this.txt_StudentName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_StudentName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(287, 333);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 49;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(214, 232);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(143, 25);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "COURSE NAME:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(214, 150);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(154, 25);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "STUDENT NAME:";
            // 
            // b_Logout
            // 
            this.b_Logout.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b_Logout.Location = new System.Drawing.Point(1164, 883);
            this.b_Logout.Name = "b_Logout";
            this.b_Logout.Size = new System.Drawing.Size(143, 46);
            this.b_Logout.TabIndex = 46;
            this.b_Logout.Text = "Logout";
            this.b_Logout.UseSelectable = true;
            this.b_Logout.Click += new System.EventHandler(this.b_Logout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 807);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(368, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // msmMain
            // 
            this.msmMain.Owner = null;
            // 
            // dunwoodyStudentProfileDBDataSet2
            // 
            this.dunwoodyStudentProfileDBDataSet2.DataSetName = "DunwoodyStudentProfileDBDataSet2";
            this.dunwoodyStudentProfileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profileBindingSource
            // 
            this.profileBindingSource.DataMember = "Profile";
            this.profileBindingSource.DataSource = this.dunwoodyStudentProfileDBDataSet2;
            // 
            // profileTableAdapter
            // 
            this.profileTableAdapter.ClearBeforeFill = true;
            // 
            // profileTableAdapter1
            // 
            this.profileTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1372, 932);
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
            this.Name = "Form3";
            this.Text = "Dunwoody Student Profile";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dunwoodyStudentProfileDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dunwoodyStudentProfileDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton b_Edit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton b_DisplayAll;
        private System.Windows.Forms.DataGridView dataGrid_DispRep;
        private MetroFramework.Controls.MetroButton b_Search;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroTextBox txt_Search;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton b_ImgUpload;
        private MetroFramework.Controls.MetroButton b_Cancel;
        private MetroFramework.Controls.MetroButton b_Save;
        private MetroFramework.Controls.MetroButton b_Delete;
        private MetroFramework.Controls.MetroButton b_AddNew;
        private MetroFramework.Controls.MetroButton b_Show;
        private MetroFramework.Controls.MetroTextBox txt_CourseName;
        private MetroFramework.Controls.MetroTextBox txt_StudentName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton b_Logout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private DunwoodyStudentProfileDBDataSet2 dunwoodyStudentProfileDBDataSet2;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private DunwoodyStudentProfileDBDataSet2TableAdapters.ProfileTableAdapter profileTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private DunwoodyStudentProfileDBDataSet3 dunwoodyStudentProfileDBDataSet3;
        private System.Windows.Forms.BindingSource profileBindingSource1;
        private DunwoodyStudentProfileDBDataSet3TableAdapters.ProfileTableAdapter profileTableAdapter1;
    }
}