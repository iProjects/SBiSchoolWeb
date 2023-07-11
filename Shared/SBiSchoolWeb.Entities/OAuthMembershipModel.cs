//====================================================================================================
// Base code generated with Inertia: BE Gen (Build 2.5.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 06/25/2014 06:53:29 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SBiSchoolWeb.Entities
{
    /// <summary>
    /// Represents a row of webpages_OAuthMembership data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class OAuthMembershipModel
    {
        /// <summary>
        /// Gets or sets a string value for the Provider column.
        /// </summary>
        [DataMember]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets a string value for the ProviderUserId column.
        /// </summary>
        [DataMember]
        public string ProviderUserId { get; set; }

        /// <summary>
        /// Gets or sets a int value for the UserId column.
        /// </summary>
        [DataMember]
        public int UserId { get; set; }
    }
}
