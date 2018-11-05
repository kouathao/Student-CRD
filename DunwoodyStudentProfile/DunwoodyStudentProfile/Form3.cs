using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Data.SqlClient;
using System.IO;

namespace DunwoodyStudentProfile
{
    public partial class Form3 : MetroForm
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DunwoodyStudentProfileDB;Integrated Security=True;");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dunwoodyStudentProfileDBDataSet3.Profile' table. You can move, or remove it, as needed.
            this.profileTableAdapter1.Fill(this.dunwoodyStudentProfileDBDataSet3.Profile);
            // TODO: This line of code loads data into the 'dunwoodyStudentProfileDBDataSet2.Profile' table. You can move, or remove it, as needed.
            this.profileTableAdapter.Fill(this.dunwoodyStudentProfileDBDataSet2.Profile);
            // TODO: This line of code loads data into the 'dunwoodyStudentProfileDBDataSet1.Profile' table. You can move, or remove it, as needed.
            //this.profileTableAdapter1.Fill(this.dunwoodyStudentProfileDBDataSet1.Profile);
            // TODO: This line of code loads data into the 'dunwoodyStudentProfileDBDataSet.Profile' table. You can move, or remove it, as needed.
            //this.profileTableAdapter.Fill(this.dunwoodyStudentProfileDBDataSet.Profile);
            FormLoadWidgets();
            this.StyleManager = msmMain;
        }

        string imgLoc = "";
        string existingImgLoc = "";
        SqlCommand cmd;

        string mode = "";

        public void display_data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From [Profile]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGrid_DispRep.DataSource = dta;
            conn.Close();
        }
        public void FormLoadWidgets()
        {
            txt_StudentName.Text = "";
            txt_CourseName.Text = "";
            pictureBox1.Image = null;

            txt_StudentName.Enabled = true;
            txt_CourseName.Enabled = false;

            b_Show.Show();
            b_AddNew.Show();
            b_Delete.Hide(); //Hide for instructor mode
            b_Edit.Hide(); //Hide for instructor mode
            pictureBox1.Show();

            b_Show.Enabled = true;
            b_AddNew.Enabled = true;

            b_ImgUpload.Enabled = false;
            b_Delete.Enabled = false;
            b_Edit.Enabled = false;

            b_Save.Hide();
            b_Cancel.Show();

            mode = ""; //reset mode
            imgLoc = ""; //reset image location
        }
        private void b_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 log = new Form1();
            log.Show();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void b_Show_Click(object sender, EventArgs e)
        {
            if (txt_StudentName.Text == "")
            {
                MessageBox.Show("Enter valid Student Name");
                FormLoadWidgets();
                return;
            }

            else
            {
                b_Save.Enabled = false;

                string showQuery = "SELECT * From Profile Where StudentName='" + txt_StudentName.Text + "'";
                conn.Open();
                cmd = new SqlCommand(showQuery, conn);

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();


                        if (reader.HasRows)
                        {
                            // populate the Name Field
                            txt_CourseName.Text = reader[1].ToString();

                            // load the image
                            byte[] img = (byte[])(reader[2]);

                            if (img == null)
                            {
                                pictureBox1.Image = null;
                            }

                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                pictureBox1.Image = Image.FromStream(ms);
                            }

                            existingImgLoc = reader[3].ToString();

                            b_Delete.Hide();
                            b_Edit.Hide();
                        }

                        else
                        {
                            MessageBox.Show("This Student Name does not exist");
                            conn.Close();
                            FormLoadWidgets();
                            return;

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }

            conn.Close();

            txt_CourseName.Enabled = false;
            b_ImgUpload.Enabled = false;
            b_Delete.Enabled = true;
            b_Edit.Enabled = true;
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            if (mode == "AddNew")
            {


                try
                {
                    byte[] myImage = null;
                    conn.Open();


                    if (txt_StudentName.Text == "" || txt_CourseName.Text == "")
                    {
                        MessageBox.Show("Please enter vaild Student name and Course Name");
                        conn.Close();
                        return;
                    }

                    string showQuery = "SELECT StudentName FROM Profile WHERE StudentName='" + txt_StudentName.Text + "'";
                    cmd = new SqlCommand(showQuery, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Student Name already exist");
                            conn.Close();
                            return;
                        }
                    }

                    if (imgLoc.Equals(""))
                    {
                        MessageBox.Show("Please select an image to add");
                        conn.Close();
                        return;
                    }

                    else
                    {
                        FileStream fStream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fStream);
                        myImage = br.ReadBytes((int)fStream.Length);

                        string imgInsertQuery = "Insert into Profile(StudentName,CourseName,Image,ImageLoc)Values('" + txt_StudentName.Text + "','" + txt_CourseName.Text + "',@myImage, '" + imgLoc + "')";

                        cmd = new SqlCommand(imgInsertQuery, conn);
                        cmd.Parameters.Add(new SqlParameter("@myImage", myImage));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully.");
                        conn.Close();
                        FormLoadWidgets();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }

            else if (mode == "Edit")
            {
                try
                {
                    byte[] myNewImage = null;
                    conn.Open();

                    if (txt_StudentName.Text == "" || txt_CourseName.Text == "")
                    {
                        MessageBox.Show("Please Enter vaild Course Name");
                    }

                    else if (imgLoc.Length > 0)
                    {
                        FileStream fStream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fStream);
                        myNewImage = br.ReadBytes((int)fStream.Length);

                        string updateQuery = "UPDATE Profile SET CourseName = '" + txt_CourseName.Text + "',Image = @myNewImage, ImageLoc = '" + imgLoc + "' WHERE StudentName = '" + txt_StudentName + "'";
                        cmd = new SqlCommand(updateQuery, conn);

                        cmd.Parameters.Add(new SqlParameter("@myNewImage", myNewImage));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully.");
                        FormLoadWidgets();
                    }

                    else
                    {
                        string updateQuery = "Update Profile SET CourseName = '" + txt_CourseName.Text + "' WHERE StudentName = '" + txt_StudentName.Text + "'";
                        cmd = new SqlCommand(updateQuery, conn);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully.");
                        FormLoadWidgets();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    FormLoadWidgets();
                }
                conn.Close();
            }

            else
            {
                FormLoadWidgets();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void b_Delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string DeleteQuery = "delete from [Profile] where StudentName='" + txt_StudentName.Text + "'";
            cmd = new SqlCommand(DeleteQuery, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Deleted successfully");

            FormLoadWidgets();
            conn.Close();
        }

        private void b_Edit_Click_1(object sender, EventArgs e)
        {
            b_Show.Enabled = false;
            b_Show.Hide();
            b_AddNew.Hide();
            b_Delete.Hide();
            b_Edit.Hide();

            b_Save.Show();
            b_Save.Enabled = true;

            b_Cancel.Show();
            b_Cancel.Enabled = true;

            b_AddNew.Enabled = false;
            b_Delete.Enabled = false;

            b_ImgUpload.Enabled = true;

            txt_StudentName.Enabled = true;
            txt_CourseName.Enabled = true;

            mode = "Edit";
        }



        private void b_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 log = new Form1();
            log.Show();
        }

        private void b_Search_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            string search = txt_Search.Text;
            SqlCommand sqcmd = new SqlCommand("Select * from [Profile] where StudentName like '%" + search + "%' OR CourseName Like '%" + search + "%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGrid_DispRep.DataSource = dt;
                conn.Close();
            }

            else
            {
                MessageBox.Show("No record found");
                conn.Close();
            }
        }

        private void b_Save_Click_1(object sender, EventArgs e)
        {
            if (mode == "AddNew")
            {


                try
                {
                    byte[] myImage = null;
                    conn.Open();


                    if (txt_StudentName.Text == "" || txt_CourseName.Text == "")
                    {
                        MessageBox.Show("Please enter vaild Student name and Course Name");
                        conn.Close();
                        return;
                    }

                    string showQuery = "SELECT StudentName FROM Profile WHERE StudentName='" + txt_StudentName.Text + "'";
                    cmd = new SqlCommand(showQuery, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Student Name already exist");
                            conn.Close();
                            return;
                        }
                    }

                    if (imgLoc.Equals(""))
                    {
                        MessageBox.Show("Please select an image to add");
                        conn.Close();
                        return;
                    }

                    else
                    {
                        FileStream fStream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fStream);
                        myImage = br.ReadBytes((int)fStream.Length);

                        string imgInsertQuery = "Insert into Profile(StudentName,CourseName,Image,ImageLoc)Values('" + txt_StudentName.Text + "','" + txt_CourseName.Text + "',@myImage, '" + imgLoc + "')";

                        cmd = new SqlCommand(imgInsertQuery, conn);
                        cmd.Parameters.Add(new SqlParameter("@myImage", myImage));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully.");
                        conn.Close();
                        FormLoadWidgets();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }

            else if (mode == "Edit")
            {
                try
                {
                    byte[] myNewImage = null;
                    conn.Open();

                    if (txt_StudentName.Text == "" || txt_CourseName.Text == "")
                    {
                        MessageBox.Show("Please Enter vaild Course Name");
                    }

                    else if (imgLoc.Length > 0)
                    {
                        FileStream fStream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fStream);
                        myNewImage = br.ReadBytes((int)fStream.Length);

                        string updateQuery = "UPDATE Profile SET CourseName = '" + txt_CourseName.Text + "',Image = @myNewImage, ImageLoc = '" + imgLoc + "' WHERE StudentName = '" + txt_StudentName + "'";
                        cmd = new SqlCommand(updateQuery, conn);

                        cmd.Parameters.Add(new SqlParameter("@myNewImage", myNewImage));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully.");
                        FormLoadWidgets();
                    }

                    else
                    {
                        string updateQuery = "Update Profile SET CourseName = '" + txt_CourseName.Text + "' WHERE StudentName = '" + txt_StudentName.Text + "'";
                        cmd = new SqlCommand(updateQuery, conn);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully.");
                        FormLoadWidgets();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    FormLoadWidgets();
                }
                conn.Close();
            }

            else
            {
                FormLoadWidgets();
            }
        }

        private void b_Edit_Click(object sender, EventArgs e)
        {
            b_Show.Enabled = false;
            b_Show.Hide();
            b_AddNew.Hide();
            b_Delete.Hide();
            b_Edit.Hide();

            b_Save.Show();
            b_Save.Enabled = true;

            b_Cancel.Show();
            b_Cancel.Enabled = true;

            b_AddNew.Enabled = false;
            b_Delete.Enabled = false;

            b_ImgUpload.Enabled = true;

            txt_StudentName.Enabled = true;
            txt_CourseName.Enabled = true;

            mode = "Edit";
        }

        private void b_Delete_Click_1(object sender, EventArgs e)
        {

        }

        private void b_Cancel_Click_1(object sender, EventArgs e)
        {
            txt_StudentName.Text = "";
            txt_CourseName.Text = "";
            FormLoadWidgets();
        }

        private void b_DisplayAll_Click_1(object sender, EventArgs e)
        {
            display_data();
        }

        private void b_ImgUpload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog();

            fileSelect.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            fileSelect.Title = "Select Picture";

            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                imgLoc = fileSelect.FileName.ToString();
                pictureBox1.ImageLocation = imgLoc;
            }
        }

        private void dataGrid_DispRep_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int myindex = e.RowIndex;
            DataGridViewRow row = dataGrid_DispRep.Rows[myindex];

            string value1 = row.Cells[0].Value.ToString();
            string value2 = row.Cells[1].Value.ToString();

            txt_StudentName.Text = value1;
            txt_CourseName.Text = value2;

        }

        private void b_AddNew_Click_1(object sender, EventArgs e)
        {
            b_Show.Enabled = false;
            b_Show.Hide();
            b_AddNew.Hide();
            b_Delete.Hide();
            b_Edit.Hide();

            b_Save.Show();
            b_Save.Enabled = true;

            b_Cancel.Show();
            b_Cancel.Enabled = true;

            b_AddNew.Enabled = false;
            b_Delete.Enabled = false;

            b_ImgUpload.Enabled = true;

            txt_CourseName.Enabled = true;
            txt_StudentName.Text = "";
            txt_CourseName.Text = "";

            pictureBox1.Image = null;

            mode = "AddNew";
        }
    }
}
