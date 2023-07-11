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
    /// Represents a row of MarkSheetExam data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class MarkSheetExam
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        [DataMember] 
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the Year column.
        /// </summary>
        [DataMember]
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets a int value for the Term column.
        /// </summary>
        [DataMember]
        public int Term { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the ExamDate column.
        /// </summary>
        [DataMember]
        public DateTime ExamDate { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Class column.
        /// </summary>
        [DataMember]
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Subject column.
        /// </summary>
        [DataMember]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets a string value for the ExamType column.
        /// </summary>
        [DataMember]
        public string ExamType { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the LastModified column.
        /// </summary>
        [DataMember]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Gets or sets a string value for the ModifiedBy column.
        /// </summary>
        [DataMember]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the Enabled column.
        /// </summary>
        [DataMember]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the Closed column.
        /// </summary>
        [DataMember]
        public bool Closed { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the IsDeleted column.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}