﻿using System;
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

namespace DunwoodyStudentProfile
{
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void b_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 log = new Form1();
            log.Show();
        }
    }
}
