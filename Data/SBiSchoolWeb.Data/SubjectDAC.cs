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
    /// Subjects data access component. Manages CRUD operations for the Subjects table.
    /// </summary>
    public partial class SubjectDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Subjects table.
        /// </summary>
        /// <param name="subject">A Subject object.</param>
        /// <returns>An updated Subject object.</returns>
        public Subject Create(Subject subject)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Subjects ([ShortCode], [Description], [OutOf], [PassMark], [NoOfRequiredHours], [Fees], [ROrder], [Status], [Remarks], [IsDeleted]) " +
                "VALUES(@ShortCode, @Description, @OutOf, @PassMark, @NoOfRequiredHours, @Fees, @ROrder, @Status, @Remarks, @IsDeleted);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@ShortCode", DbType.String, subject.ShortCode);
                db.AddInParameter(cmd, "@Description", DbType.String, subject.Description);
                db.AddInParameter(cmd, "@OutOf", DbType.Int32, subject.OutOf);
                db.AddInParameter(cmd, "@PassMark", DbType.Int32, subject.PassMark);
                db.AddInParameter(cmd, "@NoOfRequiredHours", DbType.Int32, subject.NoOfRequiredHours);
                db.AddInParameter(cmd, "@Fees", DbType.Currency, subject.Fees);
                db.AddInParameter(cmd, "@ROrder", DbType.Int32, subject.ROrder);
                db.AddInParameter(cmd, "@Status", DbType.StringFixedLength, subject.Status);
                db.AddInParameter(cmd, "@Remarks", DbType.String, subject.Remarks);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, subject.IsDeleted);

                db.ExecuteNonQuery(cmd);
            }

            return subject;
        }

        /// <summary>
        /// Updates an existing row in the Subjects table.
        /// </summary>
        /// <param name="subject">A Subject entity object.</param>
        public void UpdateById(Subject subject)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Subjects " +
                "SET " +
                    "[Description]=@Description, " +
                    "[OutOf]=@OutOf, " +
                    "[PassMark]=@PassMark, " +
                    "[NoOfRequiredHours]=@NoOfRequiredHours, " +
                    "[Fees]=@Fees, " +
                    "[ROrder]=@ROrder, " +
                    "[Status]=@Status, " +
                    "[Remarks]=@Remarks, " +
                    "[IsDeleted]=@IsDeleted " +
                "WHERE [ShortCode]=@ShortCode ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Description", DbType.String, subject.Description);
                db.AddInParameter(cmd, "@OutOf", DbType.Int32, subject.OutOf);
                db.AddInParameter(cmd, "@PassMark", DbType.Int32, subject.PassMark);
                db.AddInParameter(cmd, "@NoOfRequiredHours", DbType.Int32, subject.NoOfRequiredHours);
                db.AddInParameter(cmd, "@Fees", DbType.Currency, subject.Fees);
                db.AddInParameter(cmd, "@ROrder", DbType.Int32, subject.ROrder);
                db.AddInParameter(cmd, "@Status", DbType.StringFixedLength, subject.Status);
                db.AddInParameter(cmd, "@Remarks", DbType.String, subject.Remarks);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, subject.IsDeleted);
                db.AddInParameter(cmd, "@ShortCode", DbType.String, subject.ShortCode);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the Subjects table.
        /// </summary>
        /// <param name="shortCode">A shortCode value.</param>
        public void DeleteById(string shortCode)
        {
            const string SQL_STATEMENT = "DELETE dbo.Subjects " +
                                         "WHERE [ShortCode]=@ShortCode ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@ShortCode", DbType.String, shortCode);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the Subjects table.
        /// </summary>
        /// <param name="shortCode">A ShortCode value.</param>
        /// <returns>A Subject object with data populated from the database.</returns>
        public Subject SelectById(string shortCode)
        {
            const string SQL_STATEMENT =
                "SELECT [ShortCode], [Description], [OutOf], [PassMark], [NoOfRequiredHours], [Fees], [ROrder]" +
                        ", [Status], [Remarks], [IsDeleted] " +
                "FROM dbo.Subjects  " +
                "WHERE [ShortCode]=@ShortCode ";

            Subject subject = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ShortCode", DbType.String, shortCode);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Subject
                        subject = new Subject();

                        // Read values.
                        subject.ShortCode = base.GetDataValue<string>(dr, "ShortCode");
                        subject.Description = base.GetDataValue<string>(dr, "Description");
                        subject.OutOf = base.GetDataValue<int>(dr, "OutOf");
                        subject.PassMark = base.GetDataValue<int>(dr, "PassMark");
                        subject.NoOfRequiredHours = base.GetDataValue<int>(dr, "NoOfRequiredHours");
                        subject.Fees = base.GetDataValue<decimal>(dr, "Fees");
                        subject.ROrder = base.GetDataValue<int>(dr, "ROrder");
                        subject.Status = Convert.ToChar(base.GetDataValue<string>(dr, "Status"));
                        subject.Remarks = base.GetDataValue<string>(dr, "Remarks");
                        subject.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                    }
                }
            }

            return subject;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Subjects table.
        /// </summary>
        /// <returns>A collection of Subject objects.</returns>		
        public List<Subject> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [ShortCode], [Description], [OutOf], [PassMark], [NoOfRequiredHours], [Fees], [ROrder]" +
                        ", [Status], [Remarks], [IsDeleted] " +
                "FROM dbo.Subjects ";

            List<Subject> result = new List<Subject>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Subject
                        Subject subject = new Subject();

                        // Read values.
                        subject.ShortCode = base.GetDataValue<string>(dr, "ShortCode");
                        subject.Description = base.GetDataValue<string>(dr, "Description");
                        subject.OutOf = base.GetDataValue<int>(dr, "OutOf");
                        subject.PassMark = base.GetDataValue<int>(dr, "PassMark");
                        subject.NoOfRequiredHours = base.GetDataValue<int>(dr, "NoOfRequiredHours");
                        subject.Fees = base.GetDataValue<decimal>(dr, "Fees");
                        subject.ROrder = base.GetDataValue<int>(dr, "ROrder");
                        subject.Status = Convert.ToChar(base.GetDataValue<string>(dr, "Status"));
                        subject.Remarks = base.GetDataValue<string>(dr, "Remarks");
                        subject.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");

                        // Add to List.
                        result.Add(subject);
                    }
                }
            }

            return result;
        }
    }
}
