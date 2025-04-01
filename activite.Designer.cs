namespace umniabank
{
    partial class activite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activite));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            act_txt = new TextBox();
            sens_combo = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            account = new Label();
            acc_txt = new TextBox();
            devise = new Label();
            libellé_compte = new Label();
            lib_txt = new TextBox();
            montant = new Label();
            mnt_txt = new TextBox();
            dv_combo = new ComboBox();
            evt_combo = new ComboBox();
            ajouter = new Button();
            supprimer = new Button();
            modifier = new Button();
            label6 = new Label();
            ref_txt = new TextBox();
            txtReference = new TextBox();
            label7 = new Label();
            recharge_button = new Button();
            Imp_btn = new Button();
            btnExport = new Button();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            dataGridView1 = new DataGridView();
            printPreviewDialog1 = new PrintPreviewDialog();
            ID_txt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.close_button_icon_3;
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.man;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox3);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.White;
            label5.Name = "label5";
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.back_button_logo_png_png_image_524315;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.DarkRed;
            label2.Name = "label2";
            // 
            // act_txt
            // 
            resources.ApplyResources(act_txt, "act_txt");
            act_txt.Name = "act_txt";
            act_txt.TextChanged += textBox1_TextChanged;
            // 
            // sens_combo
            // 
            sens_combo.FormattingEnabled = true;
            sens_combo.Items.AddRange(new object[] { resources.GetString("sens_combo.Items"), resources.GetString("sens_combo.Items1") });
            resources.ApplyResources(sens_combo, "sens_combo");
            sens_combo.Name = "sens_combo";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.DarkRed;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.DarkRed;
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // account
            // 
            resources.ApplyResources(account, "account");
            account.ForeColor = Color.DarkRed;
            account.Name = "account";
            // 
            // acc_txt
            // 
            resources.ApplyResources(acc_txt, "acc_txt");
            acc_txt.Name = "acc_txt";
            // 
            // devise
            // 
            resources.ApplyResources(devise, "devise");
            devise.ForeColor = Color.DarkRed;
            devise.Name = "devise";
            devise.Click += devise_Click;
            // 
            // libellé_compte
            // 
            resources.ApplyResources(libellé_compte, "libellé_compte");
            libellé_compte.ForeColor = Color.DarkRed;
            libellé_compte.Name = "libellé_compte";
            // 
            // lib_txt
            // 
            resources.ApplyResources(lib_txt, "lib_txt");
            lib_txt.Name = "lib_txt";
            // 
            // montant
            // 
            resources.ApplyResources(montant, "montant");
            montant.ForeColor = Color.DarkRed;
            montant.Name = "montant";
            montant.Click += montant_Click;
            // 
            // mnt_txt
            // 
            resources.ApplyResources(mnt_txt, "mnt_txt");
            mnt_txt.Name = "mnt_txt";
            mnt_txt.TextChanged += mnt_txt_TextChanged;
            // 
            // dv_combo
            // 
            dv_combo.FormattingEnabled = true;
            dv_combo.Items.AddRange(new object[] { resources.GetString("dv_combo.Items"), resources.GetString("dv_combo.Items1"), resources.GetString("dv_combo.Items2") });
            resources.ApplyResources(dv_combo, "dv_combo");
            dv_combo.Name = "dv_combo";
            dv_combo.SelectedIndexChanged += dv_combo_SelectedIndexChanged;
            // 
            // evt_combo
            // 
            evt_combo.FormattingEnabled = true;
            evt_combo.Items.AddRange(new object[] { resources.GetString("evt_combo.Items"), resources.GetString("evt_combo.Items1") });
            resources.ApplyResources(evt_combo, "evt_combo");
            evt_combo.Name = "evt_combo";
            evt_combo.SelectedIndexChanged += evt_combo_SelectedIndexChanged;
            // 
            // ajouter
            // 
            ajouter.BackColor = Color.DarkRed;
            ajouter.Cursor = Cursors.Hand;
            resources.ApplyResources(ajouter, "ajouter");
            ajouter.ForeColor = Color.White;
            ajouter.Name = "ajouter";
            ajouter.UseVisualStyleBackColor = false;
            ajouter.Click += button1_Click;
            // 
            // supprimer
            // 
            supprimer.AutoEllipsis = true;
            supprimer.BackColor = Color.DarkRed;
            supprimer.Cursor = Cursors.Hand;
            resources.ApplyResources(supprimer, "supprimer");
            supprimer.ForeColor = Color.White;
            supprimer.Name = "supprimer";
            supprimer.UseVisualStyleBackColor = false;
            supprimer.Click += supprimer_Click;
            // 
            // modifier
            // 
            modifier.BackColor = Color.DarkRed;
            modifier.Cursor = Cursors.Hand;
            resources.ApplyResources(modifier, "modifier");
            modifier.ForeColor = Color.White;
            modifier.Name = "modifier";
            modifier.UseVisualStyleBackColor = false;
            modifier.Click += modifier_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.DarkRed;
            label6.Name = "label6";
            label6.Click += label6_Click;
            // 
            // ref_txt
            // 
            resources.ApplyResources(ref_txt, "ref_txt");
            ref_txt.Name = "ref_txt";
            ref_txt.TextChanged += textBox2_TextChanged;
            // 
            // txtReference
            // 
            resources.ApplyResources(txtReference, "txtReference");
            txtReference.Name = "txtReference";
            txtReference.TextChanged += textBox1_TextChanged_1;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.DarkRed;
            label7.Name = "label7";
            // 
            // recharge_button
            // 
            recharge_button.BackColor = Color.Red;
            recharge_button.Cursor = Cursors.Hand;
            resources.ApplyResources(recharge_button, "recharge_button");
            recharge_button.ForeColor = Color.White;
            recharge_button.Name = "recharge_button";
            recharge_button.UseVisualStyleBackColor = false;
            recharge_button.Click += recharge_button_Click;
            // 
            // Imp_btn
            // 
            Imp_btn.BackColor = Color.DarkRed;
            Imp_btn.Cursor = Cursors.Hand;
            resources.ApplyResources(Imp_btn, "Imp_btn");
            Imp_btn.ForeColor = Color.White;
            Imp_btn.Name = "Imp_btn";
            Imp_btn.UseVisualStyleBackColor = false;
            Imp_btn.Click += Imp_btn_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.DarkRed;
            btnExport.Cursor = Cursors.Hand;
            resources.ApplyResources(btnExport, "btnExport");
            btnExport.ForeColor = Color.White;
            btnExport.Name = "btnExport";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = Properties.Resources.search_icon_png_23;
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkRed;
            dataGridViewCellStyle1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Font = new Font("Lucida Bright", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(printPreviewDialog1, "printPreviewDialog1");
            printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // ID_txt
            // 
            resources.ApplyResources(ID_txt, "ID_txt");
            ID_txt.Name = "ID_txt";
            ID_txt.ReadOnly = true;
            // 
            // activite
            // 
            AccessibleRole = AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.WhiteSmoke;
            Controls.Add(ID_txt);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Controls.Add(btnExport);
            Controls.Add(Imp_btn);
            Controls.Add(dataGridView1);
            Controls.Add(recharge_button);
            Controls.Add(label7);
            Controls.Add(txtReference);
            Controls.Add(ref_txt);
            Controls.Add(label6);
            Controls.Add(modifier);
            Controls.Add(supprimer);
            Controls.Add(ajouter);
            Controls.Add(evt_combo);
            Controls.Add(dv_combo);
            Controls.Add(mnt_txt);
            Controls.Add(montant);
            Controls.Add(lib_txt);
            Controls.Add(libellé_compte);
            Controls.Add(devise);
            Controls.Add(acc_txt);
            Controls.Add(account);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(sens_combo);
            Controls.Add(act_txt);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            KeyPreview = true;
            MinimizeBox = false;
            Name = "activite";
            ShowIcon = false;
            HelpButtonClicked += activite_HelpButtonClicked;
            Load += activite_Load;
            Leave += pictureBox2_Click;
            DpiChangedAfterParent += activite_DpiChangedAfterParent;
            StyleChanged += activite_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox act_txt;
        private Label label2;
        private Label label3;
        private ComboBox sens_combo;
        private Label label4;
        private TextBox acc_txt;
        private Label account;
        private Label libellé_compte;
        private Label devise;
        private TextBox mnt_txt;
        private Label montant;
        private TextBox lib_txt;
        private ComboBox dv_combo;
        private ComboBox evt_combo;
        private PictureBox pictureBox3;
        private Label label5;
        private Button ajouter;
        private Button modifier;
        private Button supprimer;
        private TextBox ref_txt;
        private Label label6;
        private TextBox txtReference;
        private Label label7;
        private Button recharge_button;
        private Button Imp_btn;
        private Button btnExport;
        private Button button1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridView dataGridView1;
        private PrintPreviewDialog printPreviewDialog1;
        private TextBox ID_txt;
    }
}