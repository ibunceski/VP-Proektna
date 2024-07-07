namespace QuizApp
{
    partial class QuizForm
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.panelAnswers = new System.Windows.Forms.Panel();
            this.labelPoints = new System.Windows.Forms.Label();
            this.timerTimePassed = new System.Windows.Forms.Timer(this.components);
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(12, 31);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(0, 13);
            this.labelQuestion.TabIndex = 1;
            // 
            // panelAnswers
            // 
            this.panelAnswers.Location = new System.Drawing.Point(15, 57);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Size = new System.Drawing.Size(587, 192);
            this.panelAnswers.TabIndex = 5;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelPoints.Location = new System.Drawing.Point(642, 109);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(0, 31);
            this.labelPoints.TabIndex = 6;
            // 
            // timerTimePassed
            // 
            this.timerTimePassed.Interval = 1000;
            this.timerTimePassed.Tick += new System.EventHandler(this.timerTimePassed_Tick);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTimeLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTimeLeft.Location = new System.Drawing.Point(670, 31);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(168, 22);
            this.lblTimeLeft.TabIndex = 7;
            this.lblTimeLeft.Text = "Time passed: 00:00";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(911, 494);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.panelAnswers);
            this.Controls.Add(this.labelQuestion);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Panel panelAnswers;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Timer timerTimePassed;
        private System.Windows.Forms.Label lblTimeLeft;
    }
}