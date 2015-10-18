namespace Stepper_Controll
{
    partial class StepperControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StepperControl));
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMIndex = new System.Windows.Forms.ComboBox();
            this.cbDirections = new System.Windows.Forms.ComboBox();
            this.tbSteps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Move = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbDStep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRev = new System.Windows.Forms.Button();
            this.tbRev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDeg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbStepM = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.Move.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnConnect.Location = new System.Drawing.Point(6, 46);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 29);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.ForeColor = System.Drawing.Color.Red;
            this.btnDisconnect.Location = new System.Drawing.Point(6, 81);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 32);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.BackColor = System.Drawing.Color.Black;
            this.cbPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPorts.ForeColor = System.Drawing.Color.White;
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(6, 19);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(75, 21);
            this.cbPorts.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPorts);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // cbMIndex
            // 
            this.cbMIndex.BackColor = System.Drawing.Color.Black;
            this.cbMIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMIndex.ForeColor = System.Drawing.Color.White;
            this.cbMIndex.FormattingEnabled = true;
            this.cbMIndex.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cbMIndex.Location = new System.Drawing.Point(59, 19);
            this.cbMIndex.Name = "cbMIndex";
            this.cbMIndex.Size = new System.Drawing.Size(121, 21);
            this.cbMIndex.TabIndex = 4;
            this.cbMIndex.Text = "X";
            // 
            // cbDirections
            // 
            this.cbDirections.BackColor = System.Drawing.Color.Black;
            this.cbDirections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDirections.ForeColor = System.Drawing.Color.White;
            this.cbDirections.FormattingEnabled = true;
            this.cbDirections.Items.AddRange(new object[] {
            "CW",
            "CCW"});
            this.cbDirections.Location = new System.Drawing.Point(59, 47);
            this.cbDirections.Name = "cbDirections";
            this.cbDirections.Size = new System.Drawing.Size(121, 21);
            this.cbDirections.TabIndex = 5;
            this.cbDirections.Text = "CW";
            // 
            // tbSteps
            // 
            this.tbSteps.BackColor = System.Drawing.Color.Black;
            this.tbSteps.ForeColor = System.Drawing.Color.White;
            this.tbSteps.Location = new System.Drawing.Point(253, 20);
            this.tbSteps.Name = "tbSteps";
            this.tbSteps.Size = new System.Drawing.Size(121, 20);
            this.tbSteps.TabIndex = 6;
            this.tbSteps.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Axis -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dir -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Steps -";
            // 
            // Move
            // 
            this.Move.Controls.Add(this.btnStop);
            this.Move.Controls.Add(this.btnStart);
            this.Move.Controls.Add(this.groupBox4);
            this.Move.Controls.Add(this.groupBox2);
            this.Move.ForeColor = System.Drawing.Color.White;
            this.Move.Location = new System.Drawing.Point(12, 12);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(615, 243);
            this.Move.TabIndex = 11;
            this.Move.TabStop = false;
            this.Move.Text = "Move Motors";
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(200, 104);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(190, 120);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnStart.Location = new System.Drawing.Point(7, 104);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(187, 120);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbStepM);
            this.groupBox4.Controls.Add(this.tbDStep);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnRev);
            this.groupBox4.Controls.Add(this.tbRev);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbDeg);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(396, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 207);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties";
            // 
            // tbDStep
            // 
            this.tbDStep.BackColor = System.Drawing.Color.Black;
            this.tbDStep.ForeColor = System.Drawing.Color.White;
            this.tbDStep.Location = new System.Drawing.Point(79, 49);
            this.tbDStep.Name = "tbDStep";
            this.tbDStep.Size = new System.Drawing.Size(121, 20);
            this.tbDStep.TabIndex = 21;
            this.tbDStep.Text = "7.5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "D.Step -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "M.Rev -";
            // 
            // btnRev
            // 
            this.btnRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRev.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnRev.Location = new System.Drawing.Point(11, 143);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(189, 46);
            this.btnRev.TabIndex = 15;
            this.btnRev.Text = "Start";
            this.btnRev.UseVisualStyleBackColor = true;
            this.btnRev.Click += new System.EventHandler(this.btnRev_Click);
            // 
            // tbRev
            // 
            this.tbRev.BackColor = System.Drawing.Color.Black;
            this.tbRev.ForeColor = System.Drawing.Color.White;
            this.tbRev.Location = new System.Drawing.Point(79, 80);
            this.tbRev.Name = "tbRev";
            this.tbRev.Size = new System.Drawing.Size(121, 20);
            this.tbRev.TabIndex = 13;
            this.tbRev.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rev -";
            // 
            // tbDeg
            // 
            this.tbDeg.BackColor = System.Drawing.Color.Black;
            this.tbDeg.ForeColor = System.Drawing.Color.White;
            this.tbDeg.Location = new System.Drawing.Point(79, 19);
            this.tbDeg.Name = "tbDeg";
            this.tbDeg.Size = new System.Drawing.Size(121, 20);
            this.tbDeg.TabIndex = 16;
            this.tbDeg.Text = "360";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Deg -";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbSteps);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbSpeed);
            this.groupBox2.Controls.Add(this.cbDirections);
            this.groupBox2.Controls.Add(this.cbMIndex);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(6, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 81);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stepper";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Speed -";
            // 
            // tbSpeed
            // 
            this.tbSpeed.BackColor = System.Drawing.Color.Black;
            this.tbSpeed.ForeColor = System.Drawing.Color.White;
            this.tbSpeed.Location = new System.Drawing.Point(253, 48);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(121, 20);
            this.tbSpeed.TabIndex = 18;
            this.tbSpeed.Text = "25";
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.Black;
            this.tbStatus.ForeColor = System.Drawing.Color.White;
            this.tbStatus.Location = new System.Drawing.Point(6, 19);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(509, 90);
            this.tbStatus.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbStatus);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(105, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 121);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // cbStepM
            // 
            this.cbStepM.AutoSize = true;
            this.cbStepM.Checked = true;
            this.cbStepM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStepM.Location = new System.Drawing.Point(79, 113);
            this.cbStepM.Name = "cbStepM";
            this.cbStepM.Size = new System.Drawing.Size(64, 17);
            this.cbStepM.TabIndex = 13;
            this.cbStepM.Text = "FullStep";
            this.cbStepM.UseVisualStyleBackColor = true;
            // 
            // StepperControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(639, 400);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Move);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StepperControl";
            this.Text = "Stepper Control";
            this.groupBox1.ResumeLayout(false);
            this.Move.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMIndex;
        private System.Windows.Forms.ComboBox cbDirections;
        private System.Windows.Forms.TextBox tbSteps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Move;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDeg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbDStep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbStepM;
    }
}

