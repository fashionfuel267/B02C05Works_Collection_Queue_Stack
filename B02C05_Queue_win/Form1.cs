using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B02C05_Queue_win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<Patient> patients = new Queue<Patient>();
        private void btnserial_Click(object sender, EventArgs e)
        {
            int c= patients.Count+1;
            var patient = new Patient
            {  Id = c,
                Name = this.txtName.Text
            };
            patients.Enqueue(patient);
            this.dataGridView1.DataSource= patients.ToList();
            this.txtName.Text = "";
            MessageBox.Show(patients.Count.ToString());

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (patients.Count > 0)
            {
                patients.Dequeue();
                this.dataGridView1.DataSource = patients.ToList();
            }
            else
            {
                MessageBox.Show("There are no patient in the queue");
            }
        }
    }
}
