﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITUTCSQLSERVER
{
    public partial class student: Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String STUDENT_NAME = txtSTUDENTNAME.Text;
            String STUDENT_LASTNAME = txtSTUDENTLASTNAME.Text;
            String STUDENT_TEL = txtSTUDENTTELL.Text;
            Manager.InsertStudent(STUDENT_NAME, STUDENT_LASTNAME, STUDENT_TEL);
            MessageBox.Show("บันทึก", "แจ้งเตือน");
        }
    }
}
