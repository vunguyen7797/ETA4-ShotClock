namespace BacketBall
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sc_gr_pause_btt = new System.Windows.Forms.Button();
            this.sc_gr_reset_btt = new System.Windows.Forms.Button();
            this.reset_14s_btt = new System.Windows.Forms.Button();
            this.sc_gr_start_btt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sc_gr_dec_btt = new System.Windows.Forms.Button();
            this.sc_gr_plus_btt = new System.Windows.Forms.Button();
            this.shot_time_lb = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.show_btt = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Count_Time = new System.Windows.Forms.Timer(this.components);
            this.Count_Shot_time = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(958, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control Panel";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(8, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(947, 547);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.sc_gr_pause_btt);
            this.groupBox1.Controls.Add(this.sc_gr_reset_btt);
            this.groupBox1.Controls.Add(this.reset_14s_btt);
            this.groupBox1.Controls.Add(this.sc_gr_start_btt);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.shot_time_lb);
            this.groupBox1.Location = new System.Drawing.Point(20, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(895, 499);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SHOT CLOCK CONTROL PANEL";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 399);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(363, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Horn (Tạm dừng)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 450);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Horn (Hết hiệp)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sc_gr_pause_btt
            // 
            this.sc_gr_pause_btt.Location = new System.Drawing.Point(377, 150);
            this.sc_gr_pause_btt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sc_gr_pause_btt.Name = "sc_gr_pause_btt";
            this.sc_gr_pause_btt.Size = new System.Drawing.Size(200, 85);
            this.sc_gr_pause_btt.TabIndex = 7;
            this.sc_gr_pause_btt.Text = "PAUSE";
            this.sc_gr_pause_btt.UseVisualStyleBackColor = true;
            this.sc_gr_pause_btt.Click += new System.EventHandler(this.sc_gr_pause_btt_Click_1);
            // 
            // sc_gr_reset_btt
            // 
            this.sc_gr_reset_btt.Location = new System.Drawing.Point(638, 150);
            this.sc_gr_reset_btt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sc_gr_reset_btt.Name = "sc_gr_reset_btt";
            this.sc_gr_reset_btt.Size = new System.Drawing.Size(230, 85);
            this.sc_gr_reset_btt.TabIndex = 6;
            this.sc_gr_reset_btt.Text = "RESET 24S";
            this.sc_gr_reset_btt.UseVisualStyleBackColor = true;
            this.sc_gr_reset_btt.Click += new System.EventHandler(this.sc_gr_reset_btt_Click_1);
            // 
            // reset_14s_btt
            // 
            this.reset_14s_btt.Location = new System.Drawing.Point(638, 30);
            this.reset_14s_btt.Name = "reset_14s_btt";
            this.reset_14s_btt.Size = new System.Drawing.Size(230, 85);
            this.reset_14s_btt.TabIndex = 5;
            this.reset_14s_btt.Text = "Reset 14s";
            this.reset_14s_btt.UseVisualStyleBackColor = true;
            this.reset_14s_btt.Click += new System.EventHandler(this.reset_14s_btt_Click);
            // 
            // sc_gr_start_btt
            // 
            this.sc_gr_start_btt.Location = new System.Drawing.Point(377, 30);
            this.sc_gr_start_btt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sc_gr_start_btt.Name = "sc_gr_start_btt";
            this.sc_gr_start_btt.Size = new System.Drawing.Size(200, 85);
            this.sc_gr_start_btt.TabIndex = 4;
            this.sc_gr_start_btt.Text = "Start";
            this.sc_gr_start_btt.UseVisualStyleBackColor = true;
            this.sc_gr_start_btt.Click += new System.EventHandler(this.sc_gr_start_btt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sc_gr_dec_btt);
            this.groupBox2.Controls.Add(this.sc_gr_plus_btt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(496, 282);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(202, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Edit";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // sc_gr_dec_btt
            // 
            this.sc_gr_dec_btt.Location = new System.Drawing.Point(109, 27);
            this.sc_gr_dec_btt.Margin = new System.Windows.Forms.Padding(4);
            this.sc_gr_dec_btt.Name = "sc_gr_dec_btt";
            this.sc_gr_dec_btt.Size = new System.Drawing.Size(62, 64);
            this.sc_gr_dec_btt.TabIndex = 1;
            this.sc_gr_dec_btt.Text = "-";
            this.sc_gr_dec_btt.UseVisualStyleBackColor = true;
            this.sc_gr_dec_btt.Click += new System.EventHandler(this.sc_gr_dec_btt_Click);
            // 
            // sc_gr_plus_btt
            // 
            this.sc_gr_plus_btt.Location = new System.Drawing.Point(31, 27);
            this.sc_gr_plus_btt.Margin = new System.Windows.Forms.Padding(4);
            this.sc_gr_plus_btt.Name = "sc_gr_plus_btt";
            this.sc_gr_plus_btt.Size = new System.Drawing.Size(59, 64);
            this.sc_gr_plus_btt.TabIndex = 0;
            this.sc_gr_plus_btt.Text = "+";
            this.sc_gr_plus_btt.UseVisualStyleBackColor = true;
            this.sc_gr_plus_btt.Click += new System.EventHandler(this.sc_gr_plus_btt_Click);
            // 
            // shot_time_lb
            // 
            this.shot_time_lb.AutoSize = true;
            this.shot_time_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shot_time_lb.Location = new System.Drawing.Point(32, 133);
            this.shot_time_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shot_time_lb.Name = "shot_time_lb";
            this.shot_time_lb.Size = new System.Drawing.Size(317, 226);
            this.shot_time_lb.TabIndex = 0;
            this.shot_time_lb.Text = "24";
            this.shot_time_lb.Click += new System.EventHandler(this.shot_time_lb_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.show_btt);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(958, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // show_btt
            // 
            this.show_btt.Location = new System.Drawing.Point(24, 30);
            this.show_btt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.show_btt.Name = "show_btt";
            this.show_btt.Size = new System.Drawing.Size(237, 111);
            this.show_btt.TabIndex = 0;
            this.show_btt.Text = "SHOW SCREEN";
            this.show_btt.UseVisualStyleBackColor = true;
            this.show_btt.Click += new System.EventHandler(this.show_btt_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(958, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Help";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(958, 560);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(79, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(744, 51);
            this.label5.TabIndex = 4;
            this.label5.Text = "SCOREBOARD AND SHOT CLOCK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(690, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "BASKETBALL SCOREBOARD PACKAGE: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "VERSION 1.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "MARCH, 2017";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(76, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "COPYRIGHT 2017 BY NGUYEN DUC ANH VU";
            // 
            // Count_Time
            // 
            this.Count_Time.Interval = 1000;
            this.Count_Time.Tick += new System.EventHandler(this.Count_Time_Tick);
            // 
            // Count_Shot_time
            // 
            this.Count_Shot_time.Interval = 1000;
            this.Count_Shot_time.Tick += new System.EventHandler(this.Count_Shot_time_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(967, 603);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BASKETBALL SCOREBOARD - SHOT CLOCK (Version 1.0)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer Count_Time;
        private System.Windows.Forms.Timer Count_Shot_time;
        private System.Windows.Forms.Button show_btt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reset_14s_btt;
        private System.Windows.Forms.Button sc_gr_start_btt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sc_gr_dec_btt;
        private System.Windows.Forms.Button sc_gr_plus_btt;
        private System.Windows.Forms.Label shot_time_lb;
        private System.Windows.Forms.Button sc_gr_reset_btt;
        private System.Windows.Forms.Button sc_gr_pause_btt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

