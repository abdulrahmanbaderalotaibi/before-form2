namespace Without_Coach
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel3 = new Panel();
            textUserName = new TextBox();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            textpassowrd = new TextBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            Login = new Button();
            button3 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 530);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Yu Gothic UI Semilight", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(123, 310);
            label2.Name = "label2";
            label2.Size = new Size(177, 35);
            label2.TabIndex = 2;
            label2.Text = "Without Coach";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Yu Gothic UI Semilight", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 275);
            label1.Name = "label1";
            label1.Size = new Size(151, 35);
            label1.TabIndex = 1;
            label1.Text = "Welcome to ";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.the_original_photo_of_without_removebg_preview;
            pictureBox1.Location = new Point(3, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(410, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(textUserName);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 45);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // textUserName
            // 
            textUserName.BackColor = SystemColors.Control;
            textUserName.BorderStyle = BorderStyle.None;
            textUserName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUserName.Location = new Point(72, 9);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(363, 25);
            textUserName.TabIndex = 4;
            textUserName.Click += textBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.Controls.Add(textpassowrd);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(0, 225);
            panel4.Name = "panel4";
            panel4.Size = new Size(453, 45);
            panel4.TabIndex = 2;
            // 
            // textpassowrd
            // 
            textpassowrd.BorderStyle = BorderStyle.None;
            textpassowrd.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textpassowrd.Location = new Point(72, 9);
            textpassowrd.Name = "textpassowrd";
            textpassowrd.Size = new Size(363, 21);
            textpassowrd.TabIndex = 5;
            textpassowrd.UseSystemPasswordChar = true;
            textpassowrd.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Yu Gothic UI Semilight", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(251, 35);
            label3.TabIndex = 3;
            label3.Text = "Login to your account";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.Linen;
            Login.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.Location = new Point(6, 310);
            Login.Name = "Login";
            Login.Size = new Size(125, 44);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Linen;
            button3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(179, 310);
            button3.Name = "button3";
            button3.Size = new Size(174, 44);
            button3.TabIndex = 5;
            button3.Text = "Forget passowrd";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(Login);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 530);
            panel2.TabIndex = 1;
            panel2.Click += panel2_Click;
            panel2.Paint += panel2_Paint;
            panel2.DoubleClick += panel2_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Without Coach";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel3;
        private TextBox textUserName;
        private PictureBox pictureBox2;
        private Panel panel4;
        private TextBox textpassowrd;
        private PictureBox pictureBox3;
        private Label label3;
        private Button Login;
        private Button button3;
        private Panel panel2;
    }
}
