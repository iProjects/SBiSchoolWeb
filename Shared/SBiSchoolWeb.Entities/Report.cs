//====================================================================================================
// Base code generated with Inertia: BE Gen (Build 2.5.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 12/31/2014 06:22:08 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;


namespace SBiSchoolWeb.Entities
{
    /// <summary>
    /// Represents a row of Report data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Report
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        [DataMember] 
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the ReportName column.
        /// </summary>
        [DataMember]
        public string ReportName { get; set; }

        /// <summary>
        /// Gets or sets a int value for the ReportGroup column.
        /// </summary>
        [DataMember]
        public int ReportGroup { get; set; }

        /// <summary>
        /// Gets or sets a string value for the ResouceFile column.
        /// </summary>
        [DataMember]
        public string ResouceFile { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the IsDeleted column.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
