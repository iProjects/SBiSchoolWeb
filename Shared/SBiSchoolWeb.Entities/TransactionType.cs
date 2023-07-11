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
    /// Represents a row of TransactionType data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class TransactionType
    {
        /// <summary>
        /// Gets or sets a int value for the Id column.
        /// </summary>
        [DataMember] 
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a string value for the ShortCode column.
        /// </summary>
        [DataMember]
        public string ShortCode { get; set; }

        /// <summary>
        /// Gets or sets a string value for the Description column.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a char value for the DebitCredit column.
        /// </summary>
        [DataMember]
        public char DebitCredit { get; set; }

        /// <summary>
        /// Gets or sets a char value for the TxnTypeView column.
        /// </summary>
        [DataMember]
        public char TxnTypeView { get; set; }

        /// <summary>
        /// Gets or sets a char value for the CommissionType column.
        /// </summary>
        [DataMember]
        public char CommissionType { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the FlatRate column.
        /// </summary>
        [DataMember]
        public decimal FlatRate { get; set; }

        /// <summary>
        /// Gets or sets a double value for the PercentageRate column.
        /// </summary>
        [DataMember]
        public double PercentageRate { get; set; }

        /// <summary>
        /// Gets or sets a char value for the DialogFlag column.
        /// </summary>
        [DataMember]
        public char DialogFlag { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the UseDefaultAmount column.
        /// </summary>
        [DataMember]
        public bool UseDefaultAmount { get; set; }

        /// <summary>
        /// Gets or sets a decimal value for the DefaultAmount column.
        /// </summary>
        [DataMember]
        public decimal DefaultAmount { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the UseDefaultCreditAccount column.
        /// </summary>
        [DataMember]
        public bool UseDefaultCreditAccount { get; set; }

        /// <summary>
        /// Gets or sets a int value for the DefaultCreditAccount column.
        /// </summary>
        [DataMember]
        public int DefaultCreditAccount { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the UseDefaultDebitAccount column.
        /// </summary>
        [DataMember]
        public bool UseDefaultDebitAccount { get; set; }

        /// <summary>
        /// Gets or sets a int value for the DefaultDebitAccount column.
        /// </summary>
        [DataMember]
        public int DefaultDebitAccount { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the UseDefaultCreditNarrative column.
        /// </summary>
        [DataMember]
        public bool UseDefaultCreditNarrative { get; set; }

        /// <summary>
        /// Gets or sets a string value for the DefaultCreditNarrative column.
        /// </summary>
        [DataMember]
        public string DefaultCreditNarrative { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the UseDefaultDebitNarrative column.
        /// </summary>
        [DataMember]
        public bool UseDefaultDebitNarrative { get; set; }

        /// <summary>
        /// Gets or sets a string value for the DefaultDebitNarrative column.
        /// </summary>
        [DataMember]
        public string DefaultDebitNarrative { get; set; }

        /// <summary>
        /// Gets or sets a char value for the ScreenViewCreditAccountField column.
        /// </summary>
        [DataMember]
        public char ScreenViewCreditAccountField { get; set; }

        /// <summary>
        /// Gets or sets a char value for the ScreenViewCreditNarrativeField column.
        /// </summary>
        [DataMember]
        public char ScreenViewCreditNarrativeField { get; set; }

        /// <summary>
        /// Gets or sets a char value for the ScreenViewDebitAccountField column.
        /// </summary>
        [DataMember]
        public char ScreenViewDebitAccountField { get; set; }

        /// <summary>
        /// Gets or sets a char value for the ScreenViewDebitNarrativeField column.
        /// </summary>
        [DataMember]
        public char ScreenViewDebitNarrativeField { get; set; }

        /// <summary>
        /// Gets or sets a char value for the ScreenViewAmountField column.
        /// </summary>
        [DataMember]
        public char ScreenViewAmountField { get; set; }

        /// <summary>
        /// Gets or sets a char value for the ScreenViewModeofPaymentField column.
        /// </summary>
        [DataMember]
        public char ScreenViewModeofPaymentField { get; set; }

        /// <summary>
        /// Gets or sets a char value for the ScreenViewValueDateField column.
        /// </summary>
        [DataMember]
        public char ScreenViewValueDateField { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the PrintReceipt column.
        /// </summary>
        [DataMember]
        public bool PrintReceipt { get; set; }

        /// <summary>
        /// Gets or sets a string value for the ReceiptLayout column.
        /// </summary>
        [DataMember]
        public string ReceiptLayout { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the PrintReceiptPrompt column.
        /// </summary>
        [DataMember]
        public bool PrintReceiptPrompt { get; set; }

        /// <summary>
        /// Gets or sets a char value for the ForcePost column.
        /// </summary>
        [DataMember]
        public char ForcePost { get; set; }

        /// <summary>
        /// Gets or sets a char value for the NarrativeFlag column.
        /// </summary>
        [DataMember]
        public char NarrativeFlag { get; set; }

        /// <summary>
        /// Gets or sets a char value for the StatementFlag column.
        /// </summary>
        [DataMember]
        public char StatementFlag { get; set; }

        /// <summary>
        /// Gets or sets a int value for the ValueDays column.
        /// </summary>
        [DataMember]
        public int ValueDays { get; set; }

        /// <summary>
        /// Gets or sets a char value for the Status column.
        /// </summary>
        [DataMember]
        public char Status { get; set; }

        /// <summary>
        /// Gets or sets a bool value for the IsDeleted column.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
