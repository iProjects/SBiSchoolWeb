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
    /// Discipline data access component. Manages CRUD operations for the Discipline table.
    /// </summary>
    public partial class DisciplineDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Discipline table.
        /// </summary>
        /// <param name="discipline">A Discipline object.</param>
        /// <returns>An updated Discipline object.</returns>
        public Discipline Create(Discipline discipline)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Discipline ([StudentId], [DisciplineCategoryId], [DisciplinaryDate], [Incident], [DisciplineRating], [Severity], [ActionRecommended], [ActionTaken], [Review], [IsDeleted]) " +
                "VALUES(@StudentId, @DisciplineCategoryId, @DisciplinaryDate, @Incident, @DisciplineRating, @Severity, @ActionRecommended, @ActionTaken, @Review, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@StudentId", DbType.Int32, discipline.StudentId);
                db.AddInParameter(cmd, "@DisciplineCategoryId", DbType.Int32, discipline.DisciplineCategoryId);
                db.AddInParameter(cmd, "@DisciplinaryDate", DbType.Date, discipline.DisciplinaryDate);
                db.AddInParameter(cmd, "@Incident", DbType.String, discipline.Incident);
                db.AddInParameter(cmd, "@DisciplineRating", DbType.String, discipline.DisciplineRating);
                db.AddInParameter(cmd, "@Severity", DbType.String, discipline.Severity);
                db.AddInParameter(cmd, "@ActionRecommended", DbType.String, discipline.ActionRecommended);
                db.AddInParameter(cmd, "@ActionTaken", DbType.String, discipline.ActionTaken);
                db.AddInParameter(cmd, "@Review", DbType.String, discipline.Review);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, discipline.IsDeleted);

                // Get the primary key value.
                discipline.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return discipline;
        }

        /// <summary>
        /// Updates an existing row in the Discipline table.
        /// </summary>
        /// <param name="discipline">A Discipline entity object.</param>
        public void UpdateById(Discipline discipline)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Discipline " +
                "SET " +
                    "[StudentId]=@StudentId, " +
                    "[DisciplineCategoryId]=@DisciplineCategoryId, " +
                    "[DisciplinaryDate]=@DisciplinaryDate, " +
                    "[Incident]=@Incident, " +
                    "[DisciplineRating]=@DisciplineRating, " +
                    "[Severity]=@Severity, " +
                    "[ActionRecommended]=@ActionRecommended, " +
                    "[ActionTaken]=@ActionTaken, " +
                    "[Review]=@Review, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@StudentId", DbType.Int32, discipline.StudentId);
                db.AddInParameter(cmd, "@DisciplineCategoryId", DbType.Int32, discipline.DisciplineCategoryId);
                db.AddInParameter(cmd, "@DisciplinaryDate", DbType.Date, discipline.DisciplinaryDate);
                db.AddInParameter(cmd, "@Incident", DbType.String, discipline.Incident);
                db.AddInParameter(cmd, "@DisciplineRating", DbType.String, discipline.DisciplineRating);
                db.AddInParameter(cmd, "@Severity", DbType.String, discipline.Severity);
                db.AddInParameter(cmd, "@ActionRecommended", DbType.String, discipline.ActionRecommended);
                db.AddInParameter(cmd, "@ActionTaken", DbType.String, discipline.ActionTaken);
                db.AddInParameter(cmd, "@Review", DbType.String, discipline.Review);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, discipline.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, discipline.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the Discipline table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.Discipline " +
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
        /// Returns a row from the Discipline table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A Discipline object with data populated from the database.</returns>
        public Discipline SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [StudentId], [DisciplineCategoryId], [DisciplinaryDate], [Incident], [DisciplineRating]" +
                        ", [Severity], [ActionRecommended], [ActionTaken], [Review], [IsDeleted] " +
                "FROM dbo.Discipline  " +
                "WHERE [Id]=@Id ";

            Discipline discipline = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Discipline
                        discipline = new Discipline();

                        // Read values.
                        discipline.Id = base.GetDataValue<int>(dr, "Id");
                        discipline.StudentId = base.GetDataValue<int>(dr, "StudentId");
                        discipline.DisciplineCategoryId = base.GetDataValue<int>(dr, "DisciplineCategoryId");
                        discipline.DisciplinaryDate = base.GetDataValue<DateTime>(dr, "DisciplinaryDate");
                        discipline.Incident = base.GetDataValue<string>(dr, "Incident");
                        discipline.DisciplineRating = base.GetDataValue<string>(dr, "DisciplineRating");
                        discipline.Severity = base.GetDataValue<string>(dr, "Severity");
                        discipline.ActionRecommended = base.GetDataValue<string>(dr, "ActionRecommended");
                        discipline.ActionTaken = base.GetDataValue<string>(dr, "ActionTaken");
                        discipline.Review = base.GetDataValue<string>(dr, "Review");
                        discipline.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return discipline;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Discipline table.
        /// </summary>
        /// <returns>A collection of Discipline objects.</returns>		
        public List<Discipline> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [StudentId], [DisciplineCategoryId], [DisciplinaryDate], [Incident], [DisciplineRating]" +
                        ", [Severity], [ActionRecommended], [ActionTaken], [Review], [IsDeleted] " +
                "FROM dbo.Discipline ";

            List<Discipline> result = new List<Discipline>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Discipline
                        Discipline discipline = new Discipline();

                        // Read values.
                        discipline.Id = base.GetDataValue<int>(dr, "Id");
                        discipline.StudentId = base.GetDataValue<int>(dr, "StudentId");
                        discipline.DisciplineCategoryId = base.GetDataValue<int>(dr, "DisciplineCategoryId");
                        discipline.DisciplinaryDate = base.GetDataValue<DateTime>(dr, "DisciplinaryDate");
                        discipline.Incident = base.GetDataValue<string>(dr, "Incident");
                        discipline.DisciplineRating = base.GetDataValue<string>(dr, "DisciplineRating");
                        discipline.Severity = base.GetDataValue<string>(dr, "Severity");
                        discipline.ActionRecommended = base.GetDataValue<string>(dr, "ActionRecommended");
                        discipline.ActionTaken = base.GetDataValue<string>(dr, "ActionTaken");
                        discipline.Review = base.GetDataValue<string>(dr, "Review");
                        discipline.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(discipline);
                    }
                }
            }

            return result;
        }
    }
}

