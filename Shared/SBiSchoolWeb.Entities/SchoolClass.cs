//====================================================================================================
// Base code generated with Inertia: BE Gen (Build 2.5.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 01/14/2015 19:02:37 
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
    /// Represents a row of SchoolClass data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class SchoolClass
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the ShortCode column.
        /// </summary>
        [DataMember]
        public string ShortCode { get; set; }

        /// <summary>
        /// Gets or sets a string value for the ClassName column.
        /// </summary>
        [DataMember]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets a int value for the ProgrammeYearId column.
        /// </summary>
        [DataMember]
        public int ProgrammeYearId { get; set; }

        /// <summary>
        /// Gets or sets a int value for the NoOfSubjects column.
        /// </summary>
        [DataMember]
        public int NoOfSubjects { get; set; }

        /// <summary>
        /// Gets or sets a int value for the TeacherId column.
        /// </summary>
        [DataMember]
        public int TeacherId { get; set; }

        /// <summary>
        /// Gets or sets a int value for the CurrentYrLevel column.
        /// </summary>
        [DataMember]
        public int CurrentYrLevel { get; set; }

        /// <summary>
        /// Gets or sets a int value for the NextYrLevel column.
        /// </summary>
        [DataMember]
        public int NextYrLevel { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Remarks column.
        /// </summary>
        [DataMember]
        public string Remarks { get; set; }

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
