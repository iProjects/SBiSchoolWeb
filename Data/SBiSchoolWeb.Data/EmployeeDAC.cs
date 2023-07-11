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
    /// Employees data access component. Manages CRUD operations for the Employees table.
    /// </summary>
    public partial class EmployeeDAC : DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Employees table.
        /// </summary>
        /// <param name="employee">A Employee object.</param>
        /// <returns>An updated Employee object.</returns>
        public Employee Create(Employee employee)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Employees ([EmpNo], [Surname], [OtherNames], [Email], [DoB], [MaritalStatus], [Gender], [Photo], [DoE], [BasicComputation], [BasicPay], [PersonalRelief], [MortgageRelief], [InsuranceRelief], [NSSFNo], [NHIFNo], [IDNo], [PINNo], [DepartmentId], [EmployerId], [PayPoint], [EmpGroup], [EmpPayroll], [PrevEmployer], [DateLeft], [PaymentMode], [TelephoneNo], [ChequeNo], [BankCode], [BankAccount], [LeaveBalance], [IsActive], [CreatedBy], [CreatedOn], [IsDeleted], [SystemId]) " +
                "VALUES(@EmpNo, @Surname, @OtherNames, @Email, @DoB, @MaritalStatus, @Gender, @Photo, @DoE, @BasicComputation, @BasicPay, @PersonalRelief, @MortgageRelief, @InsuranceRelief, @NSSFNo, @NHIFNo, @IDNo, @PINNo, @DepartmentId, @EmployerId, @PayPoint, @EmpGroup, @EmpPayroll, @PrevEmployer, @DateLeft, @PaymentMode, @TelephoneNo, @ChequeNo, @BankCode, @BankAccount, @LeaveBalance, @IsActive, @CreatedBy, @CreatedOn, @IsDeleted, @SystemId); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@EmpNo", DbType.String, employee.EmpNo);
                db.AddInParameter(cmd, "@Surname", DbType.String, employee.Surname);
                db.AddInParameter(cmd, "@OtherNames", DbType.String, employee.OtherNames);
                db.AddInParameter(cmd, "@Email", DbType.String, employee.Email);
                db.AddInParameter(cmd, "@DoB", DbType.Date, employee.DoB);
                db.AddInParameter(cmd, "@MaritalStatus", DbType.String, employee.MaritalStatus);
                db.AddInParameter(cmd, "@Gender", DbType.String, employee.Gender);
                db.AddInParameter(cmd, "@Photo", DbType.String, employee.Photo);
                db.AddInParameter(cmd, "@DoE", DbType.Date, employee.DoE);
                db.AddInParameter(cmd, "@BasicComputation", DbType.String, employee.BasicComputation);
                db.AddInParameter(cmd, "@BasicPay", DbType.Currency, employee.BasicPay);
                db.AddInParameter(cmd, "@PersonalRelief", DbType.Currency, employee.PersonalRelief);
                db.AddInParameter(cmd, "@MortgageRelief", DbType.Currency, employee.MortgageRelief);
                db.AddInParameter(cmd, "@InsuranceRelief", DbType.Currency, employee.InsuranceRelief);
                db.AddInParameter(cmd, "@NSSFNo", DbType.String, employee.NSSFNo);
                db.AddInParameter(cmd, "@NHIFNo", DbType.String, employee.NHIFNo);
                db.AddInParameter(cmd, "@IDNo", DbType.String, employee.IDNo);
                db.AddInParameter(cmd, "@PINNo", DbType.String, employee.PINNo);
                db.AddInParameter(cmd, "@DepartmentId", DbType.Int32, employee.DepartmentId);
                db.AddInParameter(cmd, "@EmployerId", DbType.Int32, employee.EmployerId);
                db.AddInParameter(cmd, "@PayPoint", DbType.String, employee.PayPoint);
                db.AddInParameter(cmd, "@EmpGroup", DbType.String, employee.EmpGroup);
                db.AddInParameter(cmd, "@EmpPayroll", DbType.String, employee.EmpPayroll);
                db.AddInParameter(cmd, "@PrevEmployer", DbType.String, employee.PrevEmployer);
                db.AddInParameter(cmd, "@DateLeft", DbType.Date, employee.DateLeft);
                db.AddInParameter(cmd, "@PaymentMode", DbType.String, employee.PaymentMode);
                db.AddInParameter(cmd, "@TelephoneNo", DbType.String, employee.TelephoneNo);
                db.AddInParameter(cmd, "@ChequeNo", DbType.String, employee.ChequeNo);
                db.AddInParameter(cmd, "@BankCode", DbType.String, employee.BankCode);
                db.AddInParameter(cmd, "@BankAccount", DbType.String, employee.BankAccount);
                db.AddInParameter(cmd, "@LeaveBalance", DbType.String, employee.LeaveBalance);
                db.AddInParameter(cmd, "@IsActive", DbType.Boolean, employee.IsActive);
                db.AddInParameter(cmd, "@CreatedBy", DbType.String, employee.CreatedBy);
                db.AddInParameter(cmd, "@CreatedOn", DbType.Date, employee.CreatedOn);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, employee.IsDeleted);
                db.AddInParameter(cmd, "@SystemId", DbType.String, employee.SystemId);

                // Get the primary key value.
                employee.Id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return employee;
        }

        /// <summary>
        /// Updates an existing row in the Employees table.
        /// </summary>
        /// <param name="employee">A Employee entity object.</param>
        public void UpdateById(Employee employee)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Employees " +
                "SET " +
                    "[EmpNo]=@EmpNo, " +
                    "[Surname]=@Surname, " +
                    "[OtherNames]=@OtherNames, " +
                    "[Email]=@Email, " +
                    "[DoB]=@DoB, " +
                    "[MaritalStatus]=@MaritalStatus, " +
                    "[Gender]=@Gender, " +
                    "[Photo]=@Photo, " +
                    "[DoE]=@DoE, " +
                    "[BasicComputation]=@BasicComputation, " +
                    "[BasicPay]=@BasicPay, " +
                    "[PersonalRelief]=@PersonalRelief, " +
                    "[MortgageRelief]=@MortgageRelief, " +
                    "[InsuranceRelief]=@InsuranceRelief, " +
                    "[NSSFNo]=@NSSFNo, " +
                    "[NHIFNo]=@NHIFNo, " +
                    "[IDNo]=@IDNo, " +
                    "[PINNo]=@PINNo, " +
                    "[DepartmentId]=@DepartmentId, " +
                    "[EmployerId]=@EmployerId, " +
                    "[PayPoint]=@PayPoint, " +
                    "[EmpGroup]=@EmpGroup, " +
                    "[EmpPayroll]=@EmpPayroll, " +
                    "[PrevEmployer]=@PrevEmployer, " +
                    "[DateLeft]=@DateLeft, " +
                    "[PaymentMode]=@PaymentMode, " +
                    "[TelephoneNo]=@TelephoneNo, " +
                    "[ChequeNo]=@ChequeNo, " +
                    "[BankCode]=@BankCode, " +
                    "[BankAccount]=@BankAccount, " +
                    "[LeaveBalance]=@LeaveBalance, " +
                    "[IsActive]=@IsActive, " +
                    "[CreatedBy]=@CreatedBy, " +
                    "[CreatedOn]=@CreatedOn, " +
                    "[IsDeleted]=@IsDeleted, " +
                    "[SystemId]=@SystemId " +
                "WHERE [Id]=@Id ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@EmpNo", DbType.String, employee.EmpNo);
                db.AddInParameter(cmd, "@Surname", DbType.String, employee.Surname);
                db.AddInParameter(cmd, "@OtherNames", DbType.String, employee.OtherNames);
                db.AddInParameter(cmd, "@Email", DbType.String, employee.Email);
                db.AddInParameter(cmd, "@DoB", DbType.Date, employee.DoB);
                db.AddInParameter(cmd, "@MaritalStatus", DbType.String, employee.MaritalStatus);
                db.AddInParameter(cmd, "@Gender", DbType.String, employee.Gender);
                db.AddInParameter(cmd, "@Photo", DbType.String, employee.Photo);
                db.AddInParameter(cmd, "@DoE", DbType.Date, employee.DoE);
                db.AddInParameter(cmd, "@BasicComputation", DbType.String, employee.BasicComputation);
                db.AddInParameter(cmd, "@BasicPay", DbType.Currency, employee.BasicPay);
                db.AddInParameter(cmd, "@PersonalRelief", DbType.Currency, employee.PersonalRelief);
                db.AddInParameter(cmd, "@MortgageRelief", DbType.Currency, employee.MortgageRelief);
                db.AddInParameter(cmd, "@InsuranceRelief", DbType.Currency, employee.InsuranceRelief);
                db.AddInParameter(cmd, "@NSSFNo", DbType.String, employee.NSSFNo);
                db.AddInParameter(cmd, "@NHIFNo", DbType.String, employee.NHIFNo);
                db.AddInParameter(cmd, "@IDNo", DbType.String, employee.IDNo);
                db.AddInParameter(cmd, "@PINNo", DbType.String, employee.PINNo);
                db.AddInParameter(cmd, "@DepartmentId", DbType.Int32, employee.DepartmentId);
                db.AddInParameter(cmd, "@EmployerId", DbType.Int32, employee.EmployerId);
                db.AddInParameter(cmd, "@PayPoint", DbType.String, employee.PayPoint);
                db.AddInParameter(cmd, "@EmpGroup", DbType.String, employee.EmpGroup);
                db.AddInParameter(cmd, "@EmpPayroll", DbType.String, employee.EmpPayroll);
                db.AddInParameter(cmd, "@PrevEmployer", DbType.String, employee.PrevEmployer);
                db.AddInParameter(cmd, "@DateLeft", DbType.Date, employee.DateLeft);
                db.AddInParameter(cmd, "@PaymentMode", DbType.String, employee.PaymentMode);
                db.AddInParameter(cmd, "@TelephoneNo", DbType.String, employee.TelephoneNo);
                db.AddInParameter(cmd, "@ChequeNo", DbType.String, employee.ChequeNo);
                db.AddInParameter(cmd, "@BankCode", DbType.String, employee.BankCode);
                db.AddInParameter(cmd, "@BankAccount", DbType.String, employee.BankAccount);
                db.AddInParameter(cmd, "@LeaveBalance", DbType.String, employee.LeaveBalance);
                db.AddInParameter(cmd, "@IsActive", DbType.Boolean, employee.IsActive);
                db.AddInParameter(cmd, "@CreatedBy", DbType.String, employee.CreatedBy);
                db.AddInParameter(cmd, "@CreatedOn", DbType.Date, employee.CreatedOn);
                db.AddInParameter(cmd, "@IsDeleted", DbType.Boolean, employee.IsDeleted);
                db.AddInParameter(cmd, "@SystemId", DbType.String, employee.SystemId);
                db.AddInParameter(cmd, "@Id", DbType.Int32, employee.Id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Conditionally deletes one or more rows in the Employees table.
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.Employees " +
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
        /// Returns a row from the Employees table.
        /// </summary>
        /// <param name="id">A Id value.</param>
        /// <returns>A Employee object with data populated from the database.</returns>
        public Employee SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [Id], [EmpNo], [Surname], [OtherNames], [Email], [DoB], [MaritalStatus], [Gender]" +
                        ", [Photo], [DoE], [BasicComputation], [BasicPay], [PersonalRelief], [MortgageRelief]" +
                        ", [InsuranceRelief], [NSSFNo], [NHIFNo], [IDNo], [PINNo], [DepartmentId], [EmployerId]" +
                        ", [PayPoint], [EmpGroup], [EmpPayroll], [PrevEmployer], [DateLeft], [PaymentMode]" +
                        ", [TelephoneNo], [ChequeNo], [BankCode], [BankAccount], [LeaveBalance], [IsActive]" +
                        ", [CreatedBy], [CreatedOn], [IsDeleted], [SystemId] " +
                "FROM dbo.Employees  " +
                "WHERE [Id]=@Id ";

            Employee employee = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Employee
                        employee = new Employee();

                        // Read values.
                        employee.Id = base.GetDataValue<int>(dr, "Id");
                        employee.EmpNo = base.GetDataValue<string>(dr, "EmpNo");
                        employee.Surname = base.GetDataValue<string>(dr, "Surname");
                        employee.OtherNames = base.GetDataValue<string>(dr, "OtherNames");
                        employee.Email = base.GetDataValue<string>(dr, "Email");
                        employee.DoB = base.GetDataValue<DateTime>(dr, "DoB");
                        employee.MaritalStatus = base.GetDataValue<string>(dr, "MaritalStatus");
                        employee.Gender = base.GetDataValue<string>(dr, "Gender");
                        employee.Photo = base.GetDataValue<string>(dr, "Photo");
                        employee.DoE = base.GetDataValue<DateTime>(dr, "DoE");
                        employee.BasicComputation = base.GetDataValue<string>(dr, "BasicComputation");
                        employee.BasicPay = base.GetDataValue<decimal>(dr, "BasicPay");
                        employee.PersonalRelief = base.GetDataValue<decimal>(dr, "PersonalRelief");
                        employee.MortgageRelief = base.GetDataValue<decimal>(dr, "MortgageRelief");
                        employee.InsuranceRelief = base.GetDataValue<decimal>(dr, "InsuranceRelief");
                        employee.NSSFNo = base.GetDataValue<string>(dr, "NSSFNo");
                        employee.NHIFNo = base.GetDataValue<string>(dr, "NHIFNo");
                        employee.IDNo = base.GetDataValue<string>(dr, "IDNo");
                        employee.PINNo = base.GetDataValue<string>(dr, "PINNo");
                        employee.DepartmentId = base.GetDataValue<int>(dr, "DepartmentId");
                        employee.EmployerId = base.GetDataValue<int>(dr, "EmployerId");
                        employee.PayPoint = base.GetDataValue<string>(dr, "PayPoint");
                        employee.EmpGroup = base.GetDataValue<string>(dr, "EmpGroup");
                        employee.EmpPayroll = base.GetDataValue<string>(dr, "EmpPayroll");
                        employee.PrevEmployer = base.GetDataValue<string>(dr, "PrevEmployer");
                        employee.DateLeft = base.GetDataValue<DateTime>(dr, "DateLeft");
                        employee.PaymentMode = base.GetDataValue<string>(dr, "PaymentMode");
                        employee.TelephoneNo = base.GetDataValue<string>(dr, "TelephoneNo");
                        employee.ChequeNo = base.GetDataValue<string>(dr, "ChequeNo");
                        employee.BankCode = base.GetDataValue<string>(dr, "BankCode");
                        employee.BankAccount = base.GetDataValue<string>(dr, "BankAccount");
                        employee.LeaveBalance = base.GetDataValue<string>(dr, "LeaveBalance");
                        employee.IsActive = base.GetDataValue<bool>(dr, "IsActive");
                        employee.CreatedBy = base.GetDataValue<string>(dr, "CreatedBy");
                        employee.CreatedOn = base.GetDataValue<DateTime>(dr, "CreatedOn");
                        employee.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                        employee.SystemId = base.GetDataValue<string>(dr, "SystemId");
                    }
                }
            }

            return employee;
        }

        /// <summary>
        /// Conditionally retrieves one or more rows from the Employees table.
        /// </summary>
        /// <returns>A collection of Employee objects.</returns>		
        public List<Employee> Select()
        {
            // WARNING! The following SQL query does not contain a WHERE condition.
            // You are advised to include a WHERE condition to prevent any performance
            // issues when querying large resultsets.
            const string SQL_STATEMENT =
                "SELECT [Id], [EmpNo], [Surname], [OtherNames], [Email], [DoB], [MaritalStatus], [Gender]" +
                        ", [Photo], [DoE], [BasicComputation], [BasicPay], [PersonalRelief], [MortgageRelief]" +
                        ", [InsuranceRelief], [NSSFNo], [NHIFNo], [IDNo], [PINNo], [DepartmentId], [EmployerId]" +
                        ", [PayPoint], [EmpGroup], [EmpPayroll], [PrevEmployer], [DateLeft], [PaymentMode]" +
                        ", [TelephoneNo], [ChequeNo], [BankCode], [BankAccount], [LeaveBalance], [IsActive]" +
                        ", [CreatedBy], [CreatedOn], [IsDeleted], [SystemId] " +
                "FROM dbo.Employees ";

            List<Employee> result = new List<Employee>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Employee
                        Employee employee = new Employee();

                        // Read values.
                        employee.Id = base.GetDataValue<int>(dr, "Id");
                        employee.EmpNo = base.GetDataValue<string>(dr, "EmpNo");
                        employee.Surname = base.GetDataValue<string>(dr, "Surname");
                        employee.OtherNames = base.GetDataValue<string>(dr, "OtherNames");
                        employee.Email = base.GetDataValue<string>(dr, "Email");
                        employee.DoB = base.GetDataValue<DateTime>(dr, "DoB");
                        employee.MaritalStatus = base.GetDataValue<string>(dr, "MaritalStatus");
                        employee.Gender = base.GetDataValue<string>(dr, "Gender");
                        employee.Photo = base.GetDataValue<string>(dr, "Photo");
                        employee.DoE = base.GetDataValue<DateTime>(dr, "DoE");
                        employee.BasicComputation = base.GetDataValue<string>(dr, "BasicComputation");
                        employee.BasicPay = base.GetDataValue<decimal>(dr, "BasicPay");
                        employee.PersonalRelief = base.GetDataValue<decimal>(dr, "PersonalRelief");
                        employee.MortgageRelief = base.GetDataValue<decimal>(dr, "MortgageRelief");
                        employee.InsuranceRelief = base.GetDataValue<decimal>(dr, "InsuranceRelief");
                        employee.NSSFNo = base.GetDataValue<string>(dr, "NSSFNo");
                        employee.NHIFNo = base.GetDataValue<string>(dr, "NHIFNo");
                        employee.IDNo = base.GetDataValue<string>(dr, "IDNo");
                        employee.PINNo = base.GetDataValue<string>(dr, "PINNo");
                        employee.DepartmentId = base.GetDataValue<int>(dr, "DepartmentId");
                        employee.EmployerId = base.GetDataValue<int>(dr, "EmployerId");
                        employee.PayPoint = base.GetDataValue<string>(dr, "PayPoint");
                        employee.EmpGroup = base.GetDataValue<string>(dr, "EmpGroup");
                        employee.EmpPayroll = base.GetDataValue<string>(dr, "EmpPayroll");
                        employee.PrevEmployer = base.GetDataValue<string>(dr, "PrevEmployer");
                        employee.DateLeft = base.GetDataValue<DateTime>(dr, "DateLeft");
                        employee.PaymentMode = base.GetDataValue<string>(dr, "PaymentMode");
                        employee.TelephoneNo = base.GetDataValue<string>(dr, "TelephoneNo");
                        employee.ChequeNo = base.GetDataValue<string>(dr, "ChequeNo");
                        employee.BankCode = base.GetDataValue<string>(dr, "BankCode");
                        employee.BankAccount = base.GetDataValue<string>(dr, "BankAccount");
                        employee.LeaveBalance = base.GetDataValue<string>(dr, "LeaveBalance");
                        employee.IsActive = base.GetDataValue<bool>(dr, "IsActive");
                        employee.CreatedBy = base.GetDataValue<string>(dr, "CreatedBy");
                        employee.CreatedOn = base.GetDataValue<DateTime>(dr, "CreatedOn");
                        employee.IsDeleted = base.GetDataValue<bool>(dr, "IsDeleted");
                        employee.SystemId = base.GetDataValue<string>(dr, "SystemId");

                        // Add to List.
                        result.Add(employee);
                    }
                }
            }

            return result;
        }
    }
}

