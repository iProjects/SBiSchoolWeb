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
    /// RuleSet data access component. Manages CRUD operations for the RuleSet table.
    /// </summary>
    public partial class RuleSetDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the RuleSet table.
        /// </summary>
        /// <param name="ruleSet">A RuleSet object.</param>
        /// <returns>An updated RuleSet object.</returns>
        public RuleSet Create(RuleSet ruleSet)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.RuleSet ([Name], [MajorVersion], [MinorVersion], [RuleSet], [Status], [AssemblyPath], [ActivityName], [ModifiedDate], [IsDeleted]) " +
                "VALUES(@Name, @MajorVersion, @MinorVersion, @RuleSet, @Status, @AssemblyPath, @ActivityName, @ModifiedDate, @IsDeleted);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Name", DbType.String, ruleSet.Name);
                db.AddInParameter(cmd, "@MajorVersion", DbType.Int32, ruleSet.MajorVersion);
                db.AddInParameter(cmd, "@MinorVersion", DbType.Int32, ruleSet.MinorVersion);
                db.AddInParameter(cmd, "@RuleSet", DbType.String, ruleSet._RuleSet);
                db.AddInParameter(cmd, "@Status", DbType.Int16, ruleSet.Status);
                db.AddInParameter(cmd, "@AssemblyPath", DbType.String, ruleSet.AssemblyPath);
                db.AddInParameter(cmd, "@ActivityName", DbType.String, ruleSet.ActivityName);
                db.AddInParameter(cmd, "@ModifiedDate", DbType.DateTime, ruleSet.ModifiedDate);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, ruleSet.IsDeleted);

                db.ExecuteNonQuery(cmd);
            }

            return ruleSet;
        }

        /// <summary>
        /// Updates an existing row in the RuleSet table.
        /// </summary>
        /// <param name="ruleSet">A RuleSet entity object.</param>
        public void UpdateById(RuleSet ruleSet)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.RuleSet " +
                "SET " +
                    "[RuleSet]=@RuleSet, " +
                    "[Status]=@Status, " +
                    "[AssemblyPath]=@AssemblyPath, " +
                    "[ActivityName]=@ActivityName, " +
                    "[ModifiedDate]=@ModifiedDate, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Name]=@Name " +
                      "AND [MajorVersion]=@MajorVersion " +
                      "AND [MinorVersion]=@MinorVersion ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@RuleSet", DbType.String, ruleSet._RuleSet);
                db.AddInParameter(cmd, "@Status", DbType.Int16, ruleSet.Status);
                db.AddInParameter(cmd, "@AssemblyPath", DbType.String, ruleSet.AssemblyPath);
                db.AddInParameter(cmd, "@ActivityName", DbType.String, ruleSet.ActivityName);
                db.AddInParameter(cmd, "@ModifiedDate", DbType.DateTime, ruleSet.ModifiedDate);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, ruleSet.IsDeleted);
                db.AddInParameter(cmd, "@Name", DbType.String, ruleSet.Name);
                db.AddInParameter(cmd, "@MajorVersion", DbType.Int32, ruleSet.MajorVersion);
                db.AddInParameter(cmd, "@MinorVersion", DbType.Int32, ruleSet.MinorVersion);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the RuleSet table.
        /// </summary>
        /// <param name="name">A name value.</param>
        public void DeleteById(string name)
        {
            const string SQL_STATEMENT = "DELETE dbo.RuleSet " +
                                         "WHERE [Name]=@Name ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Name", DbType.String, name);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the RuleSet table.
        /// </summary>
        /// <param name="name">A Name value.</param>
        /// <param name="majorVersion">A MajorVersion value.</param>
        /// <param name="minorVersion">A MinorVersion value.</param>
        /// <returns>A RuleSet object with data populated from the database.</returns>
        public RuleSet SelectById(string name, int majorVersion, int minorVersion)
        {
            const string SQL_STATEMENT =
                "SELECT [Name], [MajorVersion], [MinorVersion], [RuleSet], [Status], [AssemblyPath], [ActivityName]" +
                        ", [ModifiedDate], [IsDeleted] " +
                "FROM dbo.RuleSet  " +
                "WHERE [Name]=@Name " +
                      "AND [MajorVersion]=@MajorVersion " +
                      "AND [MinorVersion]=@MinorVersion ";

            RuleSet ruleSet = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Name", DbType.String, name);
                db.AddInParameter(cmd, "@MajorVersion", DbType.Int32, majorVersion);
                db.AddInParameter(cmd, "@MinorVersion", DbType.Int32, minorVersion);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new RuleSet
                        ruleSet = new RuleSet();

                        // Read values.
                        ruleSet.Name = base.GetDataValue<string>(dr, "Name");
                        ruleSet.MajorVersion = base.GetDataValue<int>(dr, "MajorVersion");
                        ruleSet.MinorVersion = base.GetDataValue<int>(dr, "MinorVersion");
                        ruleSet._RuleSet = base.GetDataValue<string>(dr, "RuleSet");
                        ruleSet.Status = base.GetDataValue<short>(dr, "Status");
                        ruleSet.AssemblyPath = base.GetDataValue<string>(dr, "AssemblyPath");
                        ruleSet.ActivityName = base.GetDataValue<string>(dr, "ActivityName");
                        ruleSet.ModifiedDate = base.GetDataValue<DateTime>(dr, "ModifiedDate");
                        ruleSet.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return ruleSet;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the RuleSet table.
        /// </summary>
        /// <returns>A collection of RuleSet objects.</returns>		
        public List<RuleSet> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Name], [MajorVersion], [MinorVersion], [RuleSet], [Status], [AssemblyPath], [ActivityName]" +
                        ", [ModifiedDate], [IsDeleted] " +
                "FROM dbo.RuleSet ";

            List<RuleSet> result = new List<RuleSet>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new RuleSet
                        RuleSet ruleSet = new RuleSet();

                        // Read values.
                        ruleSet.Name = base.GetDataValue<string>(dr, "Name");
                        ruleSet.MajorVersion = base.GetDataValue<int>(dr, "MajorVersion");
                        ruleSet.MinorVersion = base.GetDataValue<int>(dr, "MinorVersion");
                        ruleSet._RuleSet = base.GetDataValue<string>(dr, "RuleSet");
                        ruleSet.Status = base.GetDataValue<short>(dr, "Status");
                        ruleSet.AssemblyPath = base.GetDataValue<string>(dr, "AssemblyPath");
                        ruleSet.ActivityName = base.GetDataValue<string>(dr, "ActivityName");
                        ruleSet.ModifiedDate = base.GetDataValue<DateTime>(dr, "ModifiedDate");
                        ruleSet.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(ruleSet);
                    }
                }
            }

            return result;
        }
    }
}
