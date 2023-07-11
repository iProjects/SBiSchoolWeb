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
    /// Represents a row of spReportsMenuItem data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class spReportsMenuItem
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        [DataMember] 
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the mnuName column.
        /// </summary>
        [DataMember]
        public string mnuName { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Description column.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
    }
}
