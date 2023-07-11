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
    /// SBSchoolMessages data access component. Manages CRUD operations for the SBSchoolMessages table.
    /// </summary>
    public partial class SBSchoolMessageDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the SBSchoolMessages table.
        /// </summary>
        /// <param name="sBSchoolMessage">A SBSchoolMessage object.</param>
        /// <returns>An updated SBSchoolMessage object.</returns>
        public SBSchoolMessage Create(SBSchoolMessage sBSchoolMessage)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.SBSchoolMessages ([MemberId], [SenderTelno], [CustomerTelno], [Command], [MessageType], [Status], [Body], [MessageDate], [AccountId], [StartDate], [EndDate], [Amount], [HM_Param], [BE_AccLabel], [ST_StartDate], [ST_EndDate], [OfferId], [Email], [Pwd], [NotificationMethod], [MO_Term], [MO_Interest], [CP_NewPassword], [CP_ConfirmPassword], [NationalID], [MpesaRef], [MpesaSentDate], [MpesaBal], [Exception]) " +
                "VALUES(@MemberId, @SenderTelno, @CustomerTelno, @Command, @MessageType, @Status, @Body, @MessageDate, @AccountId, @StartDate, @EndDate, @Amount, @HM_Param, @BE_AccLabel, @ST_StartDate, @ST_EndDate, @OfferId, @Email, @Pwd, @NotificationMethod, @MO_Term, @MO_Interest, @CP_NewPassword, @CP_ConfirmPassword, @NationalID, @MpesaRef, @MpesaSentDate, @MpesaBal, @Exception); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@MemberId", DbType.Int32, sBSchoolMessage.MemberId);
                db.AddInParameter(cmd, "@SenderTelno", DbType.String, sBSchoolMessage.SenderTelno);
                db.AddInParameter(cmd, "@CustomerTelno", DbType.String, sBSchoolMessage.CustomerTelno);
                db.AddInParameter(cmd, "@Command", DbType.String, sBSchoolMessage.Command);
                db.AddInParameter(cmd, "@MessageType", DbType.Int32, sBSchoolMessage.MessageType);
                db.AddInParameter(cmd, "@Status", DbType.String, sBSchoolMessage.Status);
                db.AddInParameter(cmd, "@Body", DbType.String, sBSchoolMessage.Body);
                db.AddInParameter(cmd, "@MessageDate", DbType.DateTime2, sBSchoolMessage.MessageDate);
                db.AddInParameter(cmd, "@AccountId", DbType.Int32, sBSchoolMessage.AccountId);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime2, sBSchoolMessage.StartDate);
                db.AddInParameter(cmd, "@EndDate", DbType.DateTime2, sBSchoolMessage.EndDate);
                db.AddInParameter(cmd, "@Amount", DbType.Currency, sBSchoolMessage.Amount);
                db.AddInParameter(cmd, "@HM_Param", DbType.String, sBSchoolMessage.HM_Param);
                db.AddInParameter(cmd, "@BE_AccLabel", DbType.String, sBSchoolMessage.BE_AccLabel);
                db.AddInParameter(cmd, "@ST_StartDate", DbType.DateTime2, sBSchoolMessage.ST_StartDate);
                db.AddInParameter(cmd, "@ST_EndDate", DbType.DateTime2, sBSchoolMessage.ST_EndDate);
                db.AddInParameter(cmd, "@OfferId", DbType.Int32, sBSchoolMessage.OfferId);
                db.AddInParameter(cmd, "@Email", DbType.String, sBSchoolMessage.Email);
                db.AddInParameter(cmd, "@Pwd", DbType.String, sBSchoolMessage.Pwd);
                db.AddInParameter(cmd, "@NotificationMethod", DbType.String, sBSchoolMessage.NotificationMethod);
                db.AddInParameter(cmd, "@MO_Term", DbType.Int32, sBSchoolMessage.MO_Term);
                db.AddInParameter(cmd, "@MO_Interest", DbType.Double, sBSchoolMessage.MO_Interest);
                db.AddInParameter(cmd, "@CP_NewPassword", DbType.String, sBSchoolMessage.CP_NewPassword);
                db.AddInParameter(cmd, "@CP_ConfirmPassword", DbType.String, sBSchoolMessage.CP_ConfirmPassword);
                db.AddInParameter(cmd, "@NationalID", DbType.String, sBSchoolMessage.NationalID);
                db.AddInParameter(cmd, "@MpesaRef", DbType.String, sBSchoolMessage.MpesaRef);
                db.AddInParameter(cmd, "@MpesaSentDate", DbType.DateTime2, sBSchoolMessage.MpesaSentDate);
                db.AddInParameter(cmd, "@MpesaBal", DbType.Currency, sBSchoolMessage.MpesaBal);
                db.AddInParameter(cmd, "@Exception", DbType.String, sBSchoolMessage.Exception);

                // Get the primary key value.
                sBSchoolMessage.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return sBSchoolMessage;
        }

        /// <summary>
        /// Updates an existing row in the SBSchoolMessages table.
        /// </summary>
        /// <param name="sBSchoolMessage">A SBSchoolMessage entity object.</param>
        public void UpdateById(SBSchoolMessage sBSchoolMessage)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.SBSchoolMessages " +
                "SET " +
                    "[MemberId]=@MemberId, " +
                    "[SenderTelno]=@SenderTelno, " +
                    "[CustomerTelno]=@CustomerTelno, " +
                    "[Command]=@Command, " +
                    "[MessageType]=@MessageType, " +
                    "[Status]=@Status, " +
                    "[Body]=@Body, " +
                    "[MessageDate]=@MessageDate, " +
                    "[AccountId]=@AccountId, " +
                    "[StartDate]=@StartDate, " +
                    "[EndDate]=@EndDate, " +
                    "[Amount]=@Amount, " +
                    "[HM_Param]=@HM_Param, " +
                    "[BE_AccLabel]=@BE_AccLabel, " +
                    "[ST_StartDate]=@ST_StartDate, " +
                    "[ST_EndDate]=@ST_EndDate, " +
                    "[OfferId]=@OfferId, " +
                    "[Email]=@Email, " +
                    "[Pwd]=@Pwd, " +
                    "[NotificationMethod]=@NotificationMethod, " +
                    "[MO_Term]=@MO_Term, " +
                    "[MO_Interest]=@MO_Interest, " +
                    "[CP_NewPassword]=@CP_NewPassword, " +
                    "[CP_ConfirmPassword]=@CP_ConfirmPassword, " +
                    "[NationalID]=@NationalID, " +
                    "[MpesaRef]=@MpesaRef, " +
                    "[MpesaSentDate]=@MpesaSentDate, " +
                    "[MpesaBal]=@MpesaBal, " +
                    "[Exception]=@Exception " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@MemberId", DbType.Int32, sBSchoolMessage.MemberId);
                db.AddInParameter(cmd, "@SenderTelno", DbType.String, sBSchoolMessage.SenderTelno);
                db.AddInParameter(cmd, "@CustomerTelno", DbType.String, sBSchoolMessage.CustomerTelno);
                db.AddInParameter(cmd, "@Command", DbType.String, sBSchoolMessage.Command);
                db.AddInParameter(cmd, "@MessageType", DbType.Int32, sBSchoolMessage.MessageType);
                db.AddInParameter(cmd, "@Status", DbType.String, sBSchoolMessage.Status);
                db.AddInParameter(cmd, "@Body", DbType.String, sBSchoolMessage.Body);
                db.AddInParameter(cmd, "@MessageDate", DbType.DateTime2, sBSchoolMessage.MessageDate);
                db.AddInParameter(cmd, "@AccountId", DbType.Int32, sBSchoolMessage.AccountId);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime2, sBSchoolMessage.StartDate);
                db.AddInParameter(cmd, "@EndDate", DbType.DateTime2, sBSchoolMessage.EndDate);
                db.AddInParameter(cmd, "@Amount", DbType.Currency, sBSchoolMessage.Amount);
                db.AddInParameter(cmd, "@HM_Param", DbType.String, sBSchoolMessage.HM_Param);
                db.AddInParameter(cmd, "@BE_AccLabel", DbType.String, sBSchoolMessage.BE_AccLabel);
                db.AddInParameter(cmd, "@ST_StartDate", DbType.DateTime2, sBSchoolMessage.ST_StartDate);
                db.AddInParameter(cmd, "@ST_EndDate", DbType.DateTime2, sBSchoolMessage.ST_EndDate);
                db.AddInParameter(cmd, "@OfferId", DbType.Int32, sBSchoolMessage.OfferId);
                db.AddInParameter(cmd, "@Email", DbType.String, sBSchoolMessage.Email);
                db.AddInParameter(cmd, "@Pwd", DbType.String, sBSchoolMessage.Pwd);
                db.AddInParameter(cmd, "@NotificationMethod", DbType.String, sBSchoolMessage.NotificationMethod);
                db.AddInParameter(cmd, "@MO_Term", DbType.Int32, sBSchoolMessage.MO_Term);
                db.AddInParameter(cmd, "@MO_Interest", DbType.Double, sBSchoolMessage.MO_Interest);
                db.AddInParameter(cmd, "@CP_NewPassword", DbType.String, sBSchoolMessage.CP_NewPassword);
                db.AddInParameter(cmd, "@CP_ConfirmPassword", DbType.String, sBSchoolMessage.CP_ConfirmPassword);
                db.AddInParameter(cmd, "@NationalID", DbType.String, sBSchoolMessage.NationalID);
                db.AddInParameter(cmd, "@MpesaRef", DbType.String, sBSchoolMessage.MpesaRef);
                db.AddInParameter(cmd, "@MpesaSentDate", DbType.DateTime2, sBSchoolMessage.MpesaSentDate);
                db.AddInParameter(cmd, "@MpesaBal", DbType.Currency, sBSchoolMessage.MpesaBal);
                db.AddInParameter(cmd, "@Exception", DbType.String, sBSchoolMessage.Exception);
                db.AddInParameter(cmd, "@Id", DbType.Int32, sBSchoolMessage.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the SBSchoolMessages table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.SBSchoolMessages " +
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
        /// Returns a row from the SBSchoolMessages table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A SBSchoolMessage object with data populated from the database.</returns>
        public SBSchoolMessage SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [MemberId], [SenderTelno], [CustomerTelno], [Command], [MessageType], [Status]" +
                        ", [Body], [MessageDate], [AccountId], [StartDate], [EndDate], [Amount], [HM_Param]" +
                        ", [BE_AccLabel], [ST_StartDate], [ST_EndDate], [OfferId], [Email], [Pwd], [NotificationMethod]" +
                        ", [MO_Term], [MO_Interest], [CP_NewPassword], [CP_ConfirmPassword], [NationalID], [MpesaRef]" +
                        ", [MpesaSentDate], [MpesaBal], [Exception] " +
                "FROM dbo.SBSchoolMessages  " +
                "WHERE [Id]=@Id ";

            SBSchoolMessage sBSchoolMessage = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new SBSchoolMessage
                        sBSchoolMessage = new SBSchoolMessage();

                        // Read values.
                        sBSchoolMessage.Id = base.GetDataValue<int>(dr, "Id");
                        sBSchoolMessage.MemberId = base.GetDataValue<int>(dr, "MemberId");
                        sBSchoolMessage.SenderTelno = base.GetDataValue<string>(dr, "SenderTelno");
                        sBSchoolMessage.CustomerTelno = base.GetDataValue<string>(dr, "CustomerTelno");
                        sBSchoolMessage.Command = base.GetDataValue<string>(dr, "Command");
                        sBSchoolMessage.MessageType = base.GetDataValue<int>(dr, "MessageType");
                        sBSchoolMessage.Status = base.GetDataValue<string>(dr, "Status");
                        sBSchoolMessage.Body = base.GetDataValue<string>(dr, "Body");
                        sBSchoolMessage.MessageDate = base.GetDataValue<DateTime>(dr, "MessageDate");
                        sBSchoolMessage.AccountId = base.GetDataValue<int>(dr, "AccountId");
                        sBSchoolMessage.StartDate = base.GetDataValue<DateTime>(dr, "StartDate");
                        sBSchoolMessage.EndDate = base.GetDataValue<DateTime>(dr, "EndDate");
                        sBSchoolMessage.Amount = base.GetDataValue<decimal>(dr, "Amount");
                        sBSchoolMessage.HM_Param = base.GetDataValue<string>(dr, "HM_Param");
                        sBSchoolMessage.BE_AccLabel = base.GetDataValue<string>(dr, "BE_AccLabel");
                        sBSchoolMessage.ST_StartDate = base.GetDataValue<DateTime>(dr, "ST_StartDate");
                        sBSchoolMessage.ST_EndDate = base.GetDataValue<DateTime>(dr, "ST_EndDate");
                        sBSchoolMessage.OfferId = base.GetDataValue<int>(dr, "OfferId");
                        sBSchoolMessage.Email = base.GetDataValue<string>(dr, "Email");
                        sBSchoolMessage.Pwd = base.GetDataValue<string>(dr, "Pwd");
                        sBSchoolMessage.NotificationMethod = base.GetDataValue<string>(dr, "NotificationMethod");
                        sBSchoolMessage.MO_Term = base.GetDataValue<int>(dr, "MO_Term");
                        sBSchoolMessage.MO_Interest = base.GetDataValue<double>(dr, "MO_Interest");
                        sBSchoolMessage.CP_NewPassword = base.GetDataValue<string>(dr, "CP_NewPassword");
                        sBSchoolMessage.CP_ConfirmPassword = base.GetDataValue<string>(dr, "CP_ConfirmPassword");
                        sBSchoolMessage.NationalID = base.GetDataValue<string>(dr, "NationalID");
                        sBSchoolMessage.MpesaRef = base.GetDataValue<string>(dr, "MpesaRef");
                        sBSchoolMessage.MpesaSentDate = base.GetDataValue<DateTime>(dr, "MpesaSentDate");
                        sBSchoolMessage.MpesaBal = base.GetDataValue<decimal>(dr, "MpesaBal");
                        sBSchoolMessage.Exception = base.GetDataValue<string>(dr, "Exception");
                    }
                }
            }

            return sBSchoolMessage;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the SBSchoolMessages table.
        /// </summary>
        /// <returns>A collection of SBSchoolMessage objects.</returns>		
        public List<SBSchoolMessage> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [MemberId], [SenderTelno], [CustomerTelno], [Command], [MessageType], [Status]" +
                        ", [Body], [MessageDate], [AccountId], [StartDate], [EndDate], [Amount], [HM_Param]" +
                        ", [BE_AccLabel], [ST_StartDate], [ST_EndDate], [OfferId], [Email], [Pwd], [NotificationMethod]" +
                        ", [MO_Term], [MO_Interest], [CP_NewPassword], [CP_ConfirmPassword], [NationalID], [MpesaRef]" +
                        ", [MpesaSentDate], [MpesaBal], [Exception] " +
                "FROM dbo.SBSchoolMessages ";

            List<SBSchoolMessage> result = new List<SBSchoolMessage>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new SBSchoolMessage
                        SBSchoolMessage sBSchoolMessage = new SBSchoolMessage();

                        // Read values.
                        sBSchoolMessage.Id = base.GetDataValue<int>(dr, "Id");
                        sBSchoolMessage.MemberId = base.GetDataValue<int>(dr, "MemberId");
                        sBSchoolMessage.SenderTelno = base.GetDataValue<string>(dr, "SenderTelno");
                        sBSchoolMessage.CustomerTelno = base.GetDataValue<string>(dr, "CustomerTelno");
                        sBSchoolMessage.Command = base.GetDataValue<string>(dr, "Command");
                        sBSchoolMessage.MessageType = base.GetDataValue<int>(dr, "MessageType");
                        sBSchoolMessage.Status = base.GetDataValue<string>(dr, "Status");
                        sBSchoolMessage.Body = base.GetDataValue<string>(dr, "Body");
                        sBSchoolMessage.MessageDate = base.GetDataValue<DateTime>(dr, "MessageDate");
                        sBSchoolMessage.AccountId = base.GetDataValue<int>(dr, "AccountId");
                        sBSchoolMessage.StartDate = base.GetDataValue<DateTime>(dr, "StartDate");
                        sBSchoolMessage.EndDate = base.GetDataValue<DateTime>(dr, "EndDate");
                        sBSchoolMessage.Amount = base.GetDataValue<decimal>(dr, "Amount");
                        sBSchoolMessage.HM_Param = base.GetDataValue<string>(dr, "HM_Param");
                        sBSchoolMessage.BE_AccLabel = base.GetDataValue<string>(dr, "BE_AccLabel");
                        sBSchoolMessage.ST_StartDate = base.GetDataValue<DateTime>(dr, "ST_StartDate");
                        sBSchoolMessage.ST_EndDate = base.GetDataValue<DateTime>(dr, "ST_EndDate");
                        sBSchoolMessage.OfferId = base.GetDataValue<int>(dr, "OfferId");
                        sBSchoolMessage.Email = base.GetDataValue<string>(dr, "Email");
                        sBSchoolMessage.Pwd = base.GetDataValue<string>(dr, "Pwd");
                        sBSchoolMessage.NotificationMethod = base.GetDataValue<string>(dr, "NotificationMethod");
                        sBSchoolMessage.MO_Term = base.GetDataValue<int>(dr, "MO_Term");
                        sBSchoolMessage.MO_Interest = base.GetDataValue<double>(dr, "MO_Interest");
                        sBSchoolMessage.CP_NewPassword = base.GetDataValue<string>(dr, "CP_NewPassword");
                        sBSchoolMessage.CP_ConfirmPassword = base.GetDataValue<string>(dr, "CP_ConfirmPassword");
                        sBSchoolMessage.NationalID = base.GetDataValue<string>(dr, "NationalID");
                        sBSchoolMessage.MpesaRef = base.GetDataValue<string>(dr, "MpesaRef");
                        sBSchoolMessage.MpesaSentDate = base.GetDataValue<DateTime>(dr, "MpesaSentDate");
                        sBSchoolMessage.MpesaBal = base.GetDataValue<decimal>(dr, "MpesaBal");
                        sBSchoolMessage.Exception = base.GetDataValue<string>(dr, "Exception");

                        // Add to List.
                        result.Add(sBSchoolMessage);
                    }
                }
            }

            return result;
        }
    }
}

