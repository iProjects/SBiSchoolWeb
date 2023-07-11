//====================================================================================================
// Base code generated with Inertia: BE Gen (Build 2.5.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 01/14/2015 18:41:08 
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
    /// Represents a row of ProgrammeYear data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class ProgrammeYear
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the ProgrammeId column.
        /// </summary>
        [DataMember]
        public string ProgrammeId { get; set; }

        /// <summary>
        /// Gets or sets a int value for the Year column.
        /// </summary>
        [DataMember]
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Description column.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a int value for the NextYr column.
        /// </summary>
        [DataMember]
        public int NextYr { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the Fees column.
        /// </summary>
        [DataMember]
        public decimal Fees { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Status column.
        /// </summary>
        [DataMember]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the IsDeleted column.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
