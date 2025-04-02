namespace StopWatch
{
    partial class frmStopWatch
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
            components = new System.ComponentModel.Container();
            StopWatch = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            stSecond = new Label();
            stMinutes = new Label();
            stHours = new Label();
            Clock = new GroupBox();
            label4 = new Label();
            clSecond = new Label();
            label3 = new Label();
            clHours = new Label();
            clMinuts = new Label();
            btnStart = new Button();
            btnStop_Resum = new Button();
            btnClock = new Button();
            btnReset = new Button();
            btnSwap = new Button();
            btnExit = new Button();
            stTimer = new System.Windows.Forms.Timer(components);
            clTimer = new System.Windows.Forms.Timer(components);
            StopWatch.SuspendLayout();
            Clock.SuspendLayout();
            SuspendLayout();
            // 
            // StopWatch
            // 
            StopWatch.BackColor = Color.White;
            StopWatch.Controls.Add(label2);
            StopWatch.Controls.Add(label1);
            StopWatch.Controls.Add(stSecond);
            StopWatch.Controls.Add(stMinutes);
            StopWatch.Controls.Add(stHours);
            StopWatch.Location = new Point(67, 29);
            StopWatch.Name = "StopWatch";
            StopWatch.Size = new Size(386, 117);
            StopWatch.TabIndex = 0;
            StopWatch.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(245, 34);
            label2.Name = "label2";
            label2.Size = new Size(14, 60);
            label2.TabIndex = 4;
            label2.Text = ":";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(149, 33);
            label1.Name = "label1";
            label1.Size = new Size(14, 60);
            label1.TabIndex = 3;
            label1.Text = ":";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stSecond
            // 
            stSecond.BackColor = SystemColors.ButtonFace;
            stSecond.BorderStyle = BorderStyle.Fixed3D;
            stSecond.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stSecond.ForeColor = Color.FromArgb(0, 0, 192);
            stSecond.Location = new Point(265, 34);
            stSecond.Name = "stSecond";
            stSecond.Size = new Size(70, 60);
            stSecond.TabIndex = 2;
            stSecond.TextAlign = ContentAlignment.MiddleCenter;
            stSecond.UseCompatibleTextRendering = true;
            stSecond.Click += label2_Click;
            // 
            // stMinutes
            // 
            stMinutes.BackColor = SystemColors.ButtonFace;
            stMinutes.BorderStyle = BorderStyle.Fixed3D;
            stMinutes.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stMinutes.ForeColor = Color.FromArgb(0, 0, 192);
            stMinutes.Location = new Point(169, 34);
            stMinutes.Name = "stMinutes";
            stMinutes.Size = new Size(70, 60);
            stMinutes.TabIndex = 1;
            stMinutes.TextAlign = ContentAlignment.MiddleCenter;
            stMinutes.UseCompatibleTextRendering = true;
            // 
            // stHours
            // 
            stHours.BackColor = SystemColors.ButtonFace;
            stHours.BorderStyle = BorderStyle.Fixed3D;
            stHours.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stHours.ForeColor = Color.FromArgb(0, 0, 192);
            stHours.Location = new Point(73, 34);
            stHours.Name = "stHours";
            stHours.Size = new Size(70, 60);
            stHours.TabIndex = 0;
            stHours.TextAlign = ContentAlignment.MiddleCenter;
            stHours.UseCompatibleTextRendering = true;
            // 
            // Clock
            // 
            Clock.Controls.Add(label4);
            Clock.Controls.Add(clSecond);
            Clock.Controls.Add(label3);
            Clock.Controls.Add(clHours);
            Clock.Controls.Add(clMinuts);
            Clock.ImeMode = ImeMode.NoControl;
            Clock.Location = new Point(67, 29);
            Clock.Name = "Clock";
            Clock.Size = new Size(386, 117);
            Clock.TabIndex = 0;
            Clock.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(245, 39);
            label4.Name = "label4";
            label4.Size = new Size(14, 60);
            label4.TabIndex = 6;
            label4.Text = ":";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clSecond
            // 
            clSecond.BackColor = SystemColors.ButtonFace;
            clSecond.BorderStyle = BorderStyle.Fixed3D;
            clSecond.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clSecond.ForeColor = Color.FromArgb(0, 0, 192);
            clSecond.Location = new Point(265, 40);
            clSecond.Name = "clSecond";
            clSecond.Size = new Size(70, 60);
            clSecond.TabIndex = 3;
            clSecond.TextAlign = ContentAlignment.MiddleCenter;
            clSecond.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(149, 40);
            label3.Name = "label3";
            label3.Size = new Size(14, 60);
            label3.TabIndex = 5;
            label3.Text = ":";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clHours
            // 
            clHours.BackColor = SystemColors.ButtonFace;
            clHours.BorderStyle = BorderStyle.Fixed3D;
            clHours.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clHours.ForeColor = Color.FromArgb(0, 0, 192);
            clHours.Location = new Point(73, 40);
            clHours.Name = "clHours";
            clHours.Size = new Size(70, 60);
            clHours.TabIndex = 2;
            clHours.TextAlign = ContentAlignment.MiddleCenter;
            clHours.UseCompatibleTextRendering = true;
            // 
            // clMinuts
            // 
            clMinuts.BackColor = SystemColors.ButtonFace;
            clMinuts.BorderStyle = BorderStyle.Fixed3D;
            clMinuts.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clMinuts.ForeColor = Color.FromArgb(0, 0, 192);
            clMinuts.Location = new Point(169, 41);
            clMinuts.Name = "clMinuts";
            clMinuts.Size = new Size(70, 60);
            clMinuts.TabIndex = 1;
            clMinuts.TextAlign = ContentAlignment.MiddleCenter;
            clMinuts.UseCompatibleTextRendering = true;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(192, 255, 192);
            btnStart.ForeColor = Color.ForestGreen;
            btnStart.Location = new Point(97, 174);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 45);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop_Resum
            // 
            btnStop_Resum.BackColor = Color.FromArgb(255, 192, 192);
            btnStop_Resum.ForeColor = Color.Red;
            btnStop_Resum.Location = new Point(227, 174);
            btnStop_Resum.Name = "btnStop_Resum";
            btnStop_Resum.Size = new Size(94, 45);
            btnStop_Resum.TabIndex = 6;
            btnStop_Resum.Text = "Stop";
            btnStop_Resum.UseVisualStyleBackColor = false;
            btnStop_Resum.Click += btnStop_Resum_Click;
            // 
            // btnClock
            // 
            btnClock.BackColor = Color.Silver;
            btnClock.ForeColor = Color.Black;
            btnClock.Location = new Point(97, 237);
            btnClock.Name = "btnClock";
            btnClock.Size = new Size(94, 45);
            btnClock.TabIndex = 7;
            btnClock.Text = "Time";
            btnClock.UseVisualStyleBackColor = false;
            btnClock.Click += btnClock_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(192, 255, 255);
            btnReset.ForeColor = Color.Navy;
            btnReset.Location = new Point(350, 174);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 45);
            btnReset.TabIndex = 8;
            btnReset.Text = "Recet";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSwap
            // 
            btnSwap.BackColor = Color.FromArgb(255, 224, 192);
            btnSwap.ForeColor = Color.FromArgb(255, 128, 0);
            btnSwap.Location = new Point(227, 237);
            btnSwap.Name = "btnSwap";
            btnSwap.Size = new Size(94, 45);
            btnSwap.TabIndex = 9;
            btnSwap.Text = "Swap";
            btnSwap.UseVisualStyleBackColor = false;
            btnSwap.Click += btnSwap_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 128);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(350, 237);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 45);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // stTimer
            // 
            stTimer.Interval = 1000;
            stTimer.Tick += stTimer_Tick;
            // 
            // clTimer
            // 
            clTimer.Interval = 1000;
            clTimer.Tick += clTimer_Tick;
            // 
            // frmStopWatch
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 453);
            Controls.Add(btnExit);
            Controls.Add(StopWatch);
            Controls.Add(btnSwap);
            Controls.Add(btnReset);
            Controls.Add(btnClock);
            Controls.Add(Clock);
            Controls.Add(btnStop_Resum);
            Controls.Add(btnStart);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmStopWatch";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StopWatch";
            StopWatch.ResumeLayout(false);
            Clock.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox StopWatch;
        private GroupBox Clock;
        protected Label stHours;
        protected Label stSecond;
        protected Label stMinutes;
        protected Label clSecond;
        protected Label clHours;
        protected Label clMinuts;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button btnStart;
        private Button btnStop_Resum;
        private Button btnClock;
        private Button btnReset;
        private Button btnSwap;
        private Button btnExit;
        private System.Windows.Forms.Timer stTimer;
        private System.Windows.Forms.Timer clTimer;
    }
}
