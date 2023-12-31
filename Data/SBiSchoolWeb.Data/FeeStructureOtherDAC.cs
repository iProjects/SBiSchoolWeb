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
    /// FeeStructureOthers data access component. Manages CRUD operations for the FeeStructureOthers table.
    /// </summary>
    public partial class FeeStructureOtherDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the FeeStructureOthers table.
        /// </summary>
        /// <param name="feeStructureOther">A FeeStructureOther object.</param>
        /// <returns>An updated FeeStructureOther object.</returns>
        public FeeStructureOther Create(FeeStructureOther feeStructureOther)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.FeeStructureOthers ([FeeStructureId], [AccountId], [Description], [Amount], [AmountPeriod], [ApplicableTo], [IsDeleted]) " +
                "VALUES(@FeeStructureId, @AccountId, @Description, @Amount, @AmountPeriod, @ApplicableTo, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@FeeStructureId", DbType.Int32, feeStructureOther.FeeStructureId);
                db.AddInParameter(cmd, "@AccountId", DbType.Int32, feeStructureOther.AccountId);
                db.AddInParameter(cmd, "@Description", DbType.String, feeStructureOther.Description);
                db.AddInParameter(cmd, "@Amount", DbType.Currency, feeStructureOther.Amount);
                db.AddInParameter(cmd, "@AmountPeriod", DbType.StringFixedLength, feeStructureOther.AmountPeriod);
                db.AddInParameter(cmd, "@ApplicableTo", DbType.StringFixedLength, feeStructureOther.ApplicableTo);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, feeStructureOther.IsDeleted);

                // Get the primary key value.
                feeStructureOther.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return feeStructureOther;
        }

        /// <summary>
        /// Updates an existing row in the FeeStructureOthers table.
        /// </summary>
        /// <param name="feeStructureOther">A FeeStructureOther entity object.</param>
        public void UpdateById(FeeStructureOther feeStructureOther)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.FeeStructureOthers " +
                "SET " +
                    "[FeeStructureId]=@FeeStructureId, " +
                    "[AccountId]=@AccountId, " +
                    "[Description]=@Description, " +
                    "[Amount]=@Amount, " +
                    "[AmountPeriod]=@AmountPeriod, " +
                    "[ApplicableTo]=@ApplicableTo, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@FeeStructureId", DbType.Int32, feeStructureOther.FeeStructureId);
                db.AddInParameter(cmd, "@AccountId", DbType.Int32, feeStructureOther.AccountId);
                db.AddInParameter(cmd, "@Description", DbType.String, feeStructureOther.Description);
                db.AddInParameter(cmd, "@Amount", DbType.Currency, feeStructureOther.Amount);
                db.AddInParameter(cmd, "@AmountPeriod", DbType.StringFixedLength, feeStructureOther.AmountPeriod);
                db.AddInParameter(cmd, "@ApplicableTo", DbType.StringFixedLength, feeStructureOther.ApplicableTo);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, feeStructureOther.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, feeStructureOther.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the FeeStructureOthers table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.FeeStructureOthers " +
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
        /// Returns a row from the FeeStructureOthers table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A FeeStructureOther object with data populated from the database.</returns>
        public FeeStructureOther SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [FeeStructureId], [AccountId], [Description], [Amount], [AmountPeriod], [ApplicableTo]" +
                        ", [IsDeleted] " +
                "FROM dbo.FeeStructureOthers  " +
                "WHERE [Id]=@Id ";

            FeeStructureOther feeStructureOther = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new FeeStructureOther
                        feeStructureOther = new FeeStructureOther();

                        // Read values.
                        feeStructureOther.Id = base.GetDataValue<int>(dr, "Id");
                        feeStructureOther.FeeStructureId = base.GetDataValue<int>(dr, "FeeStructureId");
                        feeStructureOther.AccountId = base.GetDataValue<int>(dr, "AccountId");
                        feeStructureOther.Description = base.GetDataValue<string>(dr, "Description");
                        feeStructureOther.Amount = base.GetDataValue<decimal>(dr, "Amount");
                        feeStructureOther.AmountPeriod = Convert.ToChar(base.GetDataValue<string>(dr, "AmountPeriod"));
                        feeStructureOther.ApplicableTo = Convert.ToChar(base.GetDataValue<string>(dr, "ApplicableTo"));
                        feeStructureOther.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return feeStructureOther;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the FeeStructureOthers table.
        /// </summary>
        /// <returns>A collection of FeeStructureOther objects.</returns>		
        public List<FeeStructureOther> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [FeeStructureId], [AccountId], [Description], [Amount], [AmountPeriod], [ApplicableTo]" +
                        ", [IsDeleted] " +
                "FROM dbo.FeeStructureOthers ";

            List<FeeStructureOther> result = new List<FeeStructureOther>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new FeeStructureOther
                        FeeStructureOther feeStructureOther = new FeeStructureOther();

                        // Read values.
                        feeStructureOther.Id = base.GetDataValue<int>(dr, "Id");
                        feeStructureOther.FeeStructureId = base.GetDataValue<int>(dr, "FeeStructureId");
                        feeStructureOther.AccountId = base.GetDataValue<int>(dr, "AccountId");
                        feeStructureOther.Description = base.GetDataValue<string>(dr, "Description");
                        feeStructureOther.Amount = base.GetDataValue<decimal>(dr, "Amount");
                        feeStructureOther.AmountPeriod = Convert.ToChar(base.GetDataValue<string>(dr, "AmountPeriod"));
                        feeStructureOther.ApplicableTo = Convert.ToChar(base.GetDataValue<string>(dr, "ApplicableTo"));
                        feeStructureOther.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(feeStructureOther);
                    }
                }
            }

            return result;
        }
    }
}

