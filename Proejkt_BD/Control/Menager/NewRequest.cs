﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proejkt_BD.Control.Menager
{
    public partial class NewRequest : Form
    {
        public NewRequest()
        {
            InitializeComponent();
         
        }

        public void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewRequest2 a1 = new NewRequest2();
            a1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer a1 = new AddCustomer();
            a1.ShowDialog();
        }
    }
}
