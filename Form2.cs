using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Without_Coach
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void UpdateLabel()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                // Open Form2
                Form form3 = new Form3();
                form3.Show();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                // Open Form1
                Form Form4 = new Form4();
                this.Hide();
                Form4.Show();
            }
            else if (comboBox2.SelectedIndex == 0 && comboBox1.SelectedIndex == 3)
            {
                
            }
            else
            {
               
                MessageBox.Show("Please select another item from the combobox","Erorr",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox2.Focus();
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox3.Focus();
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
       }
    }
    
}
