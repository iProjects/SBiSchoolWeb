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
    /// ClassStreams data access component. Manages CRUD operations for the ClassStreams table.
    /// </summary>
    public partial class ClassStreamDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the ClassStreams table.
        /// </summary>
        /// <param name="classStream">A ClassStream object.</param>
        /// <returns>An updated ClassStream object.</returns>
        public ClassStream Create(ClassStream classStream)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.ClassStreams ([ClassId], [Description], [IsDeleted]) " +
                "VALUES(@ClassId, @Description, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@ClassId", DbType.Int32, classStream.ClassId);
                db.AddInParameter(cmd, "@Description", DbType.String, classStream.Description);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, classStream.IsDeleted);

                // Get the primary key value.
                classStream.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return classStream;
        }

        /// <summary>
        /// Updates an existing row in the ClassStreams table.
        /// </summary>
        /// <param name="classStream">A ClassStream entity object.</param>
        public void UpdateById(ClassStream classStream)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.ClassStreams " +
                "SET " +
                    "[ClassId]=@ClassId, " +
                    "[Description]=@Description, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@ClassId", DbType.Int32, classStream.ClassId);
                db.AddInParameter(cmd, "@Description", DbType.String, classStream.Description);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, classStream.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, classStream.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the ClassStreams table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.ClassStreams " +
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
        /// Returns a row from the ClassStreams table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A ClassStream object with data populated from the database.</returns>
        public ClassStream SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [ClassId], [Description], [IsDeleted] " +
                "FROM dbo.ClassStreams  " +
                "WHERE [Id]=@Id ";

            ClassStream classStream = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new ClassStream
                        classStream = new ClassStream();

                        // Read values.
                        classStream.Id = base.GetDataValue<int>(dr, "Id");
                        classStream.ClassId = base.GetDataValue<int>(dr, "ClassId");
                        classStream.Description = base.GetDataValue<string>(dr, "Description");
                        classStream.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return classStream;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the ClassStreams table.
        /// </summary>
        /// <returns>A collection of ClassStream objects.</returns>		
        public List<ClassStream> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [ClassId], [Description], [IsDeleted] " +
                "FROM dbo.ClassStreams ";

            List<ClassStream> result = new List<ClassStream>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new ClassStream
                        ClassStream classStream = new ClassStream();

                        // Read values.
                        classStream.Id = base.GetDataValue<int>(dr, "Id");
                        classStream.ClassId = base.GetDataValue<int>(dr, "ClassId");
                        classStream.Description = base.GetDataValue<string>(dr, "Description");
                        classStream.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(classStream);
                    }
                }
            }

            return result;
        }
    }
}

