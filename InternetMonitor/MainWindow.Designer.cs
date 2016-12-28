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
            this.LogIntervalLabel.Size = new System.Drawing.Size(63, 13);
            this.LogIntervalLabel.TabIndex = 4;
            this.LogIntervalLabel.Text = "Log Interval";
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
            this.LogFileText.Location = new System.Drawing.Point(62, 6);
            this.LogFileText.Name = "LogFileText";
            this.LogFileText.Size = new System.Drawing.Size(519, 20);
            this.LogFileText.TabIndex = 1;
            this.LogFileText.Text = global::InternetMonitor.Properties.Settings.Default.LogFileName;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 294);
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
    }
}

