using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proejkt_BD.Control.Baza;

namespace Proejkt_BD.Control.Menager
{
    public partial class Vehicle : UserControl
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            var result = SQLmanager.SearchObjects(textBox4.Text.ToString(), textBox3.Text.ToString(), textBox2.Text.ToString());
            dataGridView1.DataSource = result;
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            var result = SQLmanager.SearchObjects("","","");
            dataGridView1.DataSource = result;
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            AddVehicle a1 = new AddVehicle(false,0);
            a1.ShowDialog();
            var result = SQLmanager.SearchObjects("", "", "");
            dataGridView1.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nr_object = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            //var obj = SQLmanager.GetSingleObjectFull(nr_object);
            
            VehicleDetails a1 = new VehicleDetails();
            a1.textBox6.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString(); //reg            
            a1.textBox10.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(); //name
            a1.textBox9.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString(); //obj type
            

            var client = SQLmanager.SearchCustomerFromID(this.dataGridView1.CurrentRow.Cells[2].Value.ToString()); //client id
            
            a1.textBox5.Text = client.First().id_client.ToString(); //client id
            a1.textBox1.Text = client.First().first_name; //fname
            a1.textBox2.Text = client.First().last_name; //lname
            a1.textBox3.Text = client.First().name; ; //name
            a1.textBox4.Text = client.First().tel; ; //tel

            var obj_type = SQLmanager.SearchObjType(this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
            a1.textBox8.Text = obj_type.First().name; //obj_type name

            a1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
