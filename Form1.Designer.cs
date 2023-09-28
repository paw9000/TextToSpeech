namespace TextToSpeech
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeVoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rateSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.volumeSlider = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.letterKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.shiftCheckbox = new System.Windows.Forms.CheckBox();
            this.altCheckbox = new System.Windows.Forms.CheckBox();
            this.ctrlCheckbox = new System.Windows.Forms.CheckBox();
            this.windowsCheckbox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.openSpeechSettingButton = new System.Windows.Forms.Button();
            this.testVoiceButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Text To Speech";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 54);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.setupToolStripMenuItem.Text = "Setup...";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // activeVoice
            // 
            this.activeVoice.FormattingEnabled = true;
            this.activeVoice.Location = new System.Drawing.Point(105, 12);
            this.activeVoice.Name = "activeVoice";
            this.activeVoice.Size = new System.Drawing.Size(196, 21);
            this.activeVoice.TabIndex = 1;
            this.activeVoice.SelectedIndexChanged += new System.EventHandler(this.activeVoice_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed:";
            // 
            // rateSlider
            // 
            this.rateSlider.Location = new System.Drawing.Point(105, 45);
            this.rateSlider.Minimum = -10;
            this.rateSlider.Name = "rateSlider";
            this.rateSlider.Size = new System.Drawing.Size(196, 45);
            this.rateSlider.TabIndex = 4;
            this.rateSlider.Value = 3;
            this.rateSlider.Scroll += new System.EventHandler(this.rateSlider_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Slower";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Faster";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Volume:";
            // 
            // volumeSlider
            // 
            this.volumeSlider.Location = new System.Drawing.Point(105, 104);
            this.volumeSlider.Maximum = 100;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(197, 45);
            this.volumeSlider.TabIndex = 8;
            this.volumeSlider.TickFrequency = 5;
            this.volumeSlider.Value = 100;
            this.volumeSlider.Scroll += new System.EventHandler(this.volumeSlider_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Key combo:";
            // 
            // letterKey
            // 
            this.letterKey.Location = new System.Drawing.Point(105, 162);
            this.letterKey.MaxLength = 1;
            this.letterKey.Name = "letterKey";
            this.letterKey.Size = new System.Drawing.Size(36, 20);
            this.letterKey.TabIndex = 12;
            this.letterKey.Text = "y";
            this.letterKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterKey.TextChanged += new System.EventHandler(this.letterKey_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Modifier Keys:";
            // 
            // shiftCheckbox
            // 
            this.shiftCheckbox.AutoSize = true;
            this.shiftCheckbox.Location = new System.Drawing.Point(105, 198);
            this.shiftCheckbox.Name = "shiftCheckbox";
            this.shiftCheckbox.Size = new System.Drawing.Size(47, 17);
            this.shiftCheckbox.TabIndex = 14;
            this.shiftCheckbox.Text = "Shift";
            this.shiftCheckbox.UseVisualStyleBackColor = true;
            this.shiftCheckbox.CheckedChanged += new System.EventHandler(this.shiftCheckbox_CheckedChanged);
            // 
            // altCheckbox
            // 
            this.altCheckbox.AutoSize = true;
            this.altCheckbox.Location = new System.Drawing.Point(105, 222);
            this.altCheckbox.Name = "altCheckbox";
            this.altCheckbox.Size = new System.Drawing.Size(38, 17);
            this.altCheckbox.TabIndex = 15;
            this.altCheckbox.Text = "Alt";
            this.altCheckbox.UseVisualStyleBackColor = true;
            this.altCheckbox.CheckedChanged += new System.EventHandler(this.altCheckbox_CheckedChanged);
            // 
            // ctrlCheckbox
            // 
            this.ctrlCheckbox.AutoSize = true;
            this.ctrlCheckbox.Location = new System.Drawing.Point(158, 198);
            this.ctrlCheckbox.Name = "ctrlCheckbox";
            this.ctrlCheckbox.Size = new System.Drawing.Size(41, 17);
            this.ctrlCheckbox.TabIndex = 16;
            this.ctrlCheckbox.Text = "Ctrl";
            this.ctrlCheckbox.UseVisualStyleBackColor = true;
            this.ctrlCheckbox.CheckedChanged += new System.EventHandler(this.ctrlCheckbox_CheckedChanged);
            // 
            // windowsCheckbox
            // 
            this.windowsCheckbox.AutoSize = true;
            this.windowsCheckbox.Location = new System.Drawing.Point(158, 222);
            this.windowsCheckbox.Name = "windowsCheckbox";
            this.windowsCheckbox.Size = new System.Drawing.Size(91, 17);
            this.windowsCheckbox.TabIndex = 17;
            this.windowsCheckbox.Text = "Windows Key";
            this.windowsCheckbox.UseVisualStyleBackColor = true;
            this.windowsCheckbox.CheckedChanged += new System.EventHandler(this.windowsCheckbox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(307, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 236);
            this.panel1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(317, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(295, 196);
            this.label10.TabIndex = 19;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // openSpeechSettingButton
            // 
            this.openSpeechSettingButton.Location = new System.Drawing.Point(320, 222);
            this.openSpeechSettingButton.Name = "openSpeechSettingButton";
            this.openSpeechSettingButton.Size = new System.Drawing.Size(143, 23);
            this.openSpeechSettingButton.TabIndex = 20;
            this.openSpeechSettingButton.Text = "Windows speech settings";
            this.openSpeechSettingButton.UseVisualStyleBackColor = true;
            this.openSpeechSettingButton.Click += new System.EventHandler(this.openSpeechSettingButton_Click);
            // 
            // testVoiceButton
            // 
            this.testVoiceButton.Location = new System.Drawing.Point(469, 222);
            this.testVoiceButton.Name = "testVoiceButton";
            this.testVoiceButton.Size = new System.Drawing.Size(143, 23);
            this.testVoiceButton.TabIndex = 21;
            this.testVoiceButton.Text = "Test current voice";
            this.testVoiceButton.UseVisualStyleBackColor = true;
            this.testVoiceButton.Click += new System.EventHandler(this.testVoiceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 258);
            this.Controls.Add(this.testVoiceButton);
            this.Controls.Add(this.openSpeechSettingButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowsCheckbox);
            this.Controls.Add(this.ctrlCheckbox);
            this.Controls.Add(this.altCheckbox);
            this.Controls.Add(this.shiftCheckbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.letterKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rateSlider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activeVoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Text To Speech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rateSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ComboBox activeVoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar rateSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar volumeSlider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox letterKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox shiftCheckbox;
        private System.Windows.Forms.CheckBox altCheckbox;
        private System.Windows.Forms.CheckBox ctrlCheckbox;
        private System.Windows.Forms.CheckBox windowsCheckbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button openSpeechSettingButton;
        private System.Windows.Forms.Button testVoiceButton;
    }
}

