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
    /// StudentSubjectTargets data access component. Manages CRUD operations for the StudentSubjectTargets table.
    /// </summary>
    public partial class StudentSubjectTargetDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the StudentSubjectTargets table.
        /// </summary>
        /// <param name="studentSubjectTarget">A StudentSubjectTarget object.</param>
        /// <returns>An updated StudentSubjectTarget object.</returns>
        public StudentSubjectTarget Create(StudentSubjectTarget studentSubjectTarget)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.StudentSubjectTargets ([StudentId], [SubjectShortCode], [Target], [IsDeleted]) " +
                "VALUES(@StudentId, @SubjectShortCode, @Target, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@StudentId", DbType.Int32, studentSubjectTarget.StudentId);
                db.AddInParameter(cmd, "@SubjectShortCode", DbType.StringFixedLength, studentSubjectTarget.SubjectShortCode);
                db.AddInParameter(cmd, "@Target", DbType.Double, studentSubjectTarget.Target);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, studentSubjectTarget.IsDeleted);

                // Get the primary key value.
                studentSubjectTarget.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return studentSubjectTarget;
        }

        /// <summary>
        /// Updates an existing row in the StudentSubjectTargets table.
        /// </summary>
        /// <param name="studentSubjectTarget">A StudentSubjectTarget entity object.</param>
        public void UpdateById(StudentSubjectTarget studentSubjectTarget)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.StudentSubjectTargets " +
                "SET " +
                    "[StudentId]=@StudentId, " +
                    "[SubjectShortCode]=@SubjectShortCode, " +
                    "[Target]=@Target, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@StudentId", DbType.Int32, studentSubjectTarget.StudentId);
                db.AddInParameter(cmd, "@SubjectShortCode", DbType.StringFixedLength, studentSubjectTarget.SubjectShortCode);
                db.AddInParameter(cmd, "@Target", DbType.Double, studentSubjectTarget.Target);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, studentSubjectTarget.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, studentSubjectTarget.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the StudentSubjectTargets table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.StudentSubjectTargets " +
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
        /// Returns a row from the StudentSubjectTargets table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A StudentSubjectTarget object with data populated from the database.</returns>
        public StudentSubjectTarget SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [StudentId], [SubjectShortCode], [Target], [IsDeleted] " +
                "FROM dbo.StudentSubjectTargets  " +
                "WHERE [Id]=@Id ";

            StudentSubjectTarget studentSubjectTarget = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new StudentSubjectTarget
                        studentSubjectTarget = new StudentSubjectTarget();

                        // Read values.
                        studentSubjectTarget.Id = base.GetDataValue<int>(dr, "Id");
                        studentSubjectTarget.StudentId = base.GetDataValue<int>(dr, "StudentId");
                        studentSubjectTarget.SubjectShortCode = base.GetDataValue<string>(dr, "SubjectShortCode");
                        studentSubjectTarget.Target = base.GetDataValue<double>(dr, "Target");
                        studentSubjectTarget.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return studentSubjectTarget;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the StudentSubjectTargets table.
        /// </summary>
        /// <returns>A collection of StudentSubjectTarget objects.</returns>		
        public List<StudentSubjectTarget> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [StudentId], [SubjectShortCode], [Target], [IsDeleted] " +
                "FROM dbo.StudentSubjectTargets ";

            List<StudentSubjectTarget> result = new List<StudentSubjectTarget>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new StudentSubjectTarget
                        StudentSubjectTarget studentSubjectTarget = new StudentSubjectTarget();

                        // Read values.
                        studentSubjectTarget.Id = base.GetDataValue<int>(dr, "Id");
                        studentSubjectTarget.StudentId = base.GetDataValue<int>(dr, "StudentId");
                        studentSubjectTarget.SubjectShortCode = base.GetDataValue<string>(dr, "SubjectShortCode");
                        studentSubjectTarget.Target = base.GetDataValue<double>(dr, "Target");
                        studentSubjectTarget.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(studentSubjectTarget);
                    }
                }
            }

            return result;
        }
    }
}

