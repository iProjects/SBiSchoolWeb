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
    /// MarksheetArchives data access component. Manages CRUD operations for the MarksheetArchives table.
    /// </summary>
    public partial class MarksheetArchiveDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the MarksheetArchives table.
        /// </summary>
        /// <param name="marksheetArchive">A MarksheetArchive object.</param>
        /// <returns>An updated MarksheetArchive object.</returns>
        public MarksheetArchive Create(MarksheetArchive marksheetArchive)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.MarksheetArchives ([Year], [Term], [ExamType], [Class], [Teacher], [Student], [Subject], [Mark], [OutOf], [Grade], [IsDeleted]) " +
                "VALUES(@Year, @Term, @ExamType, @Class, @Teacher, @Student, @Subject, @Mark, @OutOf, @Grade, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Year", DbType.Int32, marksheetArchive.Year);
                db.AddInParameter(cmd, "@Term", DbType.Int32, marksheetArchive.Term);
                db.AddInParameter(cmd, "@ExamType", DbType.String, marksheetArchive.ExamType);
                db.AddInParameter(cmd, "@Class", DbType.AnsiString, marksheetArchive.Class);
                db.AddInParameter(cmd, "@Teacher", DbType.Int32, marksheetArchive.Teacher);
                db.AddInParameter(cmd, "@Student", DbType.Int32, marksheetArchive.Student);
                db.AddInParameter(cmd, "@Subject", DbType.String, marksheetArchive.Subject);
                db.AddInParameter(cmd, "@Mark", DbType.Int32, marksheetArchive.Mark);
                db.AddInParameter(cmd, "@OutOf", DbType.Int32, marksheetArchive.OutOf);
                db.AddInParameter(cmd, "@Grade", DbType.String, marksheetArchive.Grade);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, marksheetArchive.IsDeleted);

                // Get the primary key value.
                marksheetArchive.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return marksheetArchive;
        }

        /// <summary>
        /// Updates an existing row in the MarksheetArchives table.
        /// </summary>
        /// <param name="marksheetArchive">A MarksheetArchive entity object.</param>
        public void UpdateById(MarksheetArchive marksheetArchive)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.MarksheetArchives " +
                "SET " +
                    "[Year]=@Year, " +
                    "[Term]=@Term, " +
                    "[ExamType]=@ExamType, " +
                    "[Class]=@Class, " +
                    "[Teacher]=@Teacher, " +
                    "[Student]=@Student, " +
                    "[Subject]=@Subject, " +
                    "[Mark]=@Mark, " +
                    "[OutOf]=@OutOf, " +
                    "[Grade]=@Grade, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Year", DbType.Int32, marksheetArchive.Year);
                db.AddInParameter(cmd, "@Term", DbType.Int32, marksheetArchive.Term);
                db.AddInParameter(cmd, "@ExamType", DbType.String, marksheetArchive.ExamType);
                db.AddInParameter(cmd, "@Class", DbType.AnsiString, marksheetArchive.Class);
                db.AddInParameter(cmd, "@Teacher", DbType.Int32, marksheetArchive.Teacher);
                db.AddInParameter(cmd, "@Student", DbType.Int32, marksheetArchive.Student);
                db.AddInParameter(cmd, "@Subject", DbType.String, marksheetArchive.Subject);
                db.AddInParameter(cmd, "@Mark", DbType.Int32, marksheetArchive.Mark);
                db.AddInParameter(cmd, "@OutOf", DbType.Int32, marksheetArchive.OutOf);
                db.AddInParameter(cmd, "@Grade", DbType.String, marksheetArchive.Grade);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, marksheetArchive.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, marksheetArchive.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the MarksheetArchives table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.MarksheetArchives " +
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
        /// Returns a row from the MarksheetArchives table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A MarksheetArchive object with data populated from the database.</returns>
        public MarksheetArchive SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [Year], [Term], [ExamType], [Class], [Teacher], [Student], [Subject], [Mark]" +
                        ", [OutOf], [Grade], [IsDeleted] " +
                "FROM dbo.MarksheetArchives  " +
                "WHERE [Id]=@Id ";

            MarksheetArchive marksheetArchive = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new MarksheetArchive
                        marksheetArchive = new MarksheetArchive();

                        // Read values.
                        marksheetArchive.Id = base.GetDataValue<int>(dr, "Id");
                        marksheetArchive.Year = base.GetDataValue<int>(dr, "Year");
                        marksheetArchive.Term = base.GetDataValue<int>(dr, "Term");
                        marksheetArchive.ExamType = base.GetDataValue<string>(dr, "ExamType");
                        marksheetArchive.Class = base.GetDataValue<string>(dr, "Class");
                        marksheetArchive.Teacher = base.GetDataValue<int>(dr, "Teacher");
                        marksheetArchive.Student = base.GetDataValue<int>(dr, "Student");
                        marksheetArchive.Subject = base.GetDataValue<string>(dr, "Subject");
                        marksheetArchive.Mark = base.GetDataValue<int>(dr, "Mark");
                        marksheetArchive.OutOf = base.GetDataValue<int>(dr, "OutOf");
                        marksheetArchive.Grade = base.GetDataValue<string>(dr, "Grade");
                        marksheetArchive.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return marksheetArchive;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the MarksheetArchives table.
        /// </summary>
        /// <returns>A collection of MarksheetArchive objects.</returns>		
        public List<MarksheetArchive> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [Year], [Term], [ExamType], [Class], [Teacher], [Student], [Subject], [Mark]" +
                        ", [OutOf], [Grade], [IsDeleted] " +
                "FROM dbo.MarksheetArchives ";

            List<MarksheetArchive> result = new List<MarksheetArchive>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new MarksheetArchive
                        MarksheetArchive marksheetArchive = new MarksheetArchive();

                        // Read values.
                        marksheetArchive.Id = base.GetDataValue<int>(dr, "Id");
                        marksheetArchive.Year = base.GetDataValue<int>(dr, "Year");
                        marksheetArchive.Term = base.GetDataValue<int>(dr, "Term");
                        marksheetArchive.ExamType = base.GetDataValue<string>(dr, "ExamType");
                        marksheetArchive.Class = base.GetDataValue<string>(dr, "Class");
                        marksheetArchive.Teacher = base.GetDataValue<int>(dr, "Teacher");
                        marksheetArchive.Student = base.GetDataValue<int>(dr, "Student");
                        marksheetArchive.Subject = base.GetDataValue<string>(dr, "Subject");
                        marksheetArchive.Mark = base.GetDataValue<int>(dr, "Mark");
                        marksheetArchive.OutOf = base.GetDataValue<int>(dr, "OutOf");
                        marksheetArchive.Grade = base.GetDataValue<string>(dr, "Grade");
                        marksheetArchive.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(marksheetArchive);
                    }
                }
            }

            return result;
        }
    }
}
