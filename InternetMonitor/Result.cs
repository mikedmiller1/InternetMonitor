using System;


namespace InternetMonitor
{
    /// <summary>
    /// Contains a results set
    /// </summary>
    public class Result
    {
        #region Properties
        /// <summary>
        /// The date and time the result was created
        /// </summary>
        public readonly DateTime theDateTime;



        /// <summary>
        /// The router address that was pinged
        /// </summary>
        public string RouterAddress = "";


        
        /// <summary>
        /// The status of the ping to the router address
        /// </summary>
        public string RouterStatus = "";



        /// <summary>
        /// The IP address that was pinged
        /// </summary>
        public string IpAddress = "";



        /// <summary>
        /// The status of the ping to the IP address
        /// </summary>
        public string IpStatus = "";



        /// <summary>
        /// The name address that was pinged
        /// </summary>
        public string NameAddress = "";



        /// <summary>
        /// The status of the ping to the name address
        /// </summary>
        public string NameStatus = "";

        #endregion



        /// <summary>
        /// Constructor
        /// </summary>
        public Result()
        {
            theDateTime = DateTime.Now;
        }



        /// <summary>
        /// Converts the result to a string
        /// </summary>
        /// <returns>A string of the result information</returns>
        public override string ToString()
        {
            // Initialize the string
            string theString = "";


            // Add the date and time
            theString += theDateTime.ToString( "yyyy-MM-dd - HH:mm:ss\n" );

            // Add the ping results
            theString += "Ping to " + RouterAddress + ": " + RouterStatus + "\n";
            theString += "Ping to " + IpAddress + ": " + IpStatus + "\n";
            theString += "Ping to " + NameAddress + ": " + NameStatus + "\n";
            

            // Return the string
            return theString;
        }
    }
}
