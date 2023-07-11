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
    /// Represents a row of Residence data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Residence
    {
        /// <summary>
        /// Gets or sets a int value for the ResidenceId column.
        /// </summary>
        [DataMember] 
        public int ResidenceId { get; set; }

        /// <summary>
        /// Gets or sets a int value for the ParentId column.
        /// </summary>
        [DataMember]
        public int ParentId { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Name column.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the Cost column.
        /// </summary>
        [DataMember]
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets a string value for the GPSCordinates column.
        /// </summary>
        [DataMember]
        public string GPSCordinates { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Title column.
        /// </summary>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the IsDeleted column.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
