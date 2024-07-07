namespace QuizApp
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.titleLbl = new System.Windows.Forms.Label();
            this.trackBarQuestions = new System.Windows.Forms.TrackBar();
            this.labelNumQuestions = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUsername = new System.Windows.Forms.Button();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gBoxUsername = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbLeaderboard = new System.Windows.Forms.PictureBox();
            this.pbMixed = new System.Windows.Forms.PictureBox();
            this.pbLinux = new System.Windows.Forms.PictureBox();
            this.pbDevOps = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuestions)).BeginInit();
            this.gBoxUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMixed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevOps)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLbl.Location = new System.Drawing.Point(131, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(406, 31);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Choose the category for the quiz";
            // 
            // trackBarQuestions
            // 
            this.trackBarQuestions.Location = new System.Drawing.Point(300, 342);
            this.trackBarQuestions.Maximum = 15;
            this.trackBarQuestions.Minimum = 5;
            this.trackBarQuestions.Name = "trackBarQuestions";
            this.trackBarQuestions.Size = new System.Drawing.Size(104, 45);
            this.trackBarQuestions.TabIndex = 14;
            this.trackBarQuestions.Value = 5;
            this.trackBarQuestions.Scroll += new System.EventHandler(this.trackBarQuestions_Scroll);
            // 
            // labelNumQuestions
            // 
            this.labelNumQuestions.AutoSize = true;
            this.labelNumQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelNumQuestions.Location = new System.Drawing.Point(249, 425);
            this.labelNumQuestions.Name = "labelNumQuestions";
            this.labelNumQuestions.Size = new System.Drawing.Size(213, 25);
            this.labelNumQuestions.TabIndex = 15;
            this.labelNumQuestions.Text = "Number of questions: 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(522, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Leaderboard";
            // 
            // btnUsername
            // 
            this.btnUsername.Location = new System.Drawing.Point(6, 54);
            this.btnUsername.Name = "btnUsername";
            this.btnUsername.Size = new System.Drawing.Size(96, 23);
            this.btnUsername.TabIndex = 22;
            this.btnUsername.Text = "Submit username";
            this.btnUsername.UseVisualStyleBackColor = true;
            this.btnUsername.Click += new System.EventHandler(this.btnUsername_Click);
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxUsername.Location = new System.Drawing.Point(6, 28);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(188, 20);
            this.txtBoxUsername.TabIndex = 23;
            this.txtBoxUsername.Text = "Enter your username here";
            this.txtBoxUsername.Enter += new System.EventHandler(this.txtBoxUsername_Enter);
            this.txtBoxUsername.Leave += new System.EventHandler(this.txtBoxUsername_Leave);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUsername.Location = new System.Drawing.Point(6, 137);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(141, 17);
            this.lblUsername.TabIndex = 24;
            this.lblUsername.Text = "Your username: user";
            // 
            // gBoxUsername
            // 
            this.gBoxUsername.Controls.Add(this.txtBoxUsername);
            this.gBoxUsername.Controls.Add(this.lblUsername);
            this.gBoxUsername.Controls.Add(this.btnUsername);
            this.gBoxUsername.Location = new System.Drawing.Point(23, 325);
            this.gBoxUsername.Name = "gBoxUsername";
            this.gBoxUsername.Size = new System.Drawing.Size(200, 173);
            this.gBoxUsername.TabIndex = 25;
            this.gBoxUsername.TabStop = false;
            this.gBoxUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "15";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(59, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "DevOps quiz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(295, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Linux quiz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(470, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Mixed programming quiz";
            // 
            // pbLeaderboard
            // 
            this.pbLeaderboard.Image = ((System.Drawing.Image)(resources.GetObject("pbLeaderboard.Image")));
            this.pbLeaderboard.Location = new System.Drawing.Point(509, 332);
            this.pbLeaderboard.MinimumSize = new System.Drawing.Size(100, 100);
            this.pbLeaderboard.Name = "pbLeaderboard";
            this.pbLeaderboard.Size = new System.Drawing.Size(156, 136);
            this.pbLeaderboard.TabIndex = 12;
            this.pbLeaderboard.TabStop = false;
            this.pbLeaderboard.Click += new System.EventHandler(this.pbLeaderboard_Click);
            this.pbLeaderboard.MouseEnter += new System.EventHandler(this.pbLeaderboard_MouseEnter);
            this.pbLeaderboard.MouseLeave += new System.EventHandler(this.pbLeaderboard_MouseLeave);
            // 
            // pbMixed
            // 
            this.pbMixed.Image = ((System.Drawing.Image)(resources.GetObject("pbMixed.Image")));
            this.pbMixed.Location = new System.Drawing.Point(480, 58);
            this.pbMixed.Name = "pbMixed";
            this.pbMixed.Size = new System.Drawing.Size(200, 232);
            this.pbMixed.TabIndex = 11;
            this.pbMixed.TabStop = false;
            this.pbMixed.Click += new System.EventHandler(this.pbMixed_Click);
            this.pbMixed.MouseEnter += new System.EventHandler(this.pbMixed_MouseEnter);
            this.pbMixed.MouseLeave += new System.EventHandler(this.pbMixed_MouseLeave);
            // 
            // pbLinux
            // 
            this.pbLinux.Image = global::QuizApp.Properties.Resources.linux1;
            this.pbLinux.Location = new System.Drawing.Point(254, 58);
            this.pbLinux.Name = "pbLinux";
            this.pbLinux.Size = new System.Drawing.Size(200, 232);
            this.pbLinux.TabIndex = 8;
            this.pbLinux.TabStop = false;
            this.pbLinux.Click += new System.EventHandler(this.pbLinux_Click);
            this.pbLinux.MouseEnter += new System.EventHandler(this.pbLinux_MouseEnter);
            this.pbLinux.MouseLeave += new System.EventHandler(this.pbLinux_MouseLeave);
            // 
            // pbDevOps
            // 
            this.pbDevOps.Image = global::QuizApp.Properties.Resources.devops;
            this.pbDevOps.Location = new System.Drawing.Point(23, 58);
            this.pbDevOps.Name = "pbDevOps";
            this.pbDevOps.Size = new System.Drawing.Size(200, 232);
            this.pbDevOps.TabIndex = 3;
            this.pbDevOps.TabStop = false;
            this.pbDevOps.Click += new System.EventHandler(this.pbDevOps_Click);
            this.pbDevOps.MouseEnter += new System.EventHandler(this.pbDevOps_MouseEnter);
            this.pbDevOps.MouseLeave += new System.EventHandler(this.pbDevOps_MouseLeave);
            // 
            // MainMenu
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(700, 519);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBoxUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNumQuestions);
            this.Controls.Add(this.trackBarQuestions);
            this.Controls.Add(this.pbLeaderboard);
            this.Controls.Add(this.pbMixed);
            this.Controls.Add(this.pbLinux);
            this.Controls.Add(this.pbDevOps);
            this.Controls.Add(this.titleLbl);
            this.Name = "MainMenu";
            this.Text = "Quiz App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuestions)).EndInit();
            this.gBoxUsername.ResumeLayout(false);
            this.gBoxUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMixed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevOps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox pbLinux;
        private System.Windows.Forms.PictureBox pbMixed;
        private System.Windows.Forms.PictureBox pbLeaderboard;
        private System.Windows.Forms.TrackBar trackBarQuestions;
        private System.Windows.Forms.Label labelNumQuestions;
        private System.Windows.Forms.PictureBox pbDevOps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUsername;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox gBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
