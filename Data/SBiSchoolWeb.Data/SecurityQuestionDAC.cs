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
    /// SecurityQuestions data access component. Manages CRUD operations for the SecurityQuestions table.
    /// </summary>
    public partial class SecurityQuestionDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the SecurityQuestions table.
        /// </summary>
        /// <param name="securityQuestion">A SecurityQuestion object.</param>
        /// <returns>An updated SecurityQuestion object.</returns>
        public SecurityQuestion Create(SecurityQuestion securityQuestion)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.SecurityQuestions ([PasswordQuestion]) " +
                "VALUES(@PasswordQuestion);  ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@PasswordQuestion", DbType.String, securityQuestion.PasswordQuestion);

                db.ExecuteNonQuery(cmd);
            }

            return securityQuestion;
        }

        /// <summary>
        /// Updates an existing row in the SecurityQuestions table.
        /// </summary>
        /// <param name="securityQuestion">A SecurityQuestion entity object.</param>
        public void UpdateById(SecurityQuestion securityQuestion)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.SecurityQuestions " +
                "SET " +
                "WHERE [PasswordQuestion]=@PasswordQuestion ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@PasswordQuestion", DbType.String, securityQuestion.PasswordQuestion);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the SecurityQuestions table.
        /// </summary>
        /// <param name="passwordQuestion">A passwordQuestion value.</param>
        public void DeleteById(string passwordQuestion)
        {
            const string SQL_STATEMENT = "DELETE dbo.SecurityQuestions " +
                                         "WHERE [PasswordQuestion]=@PasswordQuestion ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@PasswordQuestion", DbType.String, passwordQuestion);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Returns a row from the SecurityQuestions table.
        /// </summary>
        /// <param name="passwordQuestion">A PasswordQuestion value.</param>
        /// <returns>A SecurityQuestion object with data populated from the database.</returns>
        public SecurityQuestion SelectById(string passwordQuestion)
        {
            const string SQL_STATEMENT =
                "SELECT [PasswordQuestion] " +
                "FROM dbo.SecurityQuestions  " +
                "WHERE [PasswordQuestion]=@PasswordQuestion ";

            SecurityQuestion securityQuestion = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@PasswordQuestion", DbType.String, passwordQuestion);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new SecurityQuestion
                        securityQuestion = new SecurityQuestion();

                        // Read values.
                        securityQuestion.PasswordQuestion = base.GetDataValue<string>(dr, "PasswordQuestion");
                    }
                }
            }

            return securityQuestion;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the SecurityQuestions table.
        /// </summary>
        /// <returns>A collection of SecurityQuestion objects.</returns>		
        public List<SecurityQuestion> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [PasswordQuestion] " +
                "FROM dbo.SecurityQuestions ";

            List<SecurityQuestion> result = new List<SecurityQuestion>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new SecurityQuestion
                        SecurityQuestion securityQuestion = new SecurityQuestion();

                        // Read values.
                        securityQuestion.PasswordQuestion = base.GetDataValue<string>(dr, "PasswordQuestion");

                        // Add to List.
                        result.Add(securityQuestion);
                    }
                }
            }

            return result;
        }
    }
}

