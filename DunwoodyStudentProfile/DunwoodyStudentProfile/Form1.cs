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

namespace DunwoodyStudentProfile
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroComboBox1.Items.Add("Instructor");
            metroComboBox1.Items.Add("Administrator");
            metroComboBox1.Items.Add("Others");
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_Login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DunwoodyStudentProfileDB; Integrated Security = True;");

            conn.Open();

            SqlCommand sqcmd = new SqlCommand("Select * from LoginDetails where UserName='" + txt_Username.Text + "' and Password='" + txt_Password.Text + "'", conn);

            SqlDataAdapter da = new SqlDataAdapter(sqcmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0) {

                if (metroComboBox1.SelectedItem == "Administrator")
                {
                    this.Hide();
                    Form2 wel = new Form2();
                    wel.Show();
                }
                else if (metroComboBox1.SelectedItem == "Instructor")
                {
                    this.Hide();
                    Form3 wel = new Form3();
                    wel.Show();
                }
                else if (metroComboBox1.SelectedItem == "Others")
                {
                    this.Hide();
                    Form4 wel = new Form4();
                    wel.Show();
                }
            }

            else{
                MessageBox.Show("Please Check your username and password");
            }

            conn.Close();
        }

        private void b_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
