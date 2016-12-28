using System;
using System.Windows.Forms;


namespace InternetMonitor
{
    /// <summary>
    /// The main window form
    /// </summary>
    public partial class MainWindow : Form
    {
        #region Properties
        /// <summary>
        /// A monitor object to store settings and results
        /// </summary>
        public Monitor theMonitor;



        /// <summary>
        /// The text editor executable
        /// </summary>
        private string TextEditor = "C:\\Program Files (x86)\\Notepad++\\notepad++.exe";
        #endregion



        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Called when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load( object sender, EventArgs e )
        {
            // Initialize the monitor object
            theMonitor = new Monitor();
            theMonitor.LogFile = Properties.Settings.Default.LogFileName;
            theMonitor.LogInterval = Int32.Parse( Properties.Settings.Default.LogInterval );
            theMonitor.RouterAddress = Properties.Settings.Default.RouterAddress;
            theMonitor.IpAddress = Properties.Settings.Default.IpAddress;
            theMonitor.NameAddress = Properties.Settings.Default.NameAddress;

            // Start logging
            theMonitor.StartLogging();
        }



        /// <summary>
        /// Called when the form is resized
        /// Allows minimizing to the tray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Resize( object sender, EventArgs e )
        {
            // Check if the resize action was minimizing the window
            if( WindowState == FormWindowState.Minimized )
            {
                // Remove the program from the task bar (tray only)
                ShowInTaskbar = false;

                // Show a notification
                notifyIcon1.ShowBalloonTip( 3000, "Internet Monitor", "Monitoring internet connection", ToolTipIcon.Info );
            }
            else
            {
                // Show the program in the task bar
                ShowInTaskbar = true;
            }
        }



        /// <summary>
        /// Restores the main form when the tray icon is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon1_Click( object sender, MouseEventArgs e )
        {
            // Restore the window
            WindowState = FormWindowState.Normal;
        }



        /// <summary>
        /// Called when the log file browse button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogFileBrowseButton_Click( object sender, EventArgs e )
        {
            // Create the file save dialog box
            SaveFileDialog LogFileDialog = new SaveFileDialog();
            LogFileDialog.Title = "Choose Log File";
            LogFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            LogFileDialog.DefaultExt = "txt";

            // Show the dialog window
            DialogResult LogFileResult = LogFileDialog.ShowDialog();

            // If the user clicked Save
            if ( LogFileResult == DialogResult.OK )
            {
                //  Get the selected filename
                string Filename = LogFileDialog.FileName;

                // If it is different than the current log file
                if( Filename != LogFileText.Text )
                {
                    // Set the log filename field
                    LogFileText.Text = Filename;

                    // Update the monitor
                    theMonitor.LogFile = Filename;
                }
            }
        }



        /// <summary>
        /// Called when the log file link label is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogFileLabel_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            // If there is a log file defined
            if( theMonitor.LogFile != "" )
            {
                // Open it in the text editor
                System.Diagnostics.Process.Start( TextEditor, theMonitor.LogFile );
            }
        }



        /// <summary>
        /// Called when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosing( object sender, FormClosingEventArgs e )
        {
            // Save the application settings
            Properties.Settings.Default.Save();
        }



        /// <summary>
        /// Called when the log interval text is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogIntervalText_TextChanged( object sender, EventArgs e )
        {
            // Update the monitor log interval
            theMonitor.LogInterval = Int32.Parse( LogIntervalText.Text );
        }
    }
}
