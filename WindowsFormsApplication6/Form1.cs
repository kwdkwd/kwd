﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Test_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, " + DateTime.Now.ToString());
            MessageBox.Show("추가 메세지");
        }
    }
}
