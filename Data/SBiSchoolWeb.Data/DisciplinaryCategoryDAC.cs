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
    /// DisciplinaryCategories data access component. Manages CRUD operations for the DisciplinaryCategories table.
    /// </summary>
    public partial class DisciplinaryCategoryDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the DisciplinaryCategories table.
        /// </summary>
        /// <param name="disciplinaryCategory">A DisciplinaryCategory object.</param>
        /// <returns>An updated DisciplinaryCategory object.</returns>
        public DisciplinaryCategory Create(DisciplinaryCategory disciplinaryCategory)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.DisciplinaryCategories ([ShortCode], [Description], [Status], [IsDeleted]) " +
                "VALUES(@ShortCode, @Description, @Status, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@ShortCode", DbType.String, disciplinaryCategory.ShortCode);
                db.AddInParameter(cmd, "@Description", DbType.AnsiString, disciplinaryCategory.Description);
                db.AddInParameter(cmd, "@Status", DbType.StringFixedLength, disciplinaryCategory.Status);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, disciplinaryCategory.IsDeleted);

                // Get the primary key value.
                disciplinaryCategory.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return disciplinaryCategory;
        }

        /// <summary>
        /// Updates an existing row in the DisciplinaryCategories table.
        /// </summary>
        /// <param name="disciplinaryCategory">A DisciplinaryCategory entity object.</param>
        public void UpdateById(DisciplinaryCategory disciplinaryCategory)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.DisciplinaryCategories " +
                "SET " +
                    "[ShortCode]=@ShortCode, " +
                    "[Description]=@Description, " +
                    "[Status]=@Status, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@ShortCode", DbType.String, disciplinaryCategory.ShortCode);
                db.AddInParameter(cmd, "@Description", DbType.AnsiString, disciplinaryCategory.Description);
                db.AddInParameter(cmd, "@Status", DbType.StringFixedLength, disciplinaryCategory.Status);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, disciplinaryCategory.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, disciplinaryCategory.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the DisciplinaryCategories table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.DisciplinaryCategories " +
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
        /// Returns a row from the DisciplinaryCategories table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A DisciplinaryCategory object with data populated from the database.</returns>
        public DisciplinaryCategory SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [ShortCode], [Description], [Status], [IsDeleted] " +
                "FROM dbo.DisciplinaryCategories  " +
                "WHERE [Id]=@Id ";

            DisciplinaryCategory disciplinaryCategory = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new DisciplinaryCategory
                        disciplinaryCategory = new DisciplinaryCategory();

                        // Read values.
                        disciplinaryCategory.Id = base.GetDataValue<int>(dr, "Id");
                        disciplinaryCategory.ShortCode = base.GetDataValue<string>(dr, "ShortCode");
                        disciplinaryCategory.Description = base.GetDataValue<string>(dr, "Description");
                        disciplinaryCategory.Status = Convert.ToChar(base.GetDataValue<string>(dr, "Status"));
                        disciplinaryCategory.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return disciplinaryCategory;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the DisciplinaryCategories table.
        /// </summary>
        /// <returns>A collection of DisciplinaryCategory objects.</returns>		
        public List<DisciplinaryCategory> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [ShortCode], [Description], [Status], [IsDeleted] " +
                "FROM dbo.DisciplinaryCategories ";

            List<DisciplinaryCategory> result = new List<DisciplinaryCategory>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new DisciplinaryCategory
                        DisciplinaryCategory disciplinaryCategory = new DisciplinaryCategory();

                        // Read values.
                        disciplinaryCategory.Id = base.GetDataValue<int>(dr, "Id");
                        disciplinaryCategory.ShortCode = base.GetDataValue<string>(dr, "ShortCode");
                        disciplinaryCategory.Description = base.GetDataValue<string>(dr, "Description");
                        disciplinaryCategory.Status = Convert.ToChar(base.GetDataValue<string>(dr, "Status"));
                        disciplinaryCategory.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(disciplinaryCategory);
                    }
                }
            }

            return result;
        }
    }
}

