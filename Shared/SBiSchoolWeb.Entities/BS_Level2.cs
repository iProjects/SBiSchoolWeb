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
    /// Represents a row of BS_Level2 data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class BS_Level2
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        [DataMember] 
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the ParentId column.
        /// </summary>
        [DataMember]
        public int ParentId { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Description column.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a string value for the AccField column.
        /// </summary>
        [DataMember]
        public string AccField { get; set; }

        /// <summary>
        /// Gets or sets a string value for the BSCriteria column.
        /// </summary>
        [DataMember]
        public string BSCriteria { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the Yr1Amount column.
        /// </summary>
        [DataMember]
        public decimal Yr1Amount { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the Yr2Amount column.
        /// </summary>
        [DataMember]
        public decimal Yr2Amount { get; set; }

        /// <summary>
        /// Gets or sets a int value for the ROrder column.
        /// </summary>
        [DataMember]
        public int ROrder { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the IsDeleted column.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
