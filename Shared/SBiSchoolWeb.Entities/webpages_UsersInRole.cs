//====================================================================================================
// Base code generated with Inertia: BE Gen (Build 2.5.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 06/21/2014 13:16:10 
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
    /// Represents a row of webpages_UsersInRole data.
    /// </summary>
    [DataContract]
    public partial class webpages_UsersInRole
    {
        /// <summary>
        /// Gets or sets a int value for the UserId column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets a int value for the RoleId column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int RoleId { get; set; }
    }
}
