//====================================================================================================
// Base code generated with Momentum: DAC Gen (Build 2.5.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 12/31/2014 06:25:02 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SBiSchoolWeb.Entities;

namespace SBiSchoolWeb.Data
{
    /// <summary>
    /// Accounts data access component. Manages CRUD operations for the Accounts table.
    /// </summary>
    public partial class AccountDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Accounts table.
        /// </summary>
        /// <param name="account">A Account object.</param>
        /// <returns>An updated Account object.</returns>
        public Account Create(Account account)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Accounts ([CustomerId], [AccountName], [AccountNo], [AccountTypeId], [COAId], [BankBranch], [SchoolBranch], [BookBalance], [ClearedBalance], [InterestRate], [AccruedInt], [Limit], [PassFlag], [Bal30], [Bal60], [Bal90], [BalOver90], [IntRate30], [IntRate60], [IntRate90], [IntRateOver90], [Closed], [IsDeleted]) " +
                "VALUES(@CustomerId, @AccountName, @AccountNo, @AccountTypeId, @COAId, @BankBranch, @SchoolBranch, @BookBalance, @ClearedBalance, @InterestRate, @AccruedInt, @Limit, @PassFlag, @Bal30, @Bal60, @Bal90, @BalOver90, @IntRate30, @IntRate60, @IntRate90, @IntRateOver90, @Closed, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@CustomerId", DbType.Int32, account.CustomerId);
                db.AddInParameter(cmd, "@AccountName", DbType.String, account.AccountName);
                db.AddInParameter(cmd, "@AccountNo", DbType.String, account.AccountNo);
                db.AddInParameter(cmd, "@AccountTypeId", DbType.Int32, account.AccountTypeId);
                db.AddInParameter(cmd, "@COAId", DbType.Int32, account.COAId);
                db.AddInParameter(cmd, "@BankBranch", DbType.Int32, account.BankBranch);
                db.AddInParameter(cmd, "@SchoolBranch", DbType.Int32, account.SchoolBranch);
                db.AddInParameter(cmd, "@BookBalance", DbType.Currency, account.BookBalance);
                db.AddInParameter(cmd, "@ClearedBalance", DbType.Currency, account.ClearedBalance);
                db.AddInParameter(cmd, "@InterestRate", DbType.Double, account.InterestRate);
                db.AddInParameter(cmd, "@AccruedInt", DbType.Currency, account.AccruedInt);
                db.AddInParameter(cmd, "@Limit", DbType.Currency, account.Limit);
                db.AddInParameter(cmd, "@PassFlag", DbType.String, account.PassFlag);
                db.AddInParameter(cmd, "@Bal30", DbType.Currency, account.Bal30);
                db.AddInParameter(cmd, "@Bal60", DbType.Currency, account.Bal60);
                db.AddInParameter(cmd, "@Bal90", DbType.Currency, account.Bal90);
                db.AddInParameter(cmd, "@BalOver90", DbType.Currency, account.BalOver90);
                db.AddInParameter(cmd, "@IntRate30", DbType.Double, account.IntRate30);
                db.AddInParameter(cmd, "@IntRate60", DbType.Double, account.IntRate60);
                db.AddInParameter(cmd, "@IntRate90", DbType.Double, account.IntRate90);
                db.AddInParameter(cmd, "@IntRateOver90", DbType.Double, account.IntRateOver90);
                db.AddInParameter(cmd, "@Closed", DbType.Boolean, account.Closed);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, account.IsDeleted);

                // Get the primary key value.
                account.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return account;
        }

        /// <summary>
        /// Updates an existing row in the Accounts table.
        /// </summary>
        /// <param name="account">A Account entity object.</param>
        public void UpdateById(Account account)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Accounts " +
                "SET " +
                    "[CustomerId]=@CustomerId, " +
                    "[AccountName]=@AccountName, " +
                    "[AccountNo]=@AccountNo, " +
                    "[AccountTypeId]=@AccountTypeId, " +
                    "[COAId]=@COAId, " +
                    "[BankBranch]=@BankBranch, " +
                    "[SchoolBranch]=@SchoolBranch, " +
                    "[BookBalance]=@BookBalance, " +
                    "[ClearedBalance]=@ClearedBalance, " +
                    "[InterestRate]=@InterestRate, " +
                    "[AccruedInt]=@AccruedInt, " +
                    "[Limit]=@Limit, " +
                    "[PassFlag]=@PassFlag, " +
                    "[Bal30]=@Bal30, " +
                    "[Bal60]=@Bal60, " +
                    "[Bal90]=@Bal90, " +
                    "[BalOver90]=@BalOver90, " +
                    "[IntRate30]=@IntRate30, " +
                    "[IntRate60]=@IntRate60, " +
                    "[IntRate90]=@IntRate90, " +
                    "[IntRateOver90]=@IntRateOver90, " +
                    "[Closed]=@Closed, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@CustomerId", DbType.Int32, account.CustomerId);
                db.AddInParameter(cmd, "@AccountName", DbType.String, account.AccountName);
                db.AddInParameter(cmd, "@AccountNo", DbType.String, account.AccountNo);
                db.AddInParameter(cmd, "@AccountTypeId", DbType.Int32, account.AccountTypeId);
                db.AddInParameter(cmd, "@COAId", DbType.Int32, account.COAId);
                db.AddInParameter(cmd, "@BankBranch", DbType.Int32, account.BankBranch);
                db.AddInParameter(cmd, "@SchoolBranch", DbType.Int32, account.SchoolBranch);
                db.AddInParameter(cmd, "@BookBalance", DbType.Currency, account.BookBalance);
                db.AddInParameter(cmd, "@ClearedBalance", DbType.Currency, account.ClearedBalance);
                db.AddInParameter(cmd, "@InterestRate", DbType.Double, account.InterestRate);
                db.AddInParameter(cmd, "@AccruedInt", DbType.Currency, account.AccruedInt);
                db.AddInParameter(cmd, "@Limit", DbType.Currency, account.Limit);
                db.AddInParameter(cmd, "@PassFlag", DbType.String, account.PassFlag);
                db.AddInParameter(cmd, "@Bal30", DbType.Currency, account.Bal30);
                db.AddInParameter(cmd, "@Bal60", DbType.Currency, account.Bal60);
                db.AddInParameter(cmd, "@Bal90", DbType.Currency, account.Bal90);
                db.AddInParameter(cmd, "@BalOver90", DbType.Currency, account.BalOver90);
                db.AddInParameter(cmd, "@IntRate30", DbType.Double, account.IntRate30);
                db.AddInParameter(cmd, "@IntRate60", DbType.Double, account.IntRate60);
                db.AddInParameter(cmd, "@IntRate90", DbType.Double, account.IntRate90);
                db.AddInParameter(cmd, "@IntRateOver90", DbType.Double, account.IntRateOver90);
                db.AddInParameter(cmd, "@Closed", DbType.Boolean, account.Closed);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, account.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, account.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the Accounts table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.Accounts " +
                                         "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the Accounts table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A Account object with data populated from the database.</returns>
        public Account SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [CustomerId], [AccountName], [AccountNo], [AccountTypeId], [COAId], [BankBranch]" +
                        ", [SchoolBranch], [BookBalance], [ClearedBalance], [InterestRate], [AccruedInt], [Limit]" +
                        ", [PassFlag], [Bal30], [Bal60], [Bal90], [BalOver90], [IntRate30], [IntRate60], [IntRate90]" +
                        ", [IntRateOver90], [Closed], [IsDeleted] " +
                "FROM dbo.Accounts  " +
                "WHERE [Id]=@Id ";

            Account account = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Account
                        account = new Account();

                        // Read values.
                        account.Id = base.GetDataValue<int>(dr, "Id");
                        account.CustomerId = base.GetDataValue<int>(dr, "CustomerId");
                        account.AccountName = base.GetDataValue<string>(dr, "AccountName");
                        account.AccountNo = base.GetDataValue<string>(dr, "AccountNo");
                        account.AccountTypeId = base.GetDataValue<int>(dr, "AccountTypeId");
                        account.COAId = base.GetDataValue<int>(dr, "COAId");
                        account.BankBranch = base.GetDataValue<int>(dr, "BankBranch");
                        account.SchoolBranch = base.GetDataValue<int>(dr, "SchoolBranch");
                        account.BookBalance = base.GetDataValue<decimal>(dr, "BookBalance");
                        account.ClearedBalance = base.GetDataValue<decimal>(dr, "ClearedBalance");
                        account.InterestRate = base.GetDataValue<double>(dr, "InterestRate");
                        account.AccruedInt = base.GetDataValue<decimal>(dr, "AccruedInt");
                        account.Limit = base.GetDataValue<decimal>(dr, "Limit");
                        account.PassFlag = base.GetDataValue<string>(dr, "PassFlag");
                        account.Bal30 = base.GetDataValue<decimal>(dr, "Bal30");
                        account.Bal60 = base.GetDataValue<decimal>(dr, "Bal60");
                        account.Bal90 = base.GetDataValue<decimal>(dr, "Bal90");
                        account.BalOver90 = base.GetDataValue<decimal>(dr, "BalOver90");
                        account.IntRate30 = base.GetDataValue<double>(dr, "IntRate30");
                        account.IntRate60 = base.GetDataValue<double>(dr, "IntRate60");
                        account.IntRate90 = base.GetDataValue<double>(dr, "IntRate90");
                        account.IntRateOver90 = base.GetDataValue<double>(dr, "IntRateOver90");
                        account.Closed = base.GetDataValue<bool>(dr, "Closed");
                        account.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return account;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Accounts table.
        /// </summary>
        /// <returns>A collection of Account objects.</returns>		
        public List<Account> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [CustomerId], [AccountName], [AccountNo], [AccountTypeId], [COAId], [BankBranch]" +
                        ", [SchoolBranch], [BookBalance], [ClearedBalance], [InterestRate], [AccruedInt], [Limit]" +
                        ", [PassFlag], [Bal30], [Bal60], [Bal90], [BalOver90], [IntRate30], [IntRate60], [IntRate90]" +
                        ", [IntRateOver90], [Closed], [IsDeleted] " +
                "FROM dbo.Accounts ";

            List<Account> result = new List<Account>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Account
                        Account account = new Account();

                        // Read values.
                        account.Id = base.GetDataValue<int>(dr, "Id");
                        account.CustomerId = base.GetDataValue<int>(dr, "CustomerId");
                        account.AccountName = base.GetDataValue<string>(dr, "AccountName");
                        account.AccountNo = base.GetDataValue<string>(dr, "AccountNo");
                        account.AccountTypeId = base.GetDataValue<int>(dr, "AccountTypeId");
                        account.COAId = base.GetDataValue<int>(dr, "COAId");
                        account.BankBranch = base.GetDataValue<int>(dr, "BankBranch");
                        account.SchoolBranch = base.GetDataValue<int>(dr, "SchoolBranch");
                        account.BookBalance = base.GetDataValue<decimal>(dr, "BookBalance");
                        account.ClearedBalance = base.GetDataValue<decimal>(dr, "ClearedBalance");
                        account.InterestRate = base.GetDataValue<double>(dr, "InterestRate");
                        account.AccruedInt = base.GetDataValue<decimal>(dr, "AccruedInt");
                        account.Limit = base.GetDataValue<decimal>(dr, "Limit");
                        account.PassFlag = base.GetDataValue<string>(dr, "PassFlag");
                        account.Bal30 = base.GetDataValue<decimal>(dr, "Bal30");
                        account.Bal60 = base.GetDataValue<decimal>(dr, "Bal60");
                        account.Bal90 = base.GetDataValue<decimal>(dr, "Bal90");
                        account.BalOver90 = base.GetDataValue<decimal>(dr, "BalOver90");
                        account.IntRate30 = base.GetDataValue<double>(dr, "IntRate30");
                        account.IntRate60 = base.GetDataValue<double>(dr, "IntRate60");
                        account.IntRate90 = base.GetDataValue<double>(dr, "IntRate90");
                        account.IntRateOver90 = base.GetDataValue<double>(dr, "IntRateOver90");
                        account.Closed = base.GetDataValue<bool>(dr, "Closed");
                        account.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(account);
                    }
                }
            }

            return result;
        }
    }
}

