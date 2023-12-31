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
    /// ResidenceHalls data access component. Manages CRUD operations for the ResidenceHalls table.
    /// </summary>
    public partial class ResidenceHallDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the ResidenceHalls table.
        /// </summary>
        /// <param name="residenceHall">A ResidenceHall object.</param>
        /// <returns>An updated ResidenceHall object.</returns>
        public ResidenceHall Create(ResidenceHall residenceHall)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.ResidenceHalls ([HallName], [Location], [IsDeleted]) " +
                "VALUES(@HallName, @Location, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@HallName", DbType.String, residenceHall.HallName);
                db.AddInParameter(cmd, "@Location", DbType.String, residenceHall.Location);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, residenceHall.IsDeleted);

                // Get the primary key value.
                residenceHall.HallId = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return residenceHall;
        }

        /// <summary>
        /// Updates an existing row in the ResidenceHalls table.
        /// </summary>
        /// <param name="residenceHall">A ResidenceHall entity object.</param>
        public void UpdateById(ResidenceHall residenceHall)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.ResidenceHalls " +
                "SET " +
                    "[HallName]=@HallName, " +
                    "[Location]=@Location, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [HallId]=@HallId ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@HallName", DbType.String, residenceHall.HallName);
                db.AddInParameter(cmd, "@Location", DbType.String, residenceHall.Location);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, residenceHall.IsDeleted);
                db.AddInParameter(cmd, "@HallId", DbType.Int32, residenceHall.HallId);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the ResidenceHalls table.
        /// </summary>
        /// <param name="hallId">A hallId value.</param>
        public void DeleteById(int hallId)
        {
            const string SQL_STATEMENT = "DELETE dbo.ResidenceHalls " +
                                         "WHERE [HallId]=@HallId ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@HallId", DbType.Int32, hallId);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the ResidenceHalls table.
        /// </summary>
        /// <param name="hallId">A HallId value.</param>
        /// <returns>A ResidenceHall object with data populated from the database.</returns>
        public ResidenceHall SelectById(int hallId)
        {
            const string SQL_STATEMENT =
                "SELECT [HallId], [HallName], [Location], [IsDeleted] " +
                "FROM dbo.ResidenceHalls  " +
                "WHERE [HallId]=@HallId ";

            ResidenceHall residenceHall = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@HallId", DbType.Int32, hallId);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new ResidenceHall
                        residenceHall = new ResidenceHall();

                        // Read values.
                        residenceHall.HallId = base.GetDataValue<int>(dr, "HallId");
                        residenceHall.HallName = base.GetDataValue<string>(dr, "HallName");
                        residenceHall.Location = base.GetDataValue<string>(dr, "Location");
                        residenceHall.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return residenceHall;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the ResidenceHalls table.
        /// </summary>
        /// <returns>A collection of ResidenceHall objects.</returns>		
        public List<ResidenceHall> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [HallId], [HallName], [Location], [IsDeleted] " +
                "FROM dbo.ResidenceHalls ";

            List<ResidenceHall> result = new List<ResidenceHall>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new ResidenceHall
                        ResidenceHall residenceHall = new ResidenceHall();

                        // Read values.
                        residenceHall.HallId = base.GetDataValue<int>(dr, "HallId");
                        residenceHall.HallName = base.GetDataValue<string>(dr, "HallName");
                        residenceHall.Location = base.GetDataValue<string>(dr, "Location");
                        residenceHall.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(residenceHall);
                    }
                }
            }

            return result;
        }
    }
}

