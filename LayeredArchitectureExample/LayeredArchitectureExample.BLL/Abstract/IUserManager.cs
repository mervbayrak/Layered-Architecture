using LayeredArchitectureExample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureExample.BLL.Abstract
{
    public interface IUserManager
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        User Get(string id);
        List<User> GetList();
    }
}
