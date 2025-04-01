namespace umniabank
{
    partial class inscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(101, 186);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 1;
            label1.Text = "Nom d'utilisateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(101, 314);
            label2.Name = "label2";
            label2.Size = new Size(192, 32);
            label2.TabIndex = 2;
            label2.Text = "Mot De Passe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(98, 434);
            label3.Name = "label3";
            label3.Size = new Size(195, 32);
            label3.TabIndex = 3;
            label3.Text = "Confirmation";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 31);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 469);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 349);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(363, 31);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Font = new Font("Lucida Bright", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(163, 593);
            button1.Name = "button1";
            button1.Size = new Size(214, 56);
            button1.TabIndex = 9;
            button1.Text = "S'inscrire ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.DarkRed;
            checkBox1.Location = new Point(101, 545);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 31);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Admin";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.DarkRed;
            checkBox2.Location = new Point(371, 545);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(93, 31);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "User";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 118);
            panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.close_button_icon_3;
            pictureBox1.Location = new Point(539, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Lucida Bright", 11F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.DarkRed;
            linkLabel1.Location = new Point(115, 730);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(316, 24);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Vous avez déja un compte ? ";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.man;
            pictureBox2.Location = new Point(190, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // inscription
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 788);
            Controls.Add(linkLabel1);
            Controls.Add(panel2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inscription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "inscription";
            Load += inscription_Load_1;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
    }
}