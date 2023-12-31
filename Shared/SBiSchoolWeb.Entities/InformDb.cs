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
    /// Represents a row of InformDb data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class InformDb
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        [DataMember] 
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the AddressTo column.
        /// </summary>
        [DataMember]
        public string AddressTo { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Status column.
        /// </summary>
        [DataMember]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Body column.
        /// </summary>
        [DataMember]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets a string value for the MessageType column.
        /// </summary>
        [DataMember]
        public string MessageType { get; set; }

        /// <summary>
        /// Gets or sets a string value for the AddressFrom column.
        /// </summary>
        [DataMember]
        public string AddressFrom { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the MessageDate column.
        /// </summary>
        [DataMember]
        public DateTime MessageDate { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Subject column.
        /// </summary>
        [DataMember]
        public string Subject { get; set; }
    }
}
