//====================================================================================================
// Base code generated with Motion: BC Gen (Build 2.2.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 06/12/2014 09:07:04 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SBiSchoolWeb.Entities;
using SBiSchoolWeb.Data;


namespace SBiSchoolWeb.Business
{
    /// <summary>
    /// Departments business component.
    /// </summary>
    public partial class DepartmentsComponent
    {
        /// <summary>
        /// GetAllDepartments business method. 
        /// </summary>
        /// <returns>Returns a List<Department> object.</returns>
        public List<Department> GetAllDepartments()
        {
            List<Department> result = default(List<Department>);

            // Data access component declarations.
            DepartmentDAC departmentDAC = new DepartmentDAC();

            // Step 1 - Calling Select on DepartmentDAC.
            result = departmentDAC.Select();
            return result;

        }

        /// <summary>
        /// GetDepartment business method. 
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>Returns a Department object.</returns>
        public Department GetDepartmentById(int id)
        {
            Department result = default(Department);

            // Data access component declarations.
            DepartmentDAC departmentDAC = new DepartmentDAC();

            // Step 1 - Calling SelectById on DepartmentDAC.
            result = departmentDAC.SelectById(id);
            return result;

        }

        /// <summary>
        /// CreateDepartment business method. 
        /// </summary>
        /// <param name="department">A department value.</param>
        /// <returns>Returns a Department object.</returns>
        public Department CreateDepartment(Department department)
        {
            Department result = default(Department);

            // Data access component declarations.
            DepartmentDAC departmentDAC = new DepartmentDAC();

            // Step 1 - Calling Create on DepartmentDAC.
            result = departmentDAC.Create(department);
            return result;

        }

        /// <summary>
        /// UpdateDepartment business method. 
        /// </summary>
        /// <param name="department">A department value.</param>
        public void UpdateDepartment(Department department)
        {
            // Data access component declarations.
            DepartmentDAC departmentDAC = new DepartmentDAC();

            // Step 1 - Calling UpdateById on DepartmentDAC.
            departmentDAC.UpdateById(department);

        }

        /// <summary>
        /// DeleteDepartment business method. 
        /// </summary>
        /// <param name="id">A id value.</param>
        public void DeleteDepartmentById(int id)
        {
            // Data access component declarations.
            DepartmentDAC departmentDAC = new DepartmentDAC();

            // Step 1 - Calling DeleteById on DepartmentDAC.
            departmentDAC.DeleteById(id);

        }
    }
}