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
    /// Represents a row of SBSchoolMessage data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class SBSchoolMessage
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        [DataMember] 
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a int value for the MemberId column.
        /// </summary>
        [DataMember]
        public int MemberId { get; set; }

        /// <summary>
        /// Gets or sets a string value for the SenderTelno column.
        /// </summary>
        [DataMember]
        public string SenderTelno { get; set; }

        /// <summary>
        /// Gets or sets a string value for the CustomerTelno column.
        /// </summary>
        [DataMember]
        public string CustomerTelno { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Command column.
        /// </summary>
        [DataMember]
        public string Command { get; set; }

        /// <summary>
        /// Gets or sets a int value for the MessageType column.
        /// </summary>
        [DataMember]
        public int MessageType { get; set; }

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
        /// Gets or sets a DateTime value for the MessageDate column.
        /// </summary>
        [DataMember]
        public DateTime MessageDate { get; set; }

        /// <summary>
        /// Gets or sets a int value for the AccountId column.
        /// </summary>
        [DataMember]
        public int AccountId { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the StartDate column.
        /// </summary>
        [DataMember]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the EndDate column.
        /// </summary>
        [DataMember]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the Amount column.
        /// </summary>
        [DataMember]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets a string value for the HM_Param column.
        /// </summary>
        [DataMember]
        public string HM_Param { get; set; }

        /// <summary>
        /// Gets or sets a string value for the BE_AccLabel column.
        /// </summary>
        [DataMember]
        public string BE_AccLabel { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the ST_StartDate column.
        /// </summary>
        [DataMember]
        public DateTime ST_StartDate { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the ST_EndDate column.
        /// </summary>
        [DataMember]
        public DateTime ST_EndDate { get; set; }

        /// <summary>
        /// Gets or sets a int value for the OfferId column.
        /// </summary>
        [DataMember]
        public int OfferId { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Email column.
        /// </summary>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Pwd column.
        /// </summary>
        [DataMember]
        public string Pwd { get; set; }

        /// <summary>
        /// Gets or sets a string value for the NotificationMethod column.
        /// </summary>
        [DataMember]
        public string NotificationMethod { get; set; }

        /// <summary>
        /// Gets or sets a int value for the MO_Term column.
        /// </summary>
        [DataMember]
        public int MO_Term { get; set; }

        /// <summary>
        /// Gets or sets a double value for the MO_Interest column.
        /// </summary>
        [DataMember]
        public double MO_Interest { get; set; }

        /// <summary>
        /// Gets or sets a string value for the CP_NewPassword column.
        /// </summary>
        [DataMember]
        public string CP_NewPassword { get; set; }

        /// <summary>
        /// Gets or sets a string value for the CP_ConfirmPassword column.
        /// </summary>
        [DataMember]
        public string CP_ConfirmPassword { get; set; }

        /// <summary>
        /// Gets or sets a string value for the NationalID column.
        /// </summary>
        [DataMember]
        public string NationalID { get; set; }

        /// <summary>
        /// Gets or sets a string value for the MpesaRef column.
        /// </summary>
        [DataMember]
        public string MpesaRef { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the MpesaSentDate column.
        /// </summary>
        [DataMember]
        public DateTime MpesaSentDate { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the MpesaBal column.
        /// </summary>
        [DataMember]
        public decimal MpesaBal { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Exception column.
        /// </summary>
        [DataMember]
        public string Exception { get; set; }
    }
}
