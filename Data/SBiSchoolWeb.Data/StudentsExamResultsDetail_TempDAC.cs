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
    /// StudentsExamResultsDetail_Temp data access component. Manages CRUD operations for the StudentsExamResultsDetail_Temp table.
    /// </summary>
    public partial class StudentsExamResultsDetail_TempDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the StudentsExamResultsDetail_Temp table.
        /// </summary>
        /// <param name="studentsExamResultsDetail_Temp">A StudentsExamResultsDetail_Temp object.</param>
        /// <returns>An updated StudentsExamResultsDetail_Temp object.</returns>
        public StudentsExamResultsDetail_Temp Create(StudentsExamResultsDetail_Temp studentsExamResultsDetail_Temp)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.StudentsExamResultsDetail_Temp ([StudentsExamResults_TempId], [SubjectShortCode], [Mark], [Grade], [Mark_Target], [Grade_Target], [IsDeleted]) " +
                "VALUES(@StudentsExamResults_TempId, @SubjectShortCode, @Mark, @Grade, @Mark_Target, @Grade_Target, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@StudentsExamResults_TempId", DbType.Int32, studentsExamResultsDetail_Temp.StudentsExamResults_TempId);
                db.AddInParameter(cmd, "@SubjectShortCode", DbType.String, studentsExamResultsDetail_Temp.SubjectShortCode);
                db.AddInParameter(cmd, "@Mark", DbType.Double, studentsExamResultsDetail_Temp.Mark);
                db.AddInParameter(cmd, "@Grade", DbType.StringFixedLength, studentsExamResultsDetail_Temp.Grade);
                db.AddInParameter(cmd, "@Mark_Target", DbType.Double, studentsExamResultsDetail_Temp.Mark_Target);
                db.AddInParameter(cmd, "@Grade_Target", DbType.StringFixedLength, studentsExamResultsDetail_Temp.Grade_Target);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, studentsExamResultsDetail_Temp.IsDeleted);

                // Get the primary key value.
                studentsExamResultsDetail_Temp.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return studentsExamResultsDetail_Temp;
        }

        /// <summary>
        /// Updates an existing row in the StudentsExamResultsDetail_Temp table.
        /// </summary>
        /// <param name="studentsExamResultsDetail_Temp">A StudentsExamResultsDetail_Temp entity object.</param>
        public void UpdateById(StudentsExamResultsDetail_Temp studentsExamResultsDetail_Temp)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.StudentsExamResultsDetail_Temp " +
                "SET " +
                    "[StudentsExamResults_TempId]=@StudentsExamResults_TempId, " +
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
                db.AddInParameter(cmd, "@StudentsExamResults_TempId", DbType.Int32, studentsExamResultsDetail_Temp.StudentsExamResults_TempId);
                db.AddInParameter(cmd, "@SubjectShortCode", DbType.String, studentsExamResultsDetail_Temp.SubjectShortCode);
                db.AddInParameter(cmd, "@Mark", DbType.Double, studentsExamResultsDetail_Temp.Mark);
                db.AddInParameter(cmd, "@Grade", DbType.StringFixedLength, studentsExamResultsDetail_Temp.Grade);
                db.AddInParameter(cmd, "@Mark_Target", DbType.Double, studentsExamResultsDetail_Temp.Mark_Target);
                db.AddInParameter(cmd, "@Grade_Target", DbType.StringFixedLength, studentsExamResultsDetail_Temp.Grade_Target);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, studentsExamResultsDetail_Temp.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, studentsExamResultsDetail_Temp.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the StudentsExamResultsDetail_Temp table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.StudentsExamResultsDetail_Temp " +
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
        /// Returns a row from the StudentsExamResultsDetail_Temp table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A StudentsExamResultsDetail_Temp object with data populated from the database.</returns>
        public StudentsExamResultsDetail_Temp SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [StudentsExamResults_TempId], [SubjectShortCode], [Mark], [Grade], [Mark_Target]" +
                        ", [Grade_Target], [IsDeleted] " +
                "FROM dbo.StudentsExamResultsDetail_Temp  " +
                "WHERE [Id]=@Id ";

            StudentsExamResultsDetail_Temp studentsExamResultsDetail_Temp = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new StudentsExamResultsDetail_Temp
                        studentsExamResultsDetail_Temp = new StudentsExamResultsDetail_Temp();

                        // Read values.
                        studentsExamResultsDetail_Temp.Id = base.GetDataValue<int>(dr, "Id");
                        studentsExamResultsDetail_Temp.StudentsExamResults_TempId = base.GetDataValue<int>(dr, "StudentsExamResults_TempId");
                        studentsExamResultsDetail_Temp.SubjectShortCode = base.GetDataValue<string>(dr, "SubjectShortCode");
                        studentsExamResultsDetail_Temp.Mark = base.GetDataValue<double>(dr, "Mark");
                        studentsExamResultsDetail_Temp.Grade = base.GetDataValue<string>(dr, "Grade");
                        studentsExamResultsDetail_Temp.Mark_Target = base.GetDataValue<double>(dr, "Mark_Target");
                        studentsExamResultsDetail_Temp.Grade_Target = base.GetDataValue<string>(dr, "Grade_Target");
                        studentsExamResultsDetail_Temp.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return studentsExamResultsDetail_Temp;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the StudentsExamResultsDetail_Temp table.
        /// </summary>
        /// <returns>A collection of StudentsExamResultsDetail_Temp objects.</returns>		
        public List<StudentsExamResultsDetail_Temp> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [StudentsExamResults_TempId], [SubjectShortCode], [Mark], [Grade], [Mark_Target]" +
                        ", [Grade_Target], [IsDeleted] " +
                "FROM dbo.StudentsExamResultsDetail_Temp ";

            List<StudentsExamResultsDetail_Temp> result = new List<StudentsExamResultsDetail_Temp>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new StudentsExamResultsDetail_Temp
                        StudentsExamResultsDetail_Temp studentsExamResultsDetail_Temp = new StudentsExamResultsDetail_Temp();

                        // Read values.
                        studentsExamResultsDetail_Temp.Id = base.GetDataValue<int>(dr, "Id");
                        studentsExamResultsDetail_Temp.StudentsExamResults_TempId = base.GetDataValue<int>(dr, "StudentsExamResults_TempId");
                        studentsExamResultsDetail_Temp.SubjectShortCode = base.GetDataValue<string>(dr, "SubjectShortCode");
                        studentsExamResultsDetail_Temp.Mark = base.GetDataValue<double>(dr, "Mark");
                        studentsExamResultsDetail_Temp.Grade = base.GetDataValue<string>(dr, "Grade");
                        studentsExamResultsDetail_Temp.Mark_Target = base.GetDataValue<double>(dr, "Mark_Target");
                        studentsExamResultsDetail_Temp.Grade_Target = base.GetDataValue<string>(dr, "Grade_Target");
                        studentsExamResultsDetail_Temp.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(studentsExamResultsDetail_Temp);
                    }
                }
            }

            return result;
        }
    }
}

