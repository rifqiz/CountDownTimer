namespace CountDownTimer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetik = new System.Windows.Forms.TextBox();
            this.txtMenit = new System.Windows.Forms.TextBox();
            this.txtJam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrWaktu = new System.Windows.Forms.Timer(this.components);
            this.lblHr = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.buttonWarming = new System.Windows.Forms.Button();
            this.buttonMulai = new System.Windows.Forms.Button();
            this.buttonPemanggil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txtPesan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDetik);
            this.groupBox1.Controls.Add(this.txtMenit);
            this.groupBox1.Controls.Add(this.txtJam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(456, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atur Waktu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPesan
            // 
            this.txtPesan.Location = new System.Drawing.Point(78, 71);
            this.txtPesan.Name = "txtPesan";
            this.txtPesan.Size = new System.Drawing.Size(135, 21);
            this.txtPesan.TabIndex = 8;
            this.txtPesan.TextChanged += new System.EventHandler(this.txtPesan_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pesan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(183, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "detik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(133, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "menit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(95, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "jam";
            // 
            // txtDetik
            // 
            this.txtDetik.Location = new System.Drawing.Point(172, 24);
            this.txtDetik.Name = "txtDetik";
            this.txtDetik.Size = new System.Drawing.Size(41, 21);
            this.txtDetik.TabIndex = 3;
            this.txtDetik.TextChanged += new System.EventHandler(this.txtDetik_TextChanged);
            // 
            // txtMenit
            // 
            this.txtMenit.Location = new System.Drawing.Point(125, 24);
            this.txtMenit.Name = "txtMenit";
            this.txtMenit.Size = new System.Drawing.Size(41, 21);
            this.txtMenit.TabIndex = 2;
            // 
            // txtJam
            // 
            this.txtJam.Location = new System.Drawing.Point(78, 24);
            this.txtJam.Name = "txtJam";
            this.txtJam.Size = new System.Drawing.Size(41, 21);
            this.txtJam.TabIndex = 1;
            this.txtJam.TextChanged += new System.EventHandler(this.txtJam_TextChanged);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waktu";
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.Location = new System.Drawing.Point(426, 238);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(60, 60);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.Location = new System.Drawing.Point(314, 238);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(60, 60);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.Location = new System.Drawing.Point(200, 238);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 60);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrWaktu
            // 
            this.tmrWaktu.Interval = 1000;
            this.tmrWaktu.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHr.Image = ((System.Drawing.Image)(resources.GetObject("lblHr.Image")));
            this.lblHr.Location = new System.Drawing.Point(30, 17);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(80, 55);
            this.lblHr.TabIndex = 12;
            this.lblHr.Text = "00";
            this.lblHr.Click += new System.EventHandler(this.lblHr_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(116, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 55);
            this.label8.TabIndex = 13;
            this.label8.Text = ":";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMin.Image = ((System.Drawing.Image)(resources.GetObject("lblMin.Image")));
            this.lblMin.Location = new System.Drawing.Point(160, 17);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(80, 55);
            this.lblMin.TabIndex = 14;
            this.lblMin.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(246, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 55);
            this.label10.TabIndex = 15;
            this.label10.Text = ":";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSec.Image = ((System.Drawing.Image)(resources.GetObject("lblSec.Image")));
            this.lblSec.Location = new System.Drawing.Point(290, 17);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(80, 55);
            this.lblSec.TabIndex = 16;
            this.lblSec.Text = "00";
            this.lblSec.Click += new System.EventHandler(this.lblSec_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.lblSec);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblMin);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblHr);
            this.groupBox3.Location = new System.Drawing.Point(200, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(302, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 81);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(536, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(125, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tim A";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(299, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tim B";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(480, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tim C";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(653, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Tim D";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tim 1",
            "Tim 2",
            "Tim 3",
            "Tim 4",
            "Tim 5",
            "Tim 6",
            "Tim 7",
            "Tim 8",
            "Tim 9",
            "Tim 10"});
            this.comboBox1.Location = new System.Drawing.Point(72, 403);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tim 1",
            "Tim 2",
            "Tim 3",
            "Tim 4",
            "Tim 5",
            "Tim 6",
            "Tim 7",
            "Tim 8",
            "Tim 9",
            "Tim 10"});
            this.comboBox2.Location = new System.Drawing.Point(243, 403);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 21);
            this.comboBox2.TabIndex = 31;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Tim 1",
            "Tim 2",
            "Tim 3",
            "Tim 4",
            "Tim 5",
            "Tim 6",
            "Tim 7",
            "Tim 8",
            "Tim 9",
            "Tim 10"});
            this.comboBox3.Location = new System.Drawing.Point(424, 403);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(136, 21);
            this.comboBox3.TabIndex = 32;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Tim 1",
            "Tim 2",
            "Tim 3",
            "Tim 4",
            "Tim 5",
            "Tim 6",
            "Tim 7",
            "Tim 8",
            "Tim 9",
            "Tim 10"});
            this.comboBox4.Location = new System.Drawing.Point(600, 403);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(136, 21);
            this.comboBox4.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(654, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 129);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(238, 67);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // buttonA
            // 
            this.buttonA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonA.BackgroundImage")));
            this.buttonA.Location = new System.Drawing.Point(128, 328);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(30, 30);
            this.buttonA.TabIndex = 36;
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonB.BackgroundImage")));
            this.buttonB.Location = new System.Drawing.Point(300, 328);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(30, 30);
            this.buttonB.TabIndex = 37;
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonC.BackgroundImage")));
            this.buttonC.Location = new System.Drawing.Point(483, 328);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(30, 30);
            this.buttonC.TabIndex = 38;
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonD.BackgroundImage")));
            this.buttonD.Location = new System.Drawing.Point(654, 328);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(30, 30);
            this.buttonD.TabIndex = 39;
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelA.Location = new System.Drawing.Point(94, 376);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(96, 21);
            this.labelA.TabIndex = 40;
            this.labelA.Text = "00 : 00 : 00";
            this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelB.Location = new System.Drawing.Point(266, 376);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(96, 21);
            this.labelB.TabIndex = 41;
            this.labelB.Text = "00 : 00 : 00";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelC.Location = new System.Drawing.Point(448, 374);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(96, 21);
            this.labelC.TabIndex = 42;
            this.labelC.Text = "00 : 00 : 00";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelD.Location = new System.Drawing.Point(622, 375);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(96, 21);
            this.labelD.TabIndex = 43;
            this.labelD.Text = "00 : 00 : 00";
            // 
            // buttonWarming
            // 
            this.buttonWarming.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWarming.BackgroundImage")));
            this.buttonWarming.Location = new System.Drawing.Point(173, 461);
            this.buttonWarming.Name = "buttonWarming";
            this.buttonWarming.Size = new System.Drawing.Size(63, 60);
            this.buttonWarming.TabIndex = 44;
            this.buttonWarming.UseVisualStyleBackColor = true;
            this.buttonWarming.Click += new System.EventHandler(this.buttonWarming_Click);
            // 
            // buttonMulai
            // 
            this.buttonMulai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMulai.BackgroundImage")));
            this.buttonMulai.Location = new System.Drawing.Point(43, 461);
            this.buttonMulai.Name = "buttonMulai";
            this.buttonMulai.Size = new System.Drawing.Size(63, 60);
            this.buttonMulai.TabIndex = 45;
            this.buttonMulai.UseVisualStyleBackColor = true;
            this.buttonMulai.Click += new System.EventHandler(this.buttonMulai_Click);
            // 
            // buttonPemanggil
            // 
            this.buttonPemanggil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPemanggil.BackgroundImage")));
            this.buttonPemanggil.Location = new System.Drawing.Point(314, 461);
            this.buttonPemanggil.Name = "buttonPemanggil";
            this.buttonPemanggil.Size = new System.Drawing.Size(60, 60);
            this.buttonPemanggil.TabIndex = 46;
            this.buttonPemanggil.UseVisualStyleBackColor = true;
            this.buttonPemanggil.Click += new System.EventHandler(this.buttonPemanggil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonPemanggil);
            this.Controls.Add(this.buttonMulai);
            this.Controls.Add(this.buttonWarming);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer Line Follower TC 2016";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetik;
        private System.Windows.Forms.TextBox txtMenit;
        private System.Windows.Forms.TextBox txtJam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrWaktu;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Button buttonWarming;
        private System.Windows.Forms.Button buttonMulai;
        private System.Windows.Forms.Button buttonPemanggil;
    }
}

