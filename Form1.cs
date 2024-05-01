namespace Without_Coach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String readtext = File.ReadAllText("user.txt");

            string[] split = readtext.Split("@");

            String User= split[0];
            String Passowrd = split[1];
            if (textUserName.Text == User && textpassowrd.Text == Passowrd)
            {
                Form Form2 = new Form2();
                this.Hide();
                Form2.Show();
            }
            else
                MessageBox.Show("The user name and passowrd incorect", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }
    }
}
