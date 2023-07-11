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
    /// StudentExams data access component. Manages CRUD operations for the StudentExams table.
    /// </summary>
    public partial class StudentExamDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the StudentExams table.
        /// </summary>
        /// <param name="studentExam">A StudentExam object.</param>
        /// <returns>An updated StudentExam object.</returns>
        public StudentExam Create(StudentExam studentExam)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.StudentExams ([StudentId], [RegdExamId], [Mark], [Status], [ModifiedBy], [LastModified], [IsDeleted]) " +
                "VALUES(@StudentId, @RegdExamId, @Mark, @Status, @ModifiedBy, @LastModified, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@StudentId", DbType.Int32, studentExam.StudentId);
                db.AddInParameter(cmd, "@RegdExamId", DbType.Int32, studentExam.RegdExamId);
                db.AddInParameter(cmd, "@Mark", DbType.Double, studentExam.Mark);
                db.AddInParameter(cmd, "@Status", DbType.String, studentExam.Status);
                db.AddInParameter(cmd, "@ModifiedBy", DbType.String, studentExam.ModifiedBy);
                db.AddInParameter(cmd, "@LastModified", DbType.DateTime, studentExam.LastModified);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, studentExam.IsDeleted);

                // Get the primary key value.
                studentExam.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return studentExam;
        }

        /// <summary>
        /// Updates an existing row in the StudentExams table.
        /// </summary>
        /// <param name="studentExam">A StudentExam entity object.</param>
        public void UpdateById(StudentExam studentExam)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.StudentExams " +
                "SET " +
                    "[StudentId]=@StudentId, " +
                    "[RegdExamId]=@RegdExamId, " +
                    "[Mark]=@Mark, " +
                    "[Status]=@Status, " +
                    "[ModifiedBy]=@ModifiedBy, " +
                    "[LastModified]=@LastModified, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@StudentId", DbType.Int32, studentExam.StudentId);
                db.AddInParameter(cmd, "@RegdExamId", DbType.Int32, studentExam.RegdExamId);
                db.AddInParameter(cmd, "@Mark", DbType.Double, studentExam.Mark);
                db.AddInParameter(cmd, "@Status", DbType.String, studentExam.Status);
                db.AddInParameter(cmd, "@ModifiedBy", DbType.String, studentExam.ModifiedBy);
                db.AddInParameter(cmd, "@LastModified", DbType.DateTime, studentExam.LastModified);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, studentExam.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, studentExam.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the StudentExams table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.StudentExams " +
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
        /// Returns a row from the StudentExams table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A StudentExam object with data populated from the database.</returns>
        public StudentExam SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [StudentId], [RegdExamId], [Mark], [Status], [ModifiedBy], [LastModified]" +
                        ", [IsDeleted] " +
                "FROM dbo.StudentExams  " +
                "WHERE [Id]=@Id ";

            StudentExam studentExam = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new StudentExam
                        studentExam = new StudentExam();

                        // Read values.
                        studentExam.Id = base.GetDataValue<int>(dr, "Id");
                        studentExam.StudentId = base.GetDataValue<int>(dr, "StudentId");
                        studentExam.RegdExamId = base.GetDataValue<int>(dr, "RegdExamId");
                        studentExam.Mark = base.GetDataValue<double>(dr, "Mark");
                        studentExam.Status = base.GetDataValue<string>(dr, "Status");
                        studentExam.ModifiedBy = base.GetDataValue<string>(dr, "ModifiedBy");
                        studentExam.LastModified = base.GetDataValue<DateTime>(dr, "LastModified");
                        studentExam.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return studentExam;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the StudentExams table.
        /// </summary>
        /// <returns>A collection of StudentExam objects.</returns>		
        public List<StudentExam> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [StudentId], [RegdExamId], [Mark], [Status], [ModifiedBy], [LastModified]" +
                        ", [IsDeleted] " +
                "FROM dbo.StudentExams ";

            List<StudentExam> result = new List<StudentExam>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new StudentExam
                        StudentExam studentExam = new StudentExam();

                        // Read values.
                        studentExam.Id = base.GetDataValue<int>(dr, "Id");
                        studentExam.StudentId = base.GetDataValue<int>(dr, "StudentId");
                        studentExam.RegdExamId = base.GetDataValue<int>(dr, "RegdExamId");
                        studentExam.Mark = base.GetDataValue<double>(dr, "Mark");
                        studentExam.Status = base.GetDataValue<string>(dr, "Status");
                        studentExam.ModifiedBy = base.GetDataValue<string>(dr, "ModifiedBy");
                        studentExam.LastModified = base.GetDataValue<DateTime>(dr, "LastModified");
                        studentExam.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(studentExam);
                    }
                }
            }

            return result;
        }
    }
}
