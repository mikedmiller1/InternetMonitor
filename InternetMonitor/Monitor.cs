using System.Timers;
using System.IO;
using System.Net.NetworkInformation;


namespace InternetMonitor
{
    /// <summary>
    /// Contains an internet monitor
    /// </summary>
    public class Monitor
    {
        #region Properties

        /// <summary>
        /// The full path and filename of the log file
        /// Updates the application settings when changed
        /// </summary>
        public string LogFile = "";



        /// <summary>
        /// Timer for logging results
        /// </summary>
        private Timer theTimer = new Timer();



        /// <summary>
        /// Interval between results logging, in seconds
        /// </summary>
        private int _LogInterval;
        public int LogInterval
        {
            get
            {
                return _LogInterval;
            }

            set
            {
                if( _LogInterval != value )
                {
                    _LogInterval = value;

                    // Update the timer with the new interval
                    theTimer.Interval = _LogInterval * 1000;
                }
            }
        }



        /// <summary>
        /// Constructor
        /// </summary>
        public Monitor()
        {
            // Add the logger as a timer event handler
            theTimer.Elapsed += new ElapsedEventHandler( LogResult );
        }



        /// <summary>
        /// The router address to attempt to ping
        /// </summary>
        public string RouterAddress = "";



        /// <summary>
        /// An IP address to attempt to ping
        /// </summary>
        public string IpAddress = "";



        /// <summary>
        /// A name address to attempt to ping
        /// </summary>
        public string NameAddress = "";

        #endregion



        /// <summary>
        /// Starts logging
        /// </summary>
        public void StartLogging()
        {
            // Start the timer
            theTimer.Enabled = true;

            // Log a result now
            LogResult();
        }



        /// <summary>
        /// Stops logging
        /// </summary>
        public void StopLogging()
        {
            // Stop the timer
            theTimer.Enabled = false;
        }



        /// <summary>
        /// Gets a new result and logs it
        /// </summary>
        public void LogResult()
        {
            // Create a new result
            Result theResult = new Result();


            // Add the addresses
            theResult.RouterAddress = RouterAddress;
            theResult.IpAddress = IpAddress;
            theResult.NameAddress = NameAddress;

            // Ping the addresses
            theResult.RouterStatus = PingAddress( RouterAddress );
            theResult.IpStatus = PingAddress( IpAddress );
            theResult.NameStatus = PingAddress( NameAddress );


            // Add the result to the log
            UpdateLog( theResult );
        }



        /// <summary>
        /// Gets a new result and logs it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LogResult( object sender, ElapsedEventArgs e )
        {
            LogResult();
        }



        /// <summary>
        /// Appends the specified result to the log file
        /// </summary>
        /// <param name="theResult">The result to append to the log file</param>
        private void UpdateLog( Result theResult )
        {
            // Append the result to the log file
            using ( StreamWriter theWriter = File.AppendText( LogFile ) )
            {
                theWriter.WriteLine( theResult.ToString() );
            }
        }



        /// <summary>
        /// Attempts to ping the specified address and returns a string of the status
        /// </summary>
        /// <param name="theAddress">The address to ping</param>
        /// <returns>Boolean indicating if the ping was successful</returns>
        private string PingAddress( string theAddress )
        {
            // Initialize the result
            string Status = "Unknown Error";


            // Create a pinger
            Ping Pinger = new System.Net.NetworkInformation.Ping();

            try
            {
                // Attempt to ping the address
                PingReply theReply = Pinger.Send( theAddress );

                // Get the result
                Status = theReply.Status.ToString();
            }

            catch
            { }


            // Return the result
            return Status;
        }

    }
}
