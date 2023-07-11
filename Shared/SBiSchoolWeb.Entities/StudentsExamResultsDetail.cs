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
    /// Represents a row of StudentsExamResultsDetail data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class StudentsExamResultsDetail
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        [DataMember] 
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the StudentsExamResultsId column.
        /// </summary>
        [DataMember]
        public int StudentsExamResultsId { get; set; }

        /// <summary>
        /// Gets or sets a string value for the SubjectShortCode column.
        /// </summary>
        [DataMember]
        public string SubjectShortCode { get; set; }

        /// <summary>
        /// Gets or sets a double value for the Mark column.
        /// </summary>
        [DataMember]
        public double Mark { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Grade column.
        /// </summary>
        [DataMember]
        public string Grade { get; set; }

        /// <summary>
        /// Gets or sets a double value for the Mark_Target column.
        /// </summary>
        [DataMember]
        public double Mark_Target { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Grade_Target column.
        /// </summary>
        [DataMember]
        public string Grade_Target { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the IsDeleted column.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
