//====================================================================================================
// Base code generated with Motion: BC Gen (Build 2.2.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 06/19/2014 14:01:21 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SBiSchoolWeb.Entities;
using SBiSchoolWeb.Data;


namespace SBiSchoolWeb.Business
{
    /// <summary>
    /// Accounting business component.
    /// </summary>
    public partial class AccountingComponent
    {
        /// <summary>
        /// GetAllAccounts business method. 
        /// </summary>
        /// <returns>Returns a List<Account> object.</returns>
        public List<Account> GetAllAccounts()
        {
            List<Account> result = default(List<Account>);

            // Data access component declarations.
            AccountDAC accountDAC = new AccountDAC();

            // Step 1 - Calling Select on AccountDAC.
            result = accountDAC.Select();
            return result;

        }

        /// <summary>
        /// GetAllAccountTypes business method. 
        /// </summary>
        /// <returns>Returns a List<AccountType> object.</returns>
        public List<AccountType> GetAllAccountTypes()
        {
            List<AccountType> result = default(List<AccountType>);

            // Data access component declarations.
            AccountTypeDAC accountTypeDAC = new AccountTypeDAC();

            // Step 1 - Calling Select on AccountTypeDAC.
            result = accountTypeDAC.Select();
            return result;

        }

        /// <summary>
        /// GetAllChartofAccounts business method. 
        /// </summary>
        /// <returns>Returns a List<COA> object.</returns>
        public List<COA> GetAllChartofAccounts()
        {
            List<COA> result = default(List<COA>);

            // Data access component declarations.
            COADAC cOADAC = new COADAC();

            // Step 1 - Calling Select on COADAC.
            result = cOADAC.Select();
            return result;

        }

        /// <summary>
        /// GetAllTransactionTypes business method. 
        /// </summary>
        /// <returns>Returns a List<TransactionType> object.</returns>
        public List<TransactionType> GetAllTransactionTypes()
        {
            List<TransactionType> result = default(List<TransactionType>);

            // Data access component declarations.
            TransactionTypeDAC TransactionTypeDAC = new TransactionTypeDAC();

            // Step 1 - Calling Select on TransactionTypeDAC.
            result = TransactionTypeDAC.Select();
            return result;

        }

        /// <summary>
        /// GetAllTransactionsAuthorizations business method. 
        /// </summary>
        /// <returns>Returns a List<TransactionsAuthorization> object.</returns>
        public List<TransactionsAuthorization> GetAllTransactionsAuthorizations()
        {
            List<TransactionsAuthorization> result = default(List<TransactionsAuthorization>);

            // Data access component declarations.
            TransactionsAuthorizationDAC TransactionsAuthorizationDAC = new TransactionsAuthorizationDAC();

            // Step 1 - Calling Select on TransactionsAuthorizationDAC.
            result = TransactionsAuthorizationDAC.Select();
            return result;

        }

        /// <summary>
        /// GetAllTransactionsAuthorizations business method. 
        /// </summary>
        /// <returns>Returns a List<TransactionsAuthorization> object.</returns>
        public List<Transaction> GetAllTransactions()
        {
            List<Transaction> result = default(List<Transaction>);

            // Data access component declarations.
            TransactionDAC TransactionDAC = new TransactionDAC();

            // Step 1 - Calling Select on TransactionDAC.
            result = TransactionDAC.Select();
            return result;

        }

        /// <summary>
        /// GetAllBanks business method. 
        /// </summary>
        /// <returns>Returns a List<Bank> object.</returns>
        public List<Bank> GetAllBanks()
        {
            List<Bank> result = default(List<Bank>);

            // Data access component declarations.
            BankDAC BankDAC = new BankDAC();

            // Step 1 - Calling Select on BankDAC.
            result = BankDAC.Select();
            return result;

        }


        /// <summary>
        /// GetAllEnquiries business method. 
        /// </summary>
        /// <returns>Returns a List<Transaction> object.</returns>
        public List<Transaction> GetAllEnquiries()
        {
            List<Transaction> result = default(List<Transaction>);

            // Data access component declarations.
            TransactionDAC TransactionDAC = new TransactionDAC();

            // Step 1 - Calling Select on TransactionDAC.
            result = TransactionDAC.Select();
            return result;

        }

        /// <summary>
        /// GetAllPayFees business method. 
        /// </summary>
        /// <returns>Returns a List<Transaction> object.</returns>
        public List<Transaction> GetAllPayFees()
        {
            List<Transaction> result = default(List<Transaction>);

            // Data access component declarations.
            TransactionDAC TransactionDAC = new TransactionDAC();

            // Step 1 - Calling Select on TransactionDAC.
            result = TransactionDAC.Select();
            return result;
        }

        /// <summary>
        /// GetAllGeneralPosts business method. 
        /// </summary>
        /// <returns>Returns a List<Transaction> object.</returns>
        public List<Transaction> GetAllGeneralPosts()
        {
            List<Transaction> result = default(List<Transaction>);

            // Data access component declarations.
            TransactionDAC TransactionDAC = new TransactionDAC();

            // Step 1 - Calling Select on TransactionDAC.
            result = TransactionDAC.Select();
            return result;

        }

        /// <summary>
        /// GetAllPL_Level1s business method. 
        /// </summary>
        /// <returns>Returns a List<PL_Level1> object.</returns>
        public List<PL_Level1> GetAllPL_Level1s()
        {
            List<PL_Level1> result = default(List<PL_Level1>);

            // Data access component declarations.
            PL_Level1DAC PL_Level1DAC = new PL_Level1DAC();

            // Step 1 - Calling Select on PL_Level1DAC.
            result = PL_Level1DAC.Select();
            return result;

        }

        /// <summary>
        /// GetAllPL_Level2s business method. 
        /// </summary>
        /// <returns>Returns a List<PL_Level2> object.</returns>
        public List<PL_Level2> GetAllPL_Level2s()
        {
            List<PL_Level2> result = default(List<PL_Level2>);

            // Data access component declarations.
            PL_Level2DAC PL_Level2DAC = new PL_Level2DAC();

            // Step 1 - Calling Select on PL_Level2DAC.
            result = PL_Level2DAC.Select();
            return result;

        }

        /// <summary>
        /// GetAllBS_Level1s business method. 
        /// </summary>
        /// <returns>Returns a List<BS_Level1> object.</returns>
        public List<BS_Level1> GetAllBS_Level1s()
        {
            List<BS_Level1> result = default(List<BS_Level1>);

            // Data access component declarations.
            BS_Level1DAC BS_Level1DAC = new BS_Level1DAC();

            // Step 1 - Calling Select on BS_Level1DAC.
            result = BS_Level1DAC.Select();
            return result;

        }

        /// <summary>
        /// GetAllBS_Level2s business method. 
        /// </summary>
        /// <returns>Returns a List<BS_Level2> object.</returns>
        public List<BS_Level2> GetAllBS_Level2s()
        {
            List<BS_Level2> result = default(List<BS_Level2>);

            // Data access component declarations.
            BS_Level2DAC BS_Level2DAC = new BS_Level2DAC();

            // Step 1 - Calling Select on BS_Level2DAC.
            result = BS_Level2DAC.Select();
            return result;

        }








































































    }
}






















