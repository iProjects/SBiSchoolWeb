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
    /// Represents a row of Setting data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Setting
    {
        /// <summary>
        /// Gets or sets a string value for the SSKey column.
        /// </summary>
        [DataMember] 
        public string SSKey { get; set; }

        /// <summary>
        /// Gets or sets a string value for the SSValue column.
        /// </summary>
        [DataMember]
        public string SSValue { get; set; }

        /// <summary>
        /// Gets or sets a string value for the SSValueType column.
        /// </summary>
        [DataMember]
        public string SSValueType { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Description column.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a int value for the SGroup column.
        /// </summary>
        [DataMember]
        public int SGroup { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the SSSystem column.
        /// </summary>
        [DataMember]
        public bool SSSystem { get; set; }
    }
}