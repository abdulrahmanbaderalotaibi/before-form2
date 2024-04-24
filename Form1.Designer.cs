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
            panel2 = new Panel();
            button2 = new Button();
            label3 = new Label();
            panel4 = new Panel();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 530);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Linen;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(28, 325);
            button2.Name = "button2";
            button2.Size = new Size(125, 44);
            button2.TabIndex = 4;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(0, 225);
            panel4.Name = "panel4";
            panel4.Size = new Size(453, 45);
            panel4.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(72, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 28);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 45);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(72, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 32);
            textBox1.TabIndex = 4;
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
            Text = "Without Coach";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
    }
}
