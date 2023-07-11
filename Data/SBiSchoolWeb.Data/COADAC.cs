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
    /// COA data access component. Manages CRUD operations for the COA table.
    /// </summary>
    public partial class COADAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the COA table.
        /// </summary>
        /// <param name="cOA">A COA object.</param>
        /// <returns>An updated COA object.</returns>
        public COA Create(COA cOA)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.COA ([ShortCode], [Description], [COALevel], [Parent], [Rorder], [IsDeleted]) " +
                "VALUES(@ShortCode, @Description, @COALevel, @Parent, @Rorder, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@ShortCode", DbType.StringFixedLength, cOA.ShortCode);
                db.AddInParameter(cmd, "@Description", DbType.String, cOA.Description);
                db.AddInParameter(cmd, "@COALevel", DbType.Int32, cOA.COALevel);
                db.AddInParameter(cmd, "@Parent", DbType.Int32, cOA.Parent);
                db.AddInParameter(cmd, "@Rorder", DbType.Int32, cOA.Rorder);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, cOA.IsDeleted);

                // Get the primary key value.
                cOA.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return cOA;
        }

        /// <summary>
        /// Updates an existing row in the COA table.
        /// </summary>
        /// <param name="cOA">A COA entity object.</param>
        public void UpdateById(COA cOA)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.COA " +
                "SET " +
                    "[ShortCode]=@ShortCode, " +
                    "[Description]=@Description, " +
                    "[COALevel]=@COALevel, " +
                    "[Parent]=@Parent, " +
                    "[Rorder]=@Rorder, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@ShortCode", DbType.StringFixedLength, cOA.ShortCode);
                db.AddInParameter(cmd, "@Description", DbType.String, cOA.Description);
                db.AddInParameter(cmd, "@COALevel", DbType.Int32, cOA.COALevel);
                db.AddInParameter(cmd, "@Parent", DbType.Int32, cOA.Parent);
                db.AddInParameter(cmd, "@Rorder", DbType.Int32, cOA.Rorder);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, cOA.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, cOA.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the COA table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.COA " +
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
        /// Returns a row from the COA table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A COA object with data populated from the database.</returns>
        public COA SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [ShortCode], [Description], [COALevel], [Parent], [Rorder], [IsDeleted] " +
                "FROM dbo.COA  " +
                "WHERE [Id]=@Id ";

            COA cOA = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new COA
                        cOA = new COA();

                        // Read values.
                        cOA.Id = base.GetDataValue<int>(dr, "Id");
                        cOA.ShortCode = base.GetDataValue<string>(dr, "ShortCode");
                        cOA.Description = base.GetDataValue<string>(dr, "Description");
                        cOA.COALevel = base.GetDataValue<int>(dr, "COALevel");
                        cOA.Parent = base.GetDataValue<int>(dr, "Parent");
                        cOA.Rorder = base.GetDataValue<int>(dr, "Rorder");
                        cOA.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return cOA;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the COA table.
        /// </summary>
        /// <returns>A collection of COA objects.</returns>		
        public List<COA> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [ShortCode], [Description], [COALevel], [Parent], [Rorder], [IsDeleted] " +
                "FROM dbo.COA ";

            List<COA> result = new List<COA>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new COA
                        COA cOA = new COA();

                        // Read values.
                        cOA.Id = base.GetDataValue<int>(dr, "Id");
                        cOA.ShortCode = base.GetDataValue<string>(dr, "ShortCode");
                        cOA.Description = base.GetDataValue<string>(dr, "Description");
                        cOA.COALevel = base.GetDataValue<int>(dr, "COALevel");
                        cOA.Parent = base.GetDataValue<int>(dr, "Parent");
                        cOA.Rorder = base.GetDataValue<int>(dr, "Rorder");
                        cOA.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(cOA);
                    }
                }
            }

            return result;
        }
    }
}

