using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Without_Coach
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox7_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Format(object sender, ListControlConvertEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox3;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox3;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox3;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox3;
            label4.BackColor = Color.Transparent;
            label23.Parent = pictureBox3;
            label23.BackColor = Color.Transparent;
            label22.Parent = pictureBox3;
            label22.BackColor = Color.Transparent;
            label7.Parent = pictureBox3;
            label7.BackColor = Color.Transparent;
            label8.Parent = pictureBox3;
            label8.BackColor = Color.Transparent;
            label9.Parent = pictureBox3;
            label9.BackColor = Color.Transparent;
            label10.Parent = pictureBox3;
            label10.BackColor = Color.Transparent;
            label11.Parent = pictureBox3;
            label11.BackColor = Color.Transparent;
            label12.Parent = pictureBox3;
            label12.BackColor = Color.Transparent;
        }
    }
}
