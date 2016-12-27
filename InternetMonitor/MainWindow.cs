using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InternetMonitor
{
    /// <summary>
    /// The main window form
    /// </summary>
    public partial class MainWindow : Form
    {
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

        }




        /// <summary>
        /// Called when the form is resized
        /// Allows minimizing to the tray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowResize( object sender, EventArgs e )
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
        private void NotifyIcon1Click( object sender, MouseEventArgs e )
        {
            // Restore the window
            WindowState = FormWindowState.Normal;
        }


    }
}
