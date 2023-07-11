//====================================================================================================
// Base code generated with Motion: BC Gen (Build 2.2.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 06/25/2014 07:14:45 
//====================================================================================================

using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SBiSchoolWeb.Entities;
using SBiSchoolWeb.Data;


namespace SBiSchoolWeb.Business
{
    /// <summary>
    /// Administrator business component.
    /// </summary>
    public partial class AdministratorComponent
    {
        #region "Roles"
        public List<spRole> GetAllRoles()
        {
            List<spRole> result = new List<spRole>();

            // Data access component declarations.
            spRoleDAC spRoleDAC = new spRoleDAC();

            result = spRoleDAC.Select();
            return result;
        }
        public List<spUsersInRole> GetAllUsersInRole()
        {
            List<spUsersInRole> result = default(List<spUsersInRole>);

            // Data access component declarations.
            spUsersInRoleDAC spUsersInRoleDAC = new spUsersInRoleDAC();

            result = spUsersInRoleDAC.Select();
            return result;

        }
        public spRole CreateRole(spRole model)
        {
            spRoleDAC cd = new spRoleDAC();

            spRole role = new spRole();
            role.Description = model.Description;
            role.ShortCode = model.ShortCode;
            role.IsDeleted = false;

            spRole roleReturned = cd.Create(role);

            return roleReturned;
        }
        public void DeleteRoleById(int Id)
        {
            spRoleDAC cd = new spRoleDAC();
            cd.DeleteById(Id);
        }
        public spRole GetRolebyId(int Id)
        {
            spRole result = new spRole();

            // Data access component declarations.
            spRoleDAC cd = new spRoleDAC();

            result = cd.SelectById(Id);
            return result;
        }
        public void UpdateRole(spRole role)
        {
            // Data access component declarations.
            spRoleDAC cd = new spRoleDAC();

            cd.UpdateById(role);
        } 
        #endregion "Roles"
        #region "USersRoles"
        public List<spUsersInRole> GetAllUSersRoles()
        {
            List<spUsersInRole> result = default(List<spUsersInRole>);

            // Data access component declarations.
            spUsersInRoleDAC webpages_RoleDAC = new spUsersInRoleDAC();

            result = webpages_RoleDAC.Select();
            return result;
        }
        public List<spUsersInRole> GetAllUSerRoles(int userid)
        {
            List<spUsersInRole> result = default(List<spUsersInRole>);

            // Data access component declarations.
            spUsersInRoleDAC webpages_RoleDAC = new spUsersInRoleDAC();

            result = webpages_RoleDAC.Select(userid);
            return result;
        }
        public List<spUsersInRole> GetAllRolesforUser(int userid)
        {
            List<spUsersInRole> result = default(List<spUsersInRole>);

            // Data access component declarations.
            spUsersInRoleDAC spUsersInRoleDAC = new spUsersInRoleDAC();

            result = spUsersInRoleDAC.Select(userid);
            return result;

        }
        public spUsersInRole CreateUSerRole(spUsersInRole model)
        {
            spUsersInRoleDAC cd = new spUsersInRoleDAC();

            spUsersInRole userrole = new spUsersInRole();
            userrole.RoleId = model.RoleId;
            userrole.UserId = model.UserId;

            spUsersInRole roleReturned = cd.Create(userrole);

            return roleReturned;
        }
        public void DeleteUserRoleById(int userid, int roleid)
        {
            spUsersInRoleDAC cd = new spUsersInRoleDAC();
            cd.DeleteById(userid, roleid);
        }
        public spUsersInRole GetUSerRolebyId(int userid, int roleid)
        {
            spUsersInRole result = default(spUsersInRole);

            // Data access component declarations.
            spUsersInRoleDAC cd = new spUsersInRoleDAC();

            result = cd.SelectById(userid, roleid);
            return result;
        }
        public void UpdateUSerRole(spUsersInRole userrole)
        {
            // Data access component declarations.
            spUsersInRoleDAC cd = new spUsersInRoleDAC();

            cd.UpdateById(userrole);
        }
        #endregion "USersRoles"
        #region "Users"
        public List<spUser> GetAllUsers()
        {
            List<spUser> result = default(List<spUser>);

            // Data access component declarations.
            spUserDAC _spUserDAC = new spUserDAC();

            result = _spUserDAC.Select();
            return result;
        }
        public spUser CreateUser(spUser model)
        {
            spUserDAC cd = new spUserDAC();

            spUser User = new spUser();
            User.UserName = model.UserName;
            User.Password = model.Password;
            User.RoleId = model.RoleId;
            User.Status = model.Status;
            User.IsDeleted = model.IsDeleted;
            User.Locked = model.Locked;
            User.SystemId = model.SystemId;
            User.Surname = model.Surname;
            User.OtherNames = model.OtherNames;
            User.InformBy = model.InformBy;
            User.Gender = model.Gender;
            User.Telephone = model.Telephone;
            User.Email = model.Email;
            User.NationalID = model.NationalID;
            User.DateOfBirth = model.DateOfBirth;
            User.DateJoined = model.DateJoined;

            spUser UserReturned = cd.Create(User);

            return UserReturned;
        }
        public void DeleteUserById(int Id)
        {
            spUserDAC cd = new spUserDAC();
            cd.DeleteById(Id);
        }
        public spUser GetUserById(int Id)
        {
            spUser result = default(spUser);

            // Data access component declarations.
            spUserDAC cd = new spUserDAC();

            result = cd.SelectById(Id);
            return result;
        }
        public spUser GetUserByEmail(string email)
        {
            spUser result = default(spUser);

            // Data access component declarations.
            spUserDAC cd = new spUserDAC();
            var userquery = from us in cd.Select()
                            where us.UserName == email
                            select us;
            result = userquery.FirstOrDefault();

            return result;
        }
        public void UpdateUser(spUser User)
        {
            // Data access component declarations.
            spUserDAC cd = new spUserDAC();

            cd.UpdateById(User);
        }
        public void UploadUserPhoto(spUser User)
        {
            // Data access component declarations.
            spUserDAC _spUserDAC = new spUserDAC();

            _spUserDAC.UploadUserPhoto(User);
        }
        #endregion "Users"
        #region "spMenus"
        public List<spMenus> GetAllspMenus()
        {
            List<spMenus> result = default(List<spMenus>);

            // Data access component declarations.
            spMenusDAC _spMenusDAC = new spMenusDAC();

            result = _spMenusDAC.Select();
            return result;
        }
        public spMenus CreatespMenu(spMenus model)
        {
            spMenusDAC cd = new spMenusDAC();

            spMenus _spMenus = new spMenus();
            _spMenus.mnuName = model.mnuName;
            _spMenus.Description = model.Description;

            spMenus MenuReturned = cd.Create(_spMenus);

            return MenuReturned;
        }
        public void DeletespMenusById(int Id)
        {
            spMenusDAC cd = new spMenusDAC();
            cd.DeleteById(Id);
        }
        public spMenus GetspMenusbyId(int Id)
        {
            spMenus result = default(spMenus);

            // Data access component declarations.
            spMenusDAC cd = new spMenusDAC();

            result = cd.SelectById(Id);
            return result;
        }
        public void UpdatespMenus(spMenus _spMenus)
        {
            // Data access component declarations.
            spMenusDAC cd = new spMenusDAC();

            cd.UpdateById(_spMenus);
        }
        #endregion "spMenus"
        #region "spAllowedRoleMenus"
        public List<spAllowedRoleMenus> GetAllspAllowedRoleMenus()
        {
            List<spAllowedRoleMenus> result = default(List<spAllowedRoleMenus>);

            // Data access component declarations.
            spAllowedRoleMenusDAC _spAllowedRoleMenusDAC = new spAllowedRoleMenusDAC();

            result = _spAllowedRoleMenusDAC.Select();
            return result;
        }
        public spAllowedRoleMenus CreatespAllowedRoleMenu(spAllowedRoleMenus model)
        {
            spAllowedRoleMenusDAC cd = new spAllowedRoleMenusDAC();

            spAllowedRoleMenus _spAllowedRoleMenus = new spAllowedRoleMenus();
            _spAllowedRoleMenus.RoleId = model.RoleId;
            _spAllowedRoleMenus.MenuItemId = model.MenuItemId;
            _spAllowedRoleMenus.Allowed = model.Allowed;

            spAllowedRoleMenus AllowedRoleMenusReturned = cd.Create(_spAllowedRoleMenus);

            return AllowedRoleMenusReturned;
        }
        public void DeletespAllowedRoleMenusById(int Id)
        {
            spAllowedRoleMenusDAC cd = new spAllowedRoleMenusDAC();
            cd.DeleteById(Id);
        }
        public spAllowedRoleMenus GetspAllowedRoleMenusbyId(int Id)
        {
            spAllowedRoleMenus result = default(spAllowedRoleMenus);

            // Data access component declarations.
            spAllowedRoleMenusDAC cd = new spAllowedRoleMenusDAC();

            result = cd.SelectById(Id);
            return result;
        }
        public spAllowedRoleMenus GetRight(int Roleid, int Menuitemid)
        {
            spAllowedRoleMenus result = default(spAllowedRoleMenus);

            // Data access component declarations.
            spAllowedRoleMenusDAC cd = new spAllowedRoleMenusDAC();

            result = cd.SelectRight(Roleid, Menuitemid);
            return result;
        } 
        public void UpdatespAllowedRoleMenus(spAllowedRoleMenus _spAllowedRoleMenus)
        {
            // Data access component declarations.
            spAllowedRoleMenusDAC cd = new spAllowedRoleMenusDAC();

            cd.UpdateById(_spAllowedRoleMenus);
        }
        #endregion "spAllowedRoleMenus"

    }
}