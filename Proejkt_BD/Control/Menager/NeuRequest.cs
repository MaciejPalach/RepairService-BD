﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proejkt_BD.Control.Baza;

namespace Proejkt_BD.Control.Menager
{
    public partial class NeuRequest : Form
    {
        
        public NeuRequest(string id)
        {
            InitializeComponent();
            idTextBox.Text = "ID: " + id;

            //var man = Baza.SQLmanager.GetManagerName(id);
            //manNameBox.Text = man;

            Int32 requestId = Baza.SQLmanager.GetRequestId();
            requestIdBox1.Text = requestId.ToString();

            var result0 = Baza.SQLmanager.SearchCustomers("", "", "");
            dataGridView1.DataSource = result0;

            var result1 = Baza.SQLmanager.SearchObjects("", "", "");
            dataGridView2.DataSource = result1;
            this.dataGridView2.Columns["id_client"].Visible = false;
            //this.dataGridView2.Columns["obj_type"].Visible = false;
            this.dataGridView2.Columns["OBJ_TYPE1"].Visible = false;
            this.dataGridView2.Columns["CLIENT"].Visible = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var sc = new SearchCustomer();
            sc.ShowDialog();
            dataGridView1.DataSource = sc.GetClient();
            dataGridView2.DataSource = Baza.SQLmanager.GetCustomerObject(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sv = new SearchVehicle(this.dataGridView1.CurrentRow.Cells[0].Value);
            sv.ShowDialog();
            dataGridView2.DataSource = sv.GetVehicle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // string message = "Are you sure that you would like to close the form ? ";
            //DialogResult result = MessageBox.Show(message, MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
                Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var aa = new AddActivity(Int32.Parse(requestIdBox1.Text), dateTimePicker1.Value, dateTimePicker2.Value);
            aa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sa = new SearchActivity(requestIdBox1.Text);
            sa.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Baza.SQLmanager.FulfillRequestInformation(Int32.Parse(requestIdBox1.Text.ToString()), richTextBox1.Text.ToString(),
                "Active", " ", dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, 1, dataGridView2.Rows[0].Cells[0].Value.ToString());
            MessageBox.Show("The case has been created");
            Close();
        }
    }
}
