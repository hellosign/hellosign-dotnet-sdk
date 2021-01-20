using System;

namespace HelloSign
{
    /// <summary>
    /// Information about a HelloSign Report object.
    /// </summary>
    public class Report
    {
        /// <summary>
        /// Report response message
        /// </summary>
        public string Success { get; set; }

        /// <summary>
        /// The start date of the report data
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date of the report data
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The type of the report you are requesting
        /// </summary>
        public string ReportType { get; set; }
    }
}
