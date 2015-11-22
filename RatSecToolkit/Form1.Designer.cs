namespace RatSecToolkit
{
    partial class RatSecToolkit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatSecToolkit));
            this.label1 = new System.Windows.Forms.Label();
            this.setMac = new System.Windows.Forms.Button();
            this.macBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pingBtn = new System.Windows.Forms.Button();
            this.httpBtn = new System.Windows.Forms.Button();
            this.udpBtn = new System.Windows.Forms.Button();
            this.TriForce = new System.Windows.Forms.Button();
            this.spamBtn = new System.Windows.Forms.Button();
            this.spamText = new System.Windows.Forms.TextBox();
            this.frequencyText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.getMac = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RatImage = new System.Windows.Forms.PictureBox();
            this.logText = new System.Windows.Forms.RichTextBox();
            this.spamTimer = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.endPort = new System.Windows.Forms.TextBox();
            this.startPort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RatImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(89, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "RatSecToolkit -> Ethical";
            // 
            // setMac
            // 
            this.setMac.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.setMac.Location = new System.Drawing.Point(144, 147);
            this.setMac.Name = "setMac";
            this.setMac.Size = new System.Drawing.Size(131, 33);
            this.setMac.TabIndex = 1;
            this.setMac.Text = "Set MAC";
            this.setMac.UseVisualStyleBackColor = false;
            this.setMac.Visible = false;
            this.setMac.Click += new System.EventHandler(this.spoofIP_Click);
            // 
            // macBox
            // 
            this.macBox.Location = new System.Drawing.Point(13, 114);
            this.macBox.Name = "macBox";
            this.macBox.Size = new System.Drawing.Size(262, 30);
            this.macBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(444, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "This tool is for testing purposes only. We\'re not responsible in any way this too" +
    "l may be used.";
            // 
            // pingBtn
            // 
            this.pingBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pingBtn.Location = new System.Drawing.Point(306, 232);
            this.pingBtn.Name = "pingBtn";
            this.pingBtn.Size = new System.Drawing.Size(83, 64);
            this.pingBtn.TabIndex = 9;
            this.pingBtn.Text = "Ping of Death";
            this.pingBtn.UseVisualStyleBackColor = false;
            this.pingBtn.Click += new System.EventHandler(this.pingBtn_Click);
            // 
            // httpBtn
            // 
            this.httpBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.httpBtn.Location = new System.Drawing.Point(398, 232);
            this.httpBtn.Name = "httpBtn";
            this.httpBtn.Size = new System.Drawing.Size(92, 64);
            this.httpBtn.TabIndex = 10;
            this.httpBtn.Text = "HTTP Request";
            this.httpBtn.UseVisualStyleBackColor = false;
            this.httpBtn.Click += new System.EventHandler(this.httpBtn_Click);
            // 
            // udpBtn
            // 
            this.udpBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.udpBtn.Location = new System.Drawing.Point(501, 231);
            this.udpBtn.Name = "udpBtn";
            this.udpBtn.Size = new System.Drawing.Size(87, 67);
            this.udpBtn.TabIndex = 11;
            this.udpBtn.Text = "UDP Blast";
            this.udpBtn.UseVisualStyleBackColor = false;
            this.udpBtn.Click += new System.EventHandler(this.udpBtn_Click);
            // 
            // TriForce
            // 
            this.TriForce.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TriForce.Location = new System.Drawing.Point(306, 315);
            this.TriForce.Name = "TriForce";
            this.TriForce.Size = new System.Drawing.Size(277, 31);
            this.TriForce.TabIndex = 12;
            this.TriForce.Text = "TriForce";
            this.TriForce.UseVisualStyleBackColor = false;
            this.TriForce.Click += new System.EventHandler(this.TriForce_Click);
            // 
            // spamBtn
            // 
            this.spamBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.spamBtn.Location = new System.Drawing.Point(191, 261);
            this.spamBtn.Name = "spamBtn";
            this.spamBtn.Size = new System.Drawing.Size(84, 40);
            this.spamBtn.TabIndex = 13;
            this.spamBtn.Text = "Spam";
            this.spamBtn.UseVisualStyleBackColor = false;
            this.spamBtn.Click += new System.EventHandler(this.spamBtn_Click);
            // 
            // spamText
            // 
            this.spamText.Location = new System.Drawing.Point(13, 229);
            this.spamText.Name = "spamText";
            this.spamText.Size = new System.Drawing.Size(262, 30);
            this.spamText.TabIndex = 14;
            // 
            // frequencyText
            // 
            this.frequencyText.Location = new System.Drawing.Point(109, 266);
            this.frequencyText.Name = "frequencyText";
            this.frequencyText.Size = new System.Drawing.Size(75, 30);
            this.frequencyText.TabIndex = 15;
            this.frequencyText.Text = "5000";
            this.frequencyText.TextChanged += new System.EventHandler(this.frequencyText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(15, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Freq (ms)";
            // 
            // getMac
            // 
            this.getMac.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.getMac.Location = new System.Drawing.Point(13, 147);
            this.getMac.Name = "getMac";
            this.getMac.Size = new System.Drawing.Size(124, 31);
            this.getMac.TabIndex = 17;
            this.getMac.Text = "Get Mac";
            this.getMac.UseVisualStyleBackColor = false;
            this.getMac.Click += new System.EventHandler(this.getMac_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(93, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "MAC Changer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(108, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Spammer";
            // 
            // RatImage
            // 
            this.RatImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RatImage.Image = global::RatSecToolkit.Properties.Resources.image;
            this.RatImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RatImage.InitialImage = global::RatSecToolkit.Properties.Resources.image;
            this.RatImage.Location = new System.Drawing.Point(12, 10);
            this.RatImage.Name = "RatImage";
            this.RatImage.Size = new System.Drawing.Size(70, 66);
            this.RatImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RatImage.TabIndex = 3;
            this.RatImage.TabStop = false;
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(595, 12);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(410, 414);
            this.logText.TabIndex = 20;
            this.logText.Text = "";
            // 
            // spamTimer
            // 
            this.spamTimer.Interval = 5000;
            this.spamTimer.Tick += new System.EventHandler(this.spamTimer_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "IP:";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(340, 187);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(123, 30);
            this.ipBox.TabIndex = 22;
            this.ipBox.Text = "127.0.0.1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Port Scanner:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(419, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 29);
            this.button4.TabIndex = 24;
            this.button4.Text = "Scan Ports";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Port:";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(517, 186);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(71, 30);
            this.portBox.TabIndex = 26;
            this.portBox.Text = "80";
            // 
            // endPort
            // 
            this.endPort.Location = new System.Drawing.Point(521, 125);
            this.endPort.Name = "endPort";
            this.endPort.Size = new System.Drawing.Size(67, 30);
            this.endPort.TabIndex = 27;
            this.endPort.Text = "82";
            // 
            // startPort
            // 
            this.startPort.Location = new System.Drawing.Point(341, 125);
            this.startPort.Name = "startPort";
            this.startPort.Size = new System.Drawing.Size(72, 30);
            this.startPort.TabIndex = 28;
            this.startPort.Text = "80";
            // 
            // RatSecToolkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1017, 454);
            this.Controls.Add(this.startPort);
            this.Controls.Add(this.endPort);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.getMac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.frequencyText);
            this.Controls.Add(this.spamText);
            this.Controls.Add(this.spamBtn);
            this.Controls.Add(this.TriForce);
            this.Controls.Add(this.udpBtn);
            this.Controls.Add(this.httpBtn);
            this.Controls.Add(this.pingBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RatImage);
            this.Controls.Add(this.macBox);
            this.Controls.Add(this.setMac);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RatSecToolkit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.RatImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button setMac;
        private System.Windows.Forms.TextBox macBox;
        private System.Windows.Forms.PictureBox RatImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pingBtn;
        private System.Windows.Forms.Button httpBtn;
        private System.Windows.Forms.Button udpBtn;
        private System.Windows.Forms.Button TriForce;
        private System.Windows.Forms.Button spamBtn;
        private System.Windows.Forms.TextBox spamText;
        private System.Windows.Forms.TextBox frequencyText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getMac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox logText;
        private System.Windows.Forms.Timer spamTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox endPort;
        private System.Windows.Forms.TextBox startPort;
    }
}

