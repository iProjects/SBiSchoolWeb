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
    /// Represents a row of StudentsExamResults_Temp data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class StudentsExamResults_Temp
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        [DataMember] 
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the StudentId column.
        /// </summary>
        [DataMember]
        public int StudentId { get; set; }

        /// <summary>
        /// Gets or sets a int value for the Examid column.
        /// </summary>
        [DataMember]
        public int Examid { get; set; }

        /// <summary>
        /// Gets or sets a int value for the SchoolClassId column.
        /// </summary>
        [DataMember]
        public int SchoolClassId { get; set; }

        /// <summary>
        /// Gets or sets a int value for the TeacherId column.
        /// </summary>
        [DataMember]
        public int TeacherId { get; set; }

        /// <summary>
        /// Gets or sets a double value for the TotalMarks_Target column.
        /// </summary>
        [DataMember]
        public double TotalMarks_Target { get; set; }

        /// <summary>
        /// Gets or sets a double value for the TotalPoints_Target column.
        /// </summary>
        [DataMember]
        public double TotalPoints_Target { get; set; }

        /// <summary>
        /// Gets or sets a int value for the Position_Target column.
        /// </summary>
        [DataMember]
        public int Position_Target { get; set; }

        /// <summary>
        /// Gets or sets a double value for the MeanMarks_Target column.
        /// </summary>
        [DataMember]
        public double MeanMarks_Target { get; set; }

        /// <summary>
        /// Gets or sets a string value for the MeanGrade_Target column.
        /// </summary>
        [DataMember]
        public string MeanGrade_Target { get; set; }

        /// <summary>
        /// Gets or sets a double value for the TotalMarks column.
        /// </summary>
        [DataMember]
        public double TotalMarks { get; set; }

        /// <summary>
        /// Gets or sets a double value for the TotalPoints column.
        /// </summary>
        [DataMember]
        public double TotalPoints { get; set; }

        /// <summary>
        /// Gets or sets a int value for the Position column.
        /// </summary>
        [DataMember]
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets a double value for the MeanMarks column.
        /// </summary>
        [DataMember]
        public double MeanMarks { get; set; }

        /// <summary>
        /// Gets or sets a string value for the MeanGrade column.
        /// </summary>
        [DataMember]
        public string MeanGrade { get; set; }

        /// <summary>
        /// Gets or sets a string value for the ClassTeacherRemark column.
        /// </summary>
        [DataMember]
        public string ClassTeacherRemark { get; set; }

        /// <summary>
        /// Gets or sets a string value for the HeadTeacherRemark column.
        /// </summary>
        [DataMember]
        public string HeadTeacherRemark { get; set; }

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
