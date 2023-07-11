//====================================================================================================
// Base code generated with Motion: BC Gen (Build 2.2.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 06/12/2014 07:38:40 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SBiSchoolWeb.Entities;
using SBiSchoolWeb.Data;


namespace SBiSchoolWeb.Business
{
    /// <summary>
    /// Subjects business component.
    /// </summary>
    public partial class SubjectsComponent
    {
        /// <summary>
        /// GetSubjects business method. 
        /// </summary>
        /// <returns>Returns a List<Subject> object.</returns>
        public List<Subject> GetSubjects()
        {
            List<Subject> result = default(List<Subject>);

            // Data access component declarations.
            SubjectDAC subjectDAC = new SubjectDAC();

            // Step 1 - Calling Select on SubjectDAC.
            result = subjectDAC.Select();
            return result;

        }

        /// <summary>
        /// CreateSubject business method. 
        /// </summary>
        /// <param name="subject">A subject value.</param>
        /// <returns>Returns a Subject object.</returns>
        public Subject CreateSubject(Subject subject)
        {
            Subject result = default(Subject);

            // Data access component declarations.
            SubjectDAC subjectDAC = new SubjectDAC();

            // Step 1 - Calling Create on SubjectDAC.
            result = subjectDAC.Create(subject);
            return result;

        }

        /// <summary>
        /// DeleteSubject business method. 
        /// </summary>
        /// <param name="shortCode">A shortCode value.</param>
        public void DeleteSubject(string shortCode)
        {
            // Data access component declarations.
            SubjectDAC subjectDAC = new SubjectDAC();

            // Step 1 - Calling DeleteById on SubjectDAC.
            subjectDAC.DeleteById(shortCode);

        }

        /// <summary>
        /// SelectSubject business method. 
        /// </summary>
        /// <param name="shortCode">A shortCode value.</param>
        /// <returns>Returns a Subject object.</returns>
        public Subject SelectSubject(string shortCode)
        {
            Subject result = default(Subject);

            // Data access component declarations.
            SubjectDAC subjectDAC = new SubjectDAC();

            // Step 1 - Calling SelectById on SubjectDAC.
            result = subjectDAC.SelectById(shortCode);
            return result;

        }

        /// <summary>
        /// UpdateSubject business method. 
        /// </summary>
        /// <param name="subject">A subject value.</param>
        public void UpdateSubject(Subject subject)
        {
            // Data access component declarations.
            SubjectDAC subjectDAC = new SubjectDAC();

            // Step 1 - Calling UpdateById on SubjectDAC.
            subjectDAC.UpdateById(subject);

        }
    }
}