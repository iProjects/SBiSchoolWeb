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
    /// StudentProgresses data access component. Manages CRUD operations for the StudentProgresses table.
    /// </summary>
    public partial class StudentProgressDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the StudentProgresses table.
        /// </summary>
        /// <param name="studentProgress">A StudentProgress object.</param>
        /// <returns>An updated StudentProgress object.</returns>
        public StudentProgress Create(StudentProgress studentProgress)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.StudentProgresses ([StudentId], [ExamId], [SchoolClassId], [Year], [Term], [ClassShortCode], [SubjectShortCode], [TeacherId], [TotalMarks], [TotalPoints], [Position], [MeanMarks], [MeanGrade], [ClassTeacherRemark], [HeadTeacherRemark], [IsDeleted]) " +
                "VALUES(@StudentId, @ExamId, @SchoolClassId, @Year, @Term, @ClassShortCode, @SubjectShortCode, @TeacherId, @TotalMarks, @TotalPoints, @Position, @MeanMarks, @MeanGrade, @ClassTeacherRemark, @HeadTeacherRemark, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@StudentId", DbType.Int32, studentProgress.StudentId);
                db.AddInParameter(cmd, "@ExamId", DbType.Int32, studentProgress.ExamId);
                db.AddInParameter(cmd, "@SchoolClassId", DbType.Int32, studentProgress.SchoolClassId);
                db.AddInParameter(cmd, "@Year", DbType.Int32, studentProgress.Year);
                db.AddInParameter(cmd, "@Term", DbType.Int32, studentProgress.Term);
                db.AddInParameter(cmd, "@ClassShortCode", DbType.String, studentProgress.ClassShortCode);
                db.AddInParameter(cmd, "@SubjectShortCode", DbType.StringFixedLength, studentProgress.SubjectShortCode);
                db.AddInParameter(cmd, "@TeacherId", DbType.Int32, studentProgress.TeacherId);
                db.AddInParameter(cmd, "@TotalMarks", DbType.Double, studentProgress.TotalMarks);
                db.AddInParameter(cmd, "@TotalPoints", DbType.Double, studentProgress.TotalPoints);
                db.AddInParameter(cmd, "@Position", DbType.Int32, studentProgress.Position);
                db.AddInParameter(cmd, "@MeanMarks", DbType.Double, studentProgress.MeanMarks);
                db.AddInParameter(cmd, "@MeanGrade", DbType.String, studentProgress.MeanGrade);
                db.AddInParameter(cmd, "@ClassTeacherRemark", DbType.String, studentProgress.ClassTeacherRemark);
                db.AddInParameter(cmd, "@HeadTeacherRemark", DbType.String, studentProgress.HeadTeacherRemark);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, studentProgress.IsDeleted);

                // Get the primary key value.
                studentProgress.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return studentProgress;
        }

        /// <summary>
        /// Updates an existing row in the StudentProgresses table.
        /// </summary>
        /// <param name="studentProgress">A StudentProgress entity object.</param>
        public void UpdateById(StudentProgress studentProgress)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.StudentProgresses " +
                "SET " +
                    "[StudentId]=@StudentId, " +
                    "[ExamId]=@ExamId, " +
                    "[SchoolClassId]=@SchoolClassId, " +
                    "[Year]=@Year, " +
                    "[Term]=@Term, " +
                    "[ClassShortCode]=@ClassShortCode, " +
                    "[SubjectShortCode]=@SubjectShortCode, " +
                    "[TeacherId]=@TeacherId, " +
                    "[TotalMarks]=@TotalMarks, " +
                    "[TotalPoints]=@TotalPoints, " +
                    "[Position]=@Position, " +
                    "[MeanMarks]=@MeanMarks, " +
                    "[MeanGrade]=@MeanGrade, " +
                    "[ClassTeacherRemark]=@ClassTeacherRemark, " +
                    "[HeadTeacherRemark]=@HeadTeacherRemark, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@StudentId", DbType.Int32, studentProgress.StudentId);
                db.AddInParameter(cmd, "@ExamId", DbType.Int32, studentProgress.ExamId);
                db.AddInParameter(cmd, "@SchoolClassId", DbType.Int32, studentProgress.SchoolClassId);
                db.AddInParameter(cmd, "@Year", DbType.Int32, studentProgress.Year);
                db.AddInParameter(cmd, "@Term", DbType.Int32, studentProgress.Term);
                db.AddInParameter(cmd, "@ClassShortCode", DbType.String, studentProgress.ClassShortCode);
                db.AddInParameter(cmd, "@SubjectShortCode", DbType.StringFixedLength, studentProgress.SubjectShortCode);
                db.AddInParameter(cmd, "@TeacherId", DbType.Int32, studentProgress.TeacherId);
                db.AddInParameter(cmd, "@TotalMarks", DbType.Double, studentProgress.TotalMarks);
                db.AddInParameter(cmd, "@TotalPoints", DbType.Double, studentProgress.TotalPoints);
                db.AddInParameter(cmd, "@Position", DbType.Int32, studentProgress.Position);
                db.AddInParameter(cmd, "@MeanMarks", DbType.Double, studentProgress.MeanMarks);
                db.AddInParameter(cmd, "@MeanGrade", DbType.String, studentProgress.MeanGrade);
                db.AddInParameter(cmd, "@ClassTeacherRemark", DbType.String, studentProgress.ClassTeacherRemark);
                db.AddInParameter(cmd, "@HeadTeacherRemark", DbType.String, studentProgress.HeadTeacherRemark);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, studentProgress.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, studentProgress.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the StudentProgresses table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.StudentProgresses " +
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
        /// Returns a row from the StudentProgresses table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A StudentProgress object with data populated from the database.</returns>
        public StudentProgress SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [StudentId], [ExamId], [SchoolClassId], [Year], [Term], [ClassShortCode], [SubjectShortCode]" +
                        ", [TeacherId], [TotalMarks], [TotalPoints], [Position], [MeanMarks], [MeanGrade], [ClassTeacherRemark]" +
                        ", [HeadTeacherRemark], [IsDeleted] " +
                "FROM dbo.StudentProgresses  " +
                "WHERE [Id]=@Id ";

            StudentProgress studentProgress = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new StudentProgress
                        studentProgress = new StudentProgress();

                        // Read values.
                        studentProgress.Id = base.GetDataValue<int>(dr, "Id");
                        studentProgress.StudentId = base.GetDataValue<int>(dr, "StudentId");
                        studentProgress.ExamId = base.GetDataValue<int>(dr, "ExamId");
                        studentProgress.SchoolClassId = base.GetDataValue<int>(dr, "SchoolClassId");
                        studentProgress.Year = base.GetDataValue<int>(dr, "Year");
                        studentProgress.Term = base.GetDataValue<int>(dr, "Term");
                        studentProgress.ClassShortCode = base.GetDataValue<string>(dr, "ClassShortCode");
                        studentProgress.SubjectShortCode = base.GetDataValue<string>(dr, "SubjectShortCode");
                        studentProgress.TeacherId = base.GetDataValue<int>(dr, "TeacherId");
                        studentProgress.TotalMarks = base.GetDataValue<double>(dr, "TotalMarks");
                        studentProgress.TotalPoints = base.GetDataValue<double>(dr, "TotalPoints");
                        studentProgress.Position = base.GetDataValue<int>(dr, "Position");
                        studentProgress.MeanMarks = base.GetDataValue<double>(dr, "MeanMarks");
                        studentProgress.MeanGrade = base.GetDataValue<string>(dr, "MeanGrade");
                        studentProgress.ClassTeacherRemark = base.GetDataValue<string>(dr, "ClassTeacherRemark");
                        studentProgress.HeadTeacherRemark = base.GetDataValue<string>(dr, "HeadTeacherRemark");
                        studentProgress.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return studentProgress;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the StudentProgresses table.
        /// </summary>
        /// <returns>A collection of StudentProgress objects.</returns>		
        public List<StudentProgress> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [StudentId], [ExamId], [SchoolClassId], [Year], [Term], [ClassShortCode], [SubjectShortCode]" +
                        ", [TeacherId], [TotalMarks], [TotalPoints], [Position], [MeanMarks], [MeanGrade], [ClassTeacherRemark]" +
                        ", [HeadTeacherRemark], [IsDeleted] " +
                "FROM dbo.StudentProgresses ";

            List<StudentProgress> result = new List<StudentProgress>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new StudentProgress
                        StudentProgress studentProgress = new StudentProgress();

                        // Read values.
                        studentProgress.Id = base.GetDataValue<int>(dr, "Id");
                        studentProgress.StudentId = base.GetDataValue<int>(dr, "StudentId");
                        studentProgress.ExamId = base.GetDataValue<int>(dr, "ExamId");
                        studentProgress.SchoolClassId = base.GetDataValue<int>(dr, "SchoolClassId");
                        studentProgress.Year = base.GetDataValue<int>(dr, "Year");
                        studentProgress.Term = base.GetDataValue<int>(dr, "Term");
                        studentProgress.ClassShortCode = base.GetDataValue<string>(dr, "ClassShortCode");
                        studentProgress.SubjectShortCode = base.GetDataValue<string>(dr, "SubjectShortCode");
                        studentProgress.TeacherId = base.GetDataValue<int>(dr, "TeacherId");
                        studentProgress.TotalMarks = base.GetDataValue<double>(dr, "TotalMarks");
                        studentProgress.TotalPoints = base.GetDataValue<double>(dr, "TotalPoints");
                        studentProgress.Position = base.GetDataValue<int>(dr, "Position");
                        studentProgress.MeanMarks = base.GetDataValue<double>(dr, "MeanMarks");
                        studentProgress.MeanGrade = base.GetDataValue<string>(dr, "MeanGrade");
                        studentProgress.ClassTeacherRemark = base.GetDataValue<string>(dr, "ClassTeacherRemark");
                        studentProgress.HeadTeacherRemark = base.GetDataValue<string>(dr, "HeadTeacherRemark");
                        studentProgress.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(studentProgress);
                    }
                }
            }

            return result;
        }
    }
}

