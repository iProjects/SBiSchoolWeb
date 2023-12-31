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
    /// GradingSystems data access component. Manages CRUD operations for the GradingSystems table.
    /// </summary>
    public partial class GradingSystemDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the GradingSystems table.
        /// </summary>
        /// <param name="gradingSystem">A GradingSystem object.</param>
        /// <returns>An updated GradingSystem object.</returns>
        public GradingSystem Create(GradingSystem gradingSystem)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.GradingSystems ([Description], [IsDeleted]) " +
                "VALUES(@Description, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Description", DbType.String, gradingSystem.Description);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, gradingSystem.IsDeleted);

                // Get the primary key value.
                gradingSystem.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return gradingSystem;
        }

        /// <summary>
        /// Updates an existing row in the GradingSystems table.
        /// </summary>
        /// <param name="gradingSystem">A GradingSystem entity object.</param>
        public void UpdateById(GradingSystem gradingSystem)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.GradingSystems " +
                "SET " +
                    "[Description]=@Description, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Description", DbType.String, gradingSystem.Description);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, gradingSystem.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, gradingSystem.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the GradingSystems table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.GradingSystems " +
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
        /// Returns a row from the GradingSystems table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A GradingSystem object with data populated from the database.</returns>
        public GradingSystem SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [Description], [IsDeleted] " +
                "FROM dbo.GradingSystems  " +
                "WHERE [Id]=@Id ";

            GradingSystem gradingSystem = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new GradingSystem
                        gradingSystem = new GradingSystem();

                        // Read values.
                        gradingSystem.Id = base.GetDataValue<int>(dr, "Id");
                        gradingSystem.Description = base.GetDataValue<string>(dr, "Description");
                        gradingSystem.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return gradingSystem;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the GradingSystems table.
        /// </summary>
        /// <returns>A collection of GradingSystem objects.</returns>		
        public List<GradingSystem> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [Description], [IsDeleted] " +
                "FROM dbo.GradingSystems ";

            List<GradingSystem> result = new List<GradingSystem>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new GradingSystem
                        GradingSystem gradingSystem = new GradingSystem();

                        // Read values.
                        gradingSystem.Id = base.GetDataValue<int>(dr, "Id");
                        gradingSystem.Description = base.GetDataValue<string>(dr, "Description");
                        gradingSystem.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(gradingSystem);
                    }
                }
            }

            return result;
        }
    }
}

