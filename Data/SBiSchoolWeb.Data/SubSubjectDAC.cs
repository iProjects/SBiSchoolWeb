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
    /// SubSubjects data access component. Manages CRUD operations for the SubSubjects table.
    /// </summary>
    public partial class SubSubjectDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the SubSubjects table.
        /// </summary>
        /// <param name="subSubject">A SubSubject object.</param>
        /// <returns>An updated SubSubject object.</returns>
        public SubSubject Create(SubSubject subSubject)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.SubSubjects ([SubjectShortCode], [Description], [OutOf], [PassMark], [GroupingFactor], [IsDeleted]) " +
                "VALUES(@SubjectShortCode, @Description, @OutOf, @PassMark, @GroupingFactor, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@SubjectShortCode", DbType.String, subSubject.SubjectShortCode);
                db.AddInParameter(cmd, "@Description", DbType.String, subSubject.Description);
                db.AddInParameter(cmd, "@OutOf", DbType.Int32, subSubject.OutOf);
                db.AddInParameter(cmd, "@PassMark", DbType.Int32, subSubject.PassMark);
                db.AddInParameter(cmd, "@GroupingFactor", DbType.Int32, subSubject.GroupingFactor);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, subSubject.IsDeleted);

                // Get the primary key value.
                subSubject.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return subSubject;
        }

        /// <summary>
        /// Updates an existing row in the SubSubjects table.
        /// </summary>
        /// <param name="subSubject">A SubSubject entity object.</param>
        public void UpdateById(SubSubject subSubject)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.SubSubjects " +
                "SET " +
                    "[SubjectShortCode]=@SubjectShortCode, " +
                    "[Description]=@Description, " +
                    "[OutOf]=@OutOf, " +
                    "[PassMark]=@PassMark, " +
                    "[GroupingFactor]=@GroupingFactor, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@SubjectShortCode", DbType.String, subSubject.SubjectShortCode);
                db.AddInParameter(cmd, "@Description", DbType.String, subSubject.Description);
                db.AddInParameter(cmd, "@OutOf", DbType.Int32, subSubject.OutOf);
                db.AddInParameter(cmd, "@PassMark", DbType.Int32, subSubject.PassMark);
                db.AddInParameter(cmd, "@GroupingFactor", DbType.Int32, subSubject.GroupingFactor);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, subSubject.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, subSubject.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the SubSubjects table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.SubSubjects " +
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
        /// Returns a row from the SubSubjects table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A SubSubject object with data populated from the database.</returns>
        public SubSubject SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [SubjectShortCode], [Description], [OutOf], [PassMark], [GroupingFactor], [IsDeleted]" +
                        " " +
                "FROM dbo.SubSubjects  " +
                "WHERE [Id]=@Id ";

            SubSubject subSubject = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new SubSubject
                        subSubject = new SubSubject();

                        // Read values.
                        subSubject.Id = base.GetDataValue<int>(dr, "Id");
                        subSubject.SubjectShortCode = base.GetDataValue<string>(dr, "SubjectShortCode");
                        subSubject.Description = base.GetDataValue<string>(dr, "Description");
                        subSubject.OutOf = base.GetDataValue<int>(dr, "OutOf");
                        subSubject.PassMark = base.GetDataValue<int>(dr, "PassMark");
                        subSubject.GroupingFactor = base.GetDataValue<int>(dr, "GroupingFactor");
                        subSubject.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return subSubject;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the SubSubjects table.
        /// </summary>
        /// <returns>A collection of SubSubject objects.</returns>		
        public List<SubSubject> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [SubjectShortCode], [Description], [OutOf], [PassMark], [GroupingFactor], [IsDeleted]" +
                        " " +
                "FROM dbo.SubSubjects ";

            List<SubSubject> result = new List<SubSubject>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new SubSubject
                        SubSubject subSubject = new SubSubject();

                        // Read values.
                        subSubject.Id = base.GetDataValue<int>(dr, "Id");
                        subSubject.SubjectShortCode = base.GetDataValue<string>(dr, "SubjectShortCode");
                        subSubject.Description = base.GetDataValue<string>(dr, "Description");
                        subSubject.OutOf = base.GetDataValue<int>(dr, "OutOf");
                        subSubject.PassMark = base.GetDataValue<int>(dr, "PassMark");
                        subSubject.GroupingFactor = base.GetDataValue<int>(dr, "GroupingFactor");
                        subSubject.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(subSubject);
                    }
                }
            }

            return result;
        }
    }
}

