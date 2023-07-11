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
    /// Represents a row of webpages_OAuthMembership data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class webpages_OAuthMembership
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
