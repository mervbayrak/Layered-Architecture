using LayeredArchitectureExample.BLL.Abstract;
using LayeredArchitectureExample.DAL.Abstract;
using LayeredArchitectureExample.DAL.Concrete.EntityFramework.DALManagement;
using LayeredArchitectureExample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureExample.BLL.Concrete
{
    public class UserManager : IUserManager
    {
        #region User Definition
        
        private IUserDAL _userDAL;
        public UserManager() :this (new EFUserDAL())
        {

        }
        public UserManager(EFUserDAL userDAL)
        {
            _userDAL = userDAL;
        }
        #endregion

        #region User Operations

        public void Add(User user)
        {
            _userDAL.Add(user);
        }
        public void Update(User user)
        {
            _userDAL.Update(user);
        }
        public void Delete(User user)
        {
            _userDAL.Delete(user);
        }
        public User Get(string id)
        {
            return _userDAL.Get(m => m.Id == id);
        }
        public List<User> GetList()
        {
            return _userDAL.GetList();
        }

        #endregion
    }
}
