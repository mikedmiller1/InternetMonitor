namespace InternetMonitor
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.LogFileLabel = new System.Windows.Forms.LinkLabel();
            this.LogFileBrowseButton = new System.Windows.Forms.Button();
            this.LogIntervalLabel = new System.Windows.Forms.Label();
            this.LogIntervalText = new System.Windows.Forms.TextBox();
            this.LogFileText = new System.Windows.Forms.TextBox();
            this.LogNowButton = new System.Windows.Forms.Button();
            this.RouterAddressLabel = new System.Windows.Forms.Label();
            this.IpAddressLabel = new System.Windows.Forms.Label();
            this.NameAddressLabel = new System.Windows.Forms.Label();
            this.RouterAddressText = new System.Windows.Forms.TextBox();
            this.IpAddressText = new System.Windows.Forms.TextBox();
            this.NameAddressText = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Internet Monitor";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_Click);
            // 
            // LogFileLabel
            // 
            this.LogFileLabel.AutoSize = true;
            this.LogFileLabel.Location = new System.Drawing.Point(12, 9);
            this.LogFileLabel.Name = "LogFileLabel";
            this.LogFileLabel.Size = new System.Drawing.Size(44, 13);
            this.LogFileLabel.TabIndex = 0;
            this.LogFileLabel.TabStop = true;
            this.LogFileLabel.Text = "Log File";
            this.LogFileLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogFileLabel_LinkClicked);
            // 
            // LogFileBrowseButton
            // 
            this.LogFileBrowseButton.Location = new System.Drawing.Point(587, 4);
            this.LogFileBrowseButton.Name = "LogFileBrowseButton";
            this.LogFileBrowseButton.Size = new System.Drawing.Size(27, 23);
            this.LogFileBrowseButton.TabIndex = 2;
            this.LogFileBrowseButton.Text = "...";
            this.LogFileBrowseButton.UseVisualStyleBackColor = true;
            this.LogFileBrowseButton.Click += new System.EventHandler(this.LogFileBrowseButton_Click);
            // 
            // LogIntervalLabel
            // 
            this.LogIntervalLabel.AutoSize = true;
            this.LogIntervalLabel.Location = new System.Drawing.Point(12, 35);
            this.LogIntervalLabel.Name = "LogIntervalLabel";
            this.LogIntervalLabel.Size = new System.Drawing.Size(68, 13);
            this.LogIntervalLabel.TabIndex = 4;
            this.LogIntervalLabel.Text = "Interval (sec)";
            // 
            // LogIntervalText
            // 
            this.LogIntervalText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::InternetMonitor.Properties.Settings.Default, "LogInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LogIntervalText.Location = new System.Drawing.Point(81, 32);
            this.LogIntervalText.Name = "LogIntervalText";
            this.LogIntervalText.Size = new System.Drawing.Size(46, 20);
            this.LogIntervalText.TabIndex = 5;
            this.LogIntervalText.Text = global::InternetMonitor.Properties.Settings.Default.LogInterval;
            this.LogIntervalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogIntervalText.TextChanged += new System.EventHandler(this.LogIntervalText_TextChanged);
            // 
            // LogFileText
            // 
            this.LogFileText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::InternetMonitor.Properties.Settings.Default, "LogFileName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LogFileText.Location = new System.Drawing.Point(81, 6);
            this.LogFileText.Name = "LogFileText";
            this.LogFileText.Size = new System.Drawing.Size(500, 20);
            this.LogFileText.TabIndex = 1;
            this.LogFileText.Text = global::InternetMonitor.Properties.Settings.Default.LogFileName;
            // 
            // LogNowButton
            // 
            this.LogNowButton.Location = new System.Drawing.Point(539, 137);
            this.LogNowButton.Name = "LogNowButton";
            this.LogNowButton.Size = new System.Drawing.Size(75, 23);
            this.LogNowButton.TabIndex = 6;
            this.LogNowButton.Text = "Log Now";
            this.LogNowButton.UseVisualStyleBackColor = true;
            this.LogNowButton.Click += new System.EventHandler(this.LogNowButton_Click);
            // 
            // RouterAddressLabel
            // 
            this.RouterAddressLabel.AutoSize = true;
            this.RouterAddressLabel.Location = new System.Drawing.Point(12, 61);
            this.RouterAddressLabel.Name = "RouterAddressLabel";
            this.RouterAddressLabel.Size = new System.Drawing.Size(39, 13);
            this.RouterAddressLabel.TabIndex = 7;
            this.RouterAddressLabel.Text = "Router";
            // 
            // IpAddressLabel
            // 
            this.IpAddressLabel.AutoSize = true;
            this.IpAddressLabel.Location = new System.Drawing.Point(12, 87);
            this.IpAddressLabel.Name = "IpAddressLabel";
            this.IpAddressLabel.Size = new System.Drawing.Size(58, 13);
            this.IpAddressLabel.TabIndex = 8;
            this.IpAddressLabel.Text = "IP Address";
            // 
            // NameAddressLabel
            // 
            this.NameAddressLabel.AutoSize = true;
            this.NameAddressLabel.Location = new System.Drawing.Point(12, 113);
            this.NameAddressLabel.Name = "NameAddressLabel";
            this.NameAddressLabel.Size = new System.Drawing.Size(35, 13);
            this.NameAddressLabel.TabIndex = 9;
            this.NameAddressLabel.Text = "Name";
            // 
            // RouterAddressText
            // 
            this.RouterAddressText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::InternetMonitor.Properties.Settings.Default, "RouterAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RouterAddressText.Location = new System.Drawing.Point(81, 58);
            this.RouterAddressText.Name = "RouterAddressText";
            this.RouterAddressText.Size = new System.Drawing.Size(166, 20);
            this.RouterAddressText.TabIndex = 10;
            this.RouterAddressText.Text = global::InternetMonitor.Properties.Settings.Default.RouterAddress;
            this.RouterAddressText.TextChanged += new System.EventHandler(this.RouterAddressText_TextChanged);
            // 
            // IpAddressText
            // 
            this.IpAddressText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::InternetMonitor.Properties.Settings.Default, "IpAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IpAddressText.Location = new System.Drawing.Point(81, 84);
            this.IpAddressText.Name = "IpAddressText";
            this.IpAddressText.Size = new System.Drawing.Size(166, 20);
            this.IpAddressText.TabIndex = 11;
            this.IpAddressText.Text = global::InternetMonitor.Properties.Settings.Default.IpAddress;
            this.IpAddressText.TextChanged += new System.EventHandler(this.IpAddressText_TextChanged);
            // 
            // NameAddressText
            // 
            this.NameAddressText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::InternetMonitor.Properties.Settings.Default, "NameAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NameAddressText.Location = new System.Drawing.Point(81, 110);
            this.NameAddressText.Name = "NameAddressText";
            this.NameAddressText.Size = new System.Drawing.Size(166, 20);
            this.NameAddressText.TabIndex = 12;
            this.NameAddressText.Text = global::InternetMonitor.Properties.Settings.Default.NameAddress;
            this.NameAddressText.TextChanged += new System.EventHandler(this.NameAddressText_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(340, 137);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 13;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(421, 137);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 14;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 172);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.NameAddressText);
            this.Controls.Add(this.IpAddressText);
            this.Controls.Add(this.RouterAddressText);
            this.Controls.Add(this.NameAddressLabel);
            this.Controls.Add(this.IpAddressLabel);
            this.Controls.Add(this.RouterAddressLabel);
            this.Controls.Add(this.LogNowButton);
            this.Controls.Add(this.LogIntervalText);
            this.Controls.Add(this.LogIntervalLabel);
            this.Controls.Add(this.LogFileBrowseButton);
            this.Controls.Add(this.LogFileText);
            this.Controls.Add(this.LogFileLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Internet Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.LinkLabel LogFileLabel;
        private System.Windows.Forms.TextBox LogFileText;
        private System.Windows.Forms.Button LogFileBrowseButton;
        private System.Windows.Forms.Label LogIntervalLabel;
        private System.Windows.Forms.TextBox LogIntervalText;
        private System.Windows.Forms.Button LogNowButton;
        private System.Windows.Forms.Label RouterAddressLabel;
        private System.Windows.Forms.Label IpAddressLabel;
        private System.Windows.Forms.Label NameAddressLabel;
        private System.Windows.Forms.TextBox RouterAddressText;
        private System.Windows.Forms.TextBox IpAddressText;
        private System.Windows.Forms.TextBox NameAddressText;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
    }
}

