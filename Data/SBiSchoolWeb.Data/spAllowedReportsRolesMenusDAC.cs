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
    /// spAllowedReportsRolesMenus data access component. Manages CRUD operations for the spAllowedReportsRolesMenus table.
    /// </summary>
    public partial class spAllowedReportsRolesMenusDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the spAllowedReportsRolesMenus table.
        /// </summary>
        /// <param name="spAllowedReportsRolesMenus">A spAllowedReportsRolesMenus object.</param>
        /// <returns>An updated spAllowedReportsRolesMenus object.</returns>
        public spAllowedReportsRolesMenus Create(spAllowedReportsRolesMenus spAllowedReportsRolesMenus)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.spAllowedReportsRolesMenus ([RoleId], [MenuItemId], [Allowed]) " +
                "VALUES(@RoleId, @MenuItemId, @Allowed); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@RoleId", DbType.Int32, spAllowedReportsRolesMenus.RoleId);
                db.AddInParameter(cmd, "@MenuItemId", DbType.Int32, spAllowedReportsRolesMenus.MenuItemId);
                db.AddInParameter(cmd, "@Allowed", DbType.Boolean, spAllowedReportsRolesMenus.Allowed);

                // Get the primary key value.
                spAllowedReportsRolesMenus.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return spAllowedReportsRolesMenus;
        }

        /// <summary>
        /// Updates an existing row in the spAllowedReportsRolesMenus table.
        /// </summary>
        /// <param name="spAllowedReportsRolesMenus">A spAllowedReportsRolesMenus entity object.</param>
        public void UpdateById(spAllowedReportsRolesMenus spAllowedReportsRolesMenus)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.spAllowedReportsRolesMenus " +
                "SET " +
                    "[RoleId]=@RoleId, " +
                    "[MenuItemId]=@MenuItemId, " +
                    "[Allowed]=@Allowed " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@RoleId", DbType.Int32, spAllowedReportsRolesMenus.RoleId);
                db.AddInParameter(cmd, "@MenuItemId", DbType.Int32, spAllowedReportsRolesMenus.MenuItemId);
                db.AddInParameter(cmd, "@Allowed", DbType.Boolean, spAllowedReportsRolesMenus.Allowed);
                db.AddInParameter(cmd, "@Id", DbType.Int32, spAllowedReportsRolesMenus.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the spAllowedReportsRolesMenus table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.spAllowedReportsRolesMenus " +
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
        /// Returns a row from the spAllowedReportsRolesMenus table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A spAllowedReportsRolesMenus object with data populated from the database.</returns>
        public spAllowedReportsRolesMenus SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [RoleId], [MenuItemId], [Allowed] " +
                "FROM dbo.spAllowedReportsRolesMenus  " +
                "WHERE [Id]=@Id ";

            spAllowedReportsRolesMenus spAllowedReportsRolesMenus = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new spAllowedReportsRolesMenus
                        spAllowedReportsRolesMenus = new spAllowedReportsRolesMenus();

                        // Read values.
                        spAllowedReportsRolesMenus.Id = base.GetDataValue<int>(dr, "Id");
                        spAllowedReportsRolesMenus.RoleId = base.GetDataValue<int>(dr, "RoleId");
                        spAllowedReportsRolesMenus.MenuItemId = base.GetDataValue<int>(dr, "MenuItemId");
                        spAllowedReportsRolesMenus.Allowed = base.GetDataValue<bool>(dr, "Allowed");
                    }
                }
            }

            return spAllowedReportsRolesMenus;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the spAllowedReportsRolesMenus table.
        /// </summary>
        /// <returns>A collection of spAllowedReportsRolesMenus objects.</returns>		
        public List<spAllowedReportsRolesMenus> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [RoleId], [MenuItemId], [Allowed] " +
                "FROM dbo.spAllowedReportsRolesMenus ";

            List<spAllowedReportsRolesMenus> result = new List<spAllowedReportsRolesMenus>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new spAllowedReportsRolesMenus
                        spAllowedReportsRolesMenus spAllowedReportsRolesMenus = new spAllowedReportsRolesMenus();

                        // Read values.
                        spAllowedReportsRolesMenus.Id = base.GetDataValue<int>(dr, "Id");
                        spAllowedReportsRolesMenus.RoleId = base.GetDataValue<int>(dr, "RoleId");
                        spAllowedReportsRolesMenus.MenuItemId = base.GetDataValue<int>(dr, "MenuItemId");
                        spAllowedReportsRolesMenus.Allowed = base.GetDataValue<bool>(dr, "Allowed");

                        // Add to List.
                        result.Add(spAllowedReportsRolesMenus);
                    }
                }
            }

            return result;
        }
    }
}

