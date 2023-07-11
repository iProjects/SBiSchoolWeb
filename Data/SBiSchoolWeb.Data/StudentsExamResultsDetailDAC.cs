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
    /// StudentsExamResultsDetail data access component. Manages CRUD operations for the StudentsExamResultsDetail table.
    /// </summary>
    public partial class StudentsExamResultsDetailDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the StudentsExamResultsDetail table.
        /// </summary>
        /// <param name="studentsExamResultsDetail">A StudentsExamResultsDetail object.</param>
        /// <returns>An updated StudentsExamResultsDetail object.</returns>
        public StudentsExamResultsDetail Create(StudentsExamResultsDetail studentsExamResultsDetail)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.StudentsExamResultsDetail ([StudentsExamResultsId], [SubjectShortCode], [Mark], [Grade], [Mark_Target], [Grade_Target], [IsDeleted]) " +
                "VALUES(@StudentsExamResultsId, @SubjectShortCode, @Mark, @Grade, @Mark_Target, @Grade_Target, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@StudentsExamResultsId", DbType.Int32, studentsExamResultsDetail.StudentsExamResultsId);
                db.AddInParameter(cmd, "@SubjectShortCode", DbType.String, studentsExamResultsDetail.SubjectShortCode);
                db.AddInParameter(cmd, "@Mark", DbType.Double, studentsExamResultsDetail.Mark);
                db.AddInParameter(cmd, "@Grade", DbType.StringFixedLength, studentsExamResultsDetail.Grade);
                db.AddInParameter(cmd, "@Mark_Target", DbType.Double, studentsExamResultsDetail.Mark_Target);
                db.AddInParameter(cmd, "@Grade_Target", DbType.StringFixedLength, studentsExamResultsDetail.Grade_Target);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, studentsExamResultsDetail.IsDeleted);

                // Get the primary key value.
                studentsExamResultsDetail.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return studentsExamResultsDetail;
        }

        /// <summary>
        /// Updates an existing row in the StudentsExamResultsDetail table.
        /// </summary>
        /// <param name="studentsExamResultsDetail">A StudentsExamResultsDetail entity object.</param>
        public void UpdateById(StudentsExamResultsDetail studentsExamResultsDetail)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.StudentsExamResultsDetail " +
                "SET " +
                    "[StudentsExamResultsId]=@StudentsExamResultsId, " +
                    "[SubjectShortCode]=@SubjectShortCode, " +
                    "[Mark]=@Mark, " +
                    "[Grade]=@Grade, " +
                    "[Mark_Target]=@Mark_Target, " +
                    "[Grade_Target]=@Grade_Target, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@StudentsExamResultsId", DbType.Int32, studentsExamResultsDetail.StudentsExamResultsId);
                db.AddInParameter(cmd, "@SubjectShortCode", DbType.String, studentsExamResultsDetail.SubjectShortCode);
                db.AddInParameter(cmd, "@Mark", DbType.Double, studentsExamResultsDetail.Mark);
                db.AddInParameter(cmd, "@Grade", DbType.StringFixedLength, studentsExamResultsDetail.Grade);
                db.AddInParameter(cmd, "@Mark_Target", DbType.Double, studentsExamResultsDetail.Mark_Target);
                db.AddInParameter(cmd, "@Grade_Target", DbType.StringFixedLength, studentsExamResultsDetail.Grade_Target);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, studentsExamResultsDetail.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, studentsExamResultsDetail.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the StudentsExamResultsDetail table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.StudentsExamResultsDetail " +
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
        /// Returns a row from the StudentsExamResultsDetail table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A StudentsExamResultsDetail object with data populated from the database.</returns>
        public StudentsExamResultsDetail SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [StudentsExamResultsId], [SubjectShortCode], [Mark], [Grade], [Mark_Target]" +
                        ", [Grade_Target], [IsDeleted] " +
                "FROM dbo.StudentsExamResultsDetail  " +
                "WHERE [Id]=@Id ";

            StudentsExamResultsDetail studentsExamResultsDetail = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new StudentsExamResultsDetail
                        studentsExamResultsDetail = new StudentsExamResultsDetail();

                        // Read values.
                        studentsExamResultsDetail.Id = base.GetDataValue<int>(dr, "Id");
                        studentsExamResultsDetail.StudentsExamResultsId = base.GetDataValue<int>(dr, "StudentsExamResultsId");
                        studentsExamResultsDetail.SubjectShortCode = base.GetDataValue<string>(dr, "SubjectShortCode");
                        studentsExamResultsDetail.Mark = base.GetDataValue<double>(dr, "Mark");
                        studentsExamResultsDetail.Grade = base.GetDataValue<string>(dr, "Grade");
                        studentsExamResultsDetail.Mark_Target = base.GetDataValue<double>(dr, "Mark_Target");
                        studentsExamResultsDetail.Grade_Target = base.GetDataValue<string>(dr, "Grade_Target");
                        studentsExamResultsDetail.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return studentsExamResultsDetail;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the StudentsExamResultsDetail table.
        /// </summary>
        /// <returns>A collection of StudentsExamResultsDetail objects.</returns>		
        public List<StudentsExamResultsDetail> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [StudentsExamResultsId], [SubjectShortCode], [Mark], [Grade], [Mark_Target]" +
                        ", [Grade_Target], [IsDeleted] " +
                "FROM dbo.StudentsExamResultsDetail ";

            List<StudentsExamResultsDetail> result = new List<StudentsExamResultsDetail>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new StudentsExamResultsDetail
                        StudentsExamResultsDetail studentsExamResultsDetail = new StudentsExamResultsDetail();

                        // Read values.
                        studentsExamResultsDetail.Id = base.GetDataValue<int>(dr, "Id");
                        studentsExamResultsDetail.StudentsExamResultsId = base.GetDataValue<int>(dr, "StudentsExamResultsId");
                        studentsExamResultsDetail.SubjectShortCode = base.GetDataValue<string>(dr, "SubjectShortCode");
                        studentsExamResultsDetail.Mark = base.GetDataValue<double>(dr, "Mark");
                        studentsExamResultsDetail.Grade = base.GetDataValue<string>(dr, "Grade");
                        studentsExamResultsDetail.Mark_Target = base.GetDataValue<double>(dr, "Mark_Target");
                        studentsExamResultsDetail.Grade_Target = base.GetDataValue<string>(dr, "Grade_Target");
                        studentsExamResultsDetail.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(studentsExamResultsDetail);
                    }
                }
            }

            return result;
        }
    }
}
