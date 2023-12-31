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
    /// ExamTypes data access component. Manages CRUD operations for the ExamTypes table.
    /// </summary>
    public partial class ExamTypeDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the ExamTypes table.
        /// </summary>
        /// <param name="examType">A ExamType object.</param>
        /// <returns>An updated ExamType object.</returns>
        public ExamType Create(ExamType examType)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.ExamTypes ([ShortCode], [Description], [ROrder], [PercentageContribution], [Status], [IsDeleted]) " +
                "VALUES(@ShortCode, @Description, @ROrder, @PercentageContribution, @Status, @IsDeleted); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@ShortCode", DbType.String, examType.ShortCode);
                db.AddInParameter(cmd, "@Description", DbType.String, examType.Description);
                db.AddInParameter(cmd, "@ROrder", DbType.Int32, examType.ROrder);
                db.AddInParameter(cmd, "@PercentageContribution", DbType.Int32, examType.PercentageContribution);
                db.AddInParameter(cmd, "@Status", DbType.StringFixedLength, examType.Status);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, examType.IsDeleted);

                // Get the primary key value.
                examType.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return examType;
        }

        /// <summary>
        /// Updates an existing row in the ExamTypes table.
        /// </summary>
        /// <param name="examType">A ExamType entity object.</param>
        public void UpdateById(ExamType examType)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.ExamTypes " +
                "SET " +
                    "[ShortCode]=@ShortCode, " +
                    "[Description]=@Description, " +
                    "[ROrder]=@ROrder, " +
                    "[PercentageContribution]=@PercentageContribution, " +
                    "[Status]=@Status, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@ShortCode", DbType.String, examType.ShortCode);
                db.AddInParameter(cmd, "@Description", DbType.String, examType.Description);
                db.AddInParameter(cmd, "@ROrder", DbType.Int32, examType.ROrder);
                db.AddInParameter(cmd, "@PercentageContribution", DbType.Int32, examType.PercentageContribution);
                db.AddInParameter(cmd, "@Status", DbType.StringFixedLength, examType.Status);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, examType.IsDeleted);
                db.AddInParameter(cmd, "@Id", DbType.Int32, examType.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the ExamTypes table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.ExamTypes " +
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
        /// Returns a row from the ExamTypes table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A ExamType object with data populated from the database.</returns>
        public ExamType SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [ShortCode], [Description], [ROrder], [PercentageContribution], [Status], [IsDeleted]" +
                        " " +
                "FROM dbo.ExamTypes  " +
                "WHERE [Id]=@Id ";

            ExamType examType = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new ExamType
                        examType = new ExamType();

                        // Read values.
                        examType.Id = base.GetDataValue<int>(dr, "Id");
                        examType.ShortCode = base.GetDataValue<string>(dr, "ShortCode");
                        examType.Description = base.GetDataValue<string>(dr, "Description");
                        examType.ROrder = base.GetDataValue<int>(dr, "ROrder");
                        examType.PercentageContribution = base.GetDataValue<int>(dr, "PercentageContribution");
                        examType.Status = Convert.ToChar(base.GetDataValue<string>(dr, "Status"));
                        examType.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return examType;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the ExamTypes table.
        /// </summary>
        /// <returns>A collection of ExamType objects.</returns>		
        public List<ExamType> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [ShortCode], [Description], [ROrder], [PercentageContribution], [Status], [IsDeleted]" +
                        " " +
                "FROM dbo.ExamTypes ";

            List<ExamType> result = new List<ExamType>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new ExamType
                        ExamType examType = new ExamType();

                        // Read values.
                        examType.Id = base.GetDataValue<int>(dr, "Id");
                        examType.ShortCode = base.GetDataValue<string>(dr, "ShortCode");
                        examType.Description = base.GetDataValue<string>(dr, "Description");
                        examType.ROrder = base.GetDataValue<int>(dr, "ROrder");
                        examType.PercentageContribution = base.GetDataValue<int>(dr, "PercentageContribution");
                        examType.Status = Convert.ToChar(base.GetDataValue<string>(dr, "Status"));
                        examType.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(examType);
                    }
                }
            }

            return result;
        }
    }
}

