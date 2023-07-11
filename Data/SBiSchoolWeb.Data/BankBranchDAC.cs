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
    /// BankBranches data access component. Manages CRUD operations for the BankBranches table.
    /// </summary>
    public partial class BankBranchDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the BankBranches table.
        /// </summary>
        /// <param name="bankBranch">A BankBranch object.</param>
        /// <returns>An updated BankBranch object.</returns>
        public BankBranch Create(BankBranch bankBranch)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.BankBranches ([BankSortCode], [BranchCode], [BankCode], [BranchName], [IsDeleted]) " +
                "VALUES(@BankSortCode, @BranchCode, @BankCode, @BranchName, @IsDeleted);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@BankSortCode", DbType.String, bankBranch.BankSortCode);
                db.AddInParameter(cmd, "@BranchCode", DbType.String, bankBranch.BranchCode);
                db.AddInParameter(cmd, "@BankCode", DbType.String, bankBranch.BankCode);
                db.AddInParameter(cmd, "@BranchName", DbType.String, bankBranch.BranchName);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, bankBranch.IsDeleted);

                db.ExecuteNonQuery(cmd);
            }

            return bankBranch;
        }

        /// <summary>
        /// Updates an existing row in the BankBranches table.
        /// </summary>
        /// <param name="bankBranch">A BankBranch entity object.</param>
        public void UpdateById(BankBranch bankBranch)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.BankBranches " +
                "SET " +
                    "[BranchCode]=@BranchCode, " +
                    "[BankCode]=@BankCode, " +
                    "[BranchName]=@BranchName, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [BankSortCode]=@BankSortCode ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@BranchCode", DbType.String, bankBranch.BranchCode);
                db.AddInParameter(cmd, "@BankCode", DbType.String, bankBranch.BankCode);
                db.AddInParameter(cmd, "@BranchName", DbType.String, bankBranch.BranchName);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, bankBranch.IsDeleted);
                db.AddInParameter(cmd, "@BankSortCode", DbType.String, bankBranch.BankSortCode);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the BankBranches table.
        /// </summary>
        /// <param name="bankSortCode">A bankSortCode value.</param>
        public void DeleteById(string bankSortCode)
        {
            const string SQL_STATEMENT = "DELETE dbo.BankBranches " +
                                         "WHERE [BankSortCode]=@BankSortCode ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@BankSortCode", DbType.String, bankSortCode);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the BankBranches table.
        /// </summary>
        /// <param name="bankSortCode">A BankSortCode value.</param>
        /// <returns>A BankBranch object with data populated from the database.</returns>
        public BankBranch SelectById(string bankSortCode)
        {
            const string SQL_STATEMENT =
                "SELECT [BankSortCode], [BranchCode], [BankCode], [BranchName], [IsDeleted] " +
                "FROM dbo.BankBranches  " +
                "WHERE [BankSortCode]=@BankSortCode ";

            BankBranch bankBranch = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@BankSortCode", DbType.String, bankSortCode);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new BankBranch
                        bankBranch = new BankBranch();

                        // Read values.
                        bankBranch.BankSortCode = base.GetDataValue<string>(dr, "BankSortCode");
                        bankBranch.BranchCode = base.GetDataValue<string>(dr, "BranchCode");
                        bankBranch.BankCode = base.GetDataValue<string>(dr, "BankCode");
                        bankBranch.BranchName = base.GetDataValue<string>(dr, "BranchName");
                        bankBranch.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return bankBranch;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the BankBranches table.
        /// </summary>
        /// <returns>A collection of BankBranch objects.</returns>		
        public List<BankBranch> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [BankSortCode], [BranchCode], [BankCode], [BranchName], [IsDeleted] " +
                "FROM dbo.BankBranches ";

            List<BankBranch> result = new List<BankBranch>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new BankBranch
                        BankBranch bankBranch = new BankBranch();

                        // Read values.
                        bankBranch.BankSortCode = base.GetDataValue<string>(dr, "BankSortCode");
                        bankBranch.BranchCode = base.GetDataValue<string>(dr, "BranchCode");
                        bankBranch.BankCode = base.GetDataValue<string>(dr, "BankCode");
                        bankBranch.BranchName = base.GetDataValue<string>(dr, "BranchName");
                        bankBranch.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(bankBranch);
                    }
                }
            }

            return result;
        }
    }
}

