using LayeredArchitectureExample.Core.DataAccess.EntityFramework;
using LayeredArchitectureExample.DAL.Abstract;
using LayeredArchitectureExample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureExample.DAL.Concrete.EntityFramework.DALManagement
{
    public class EFUserDAL :EFEntityResponsitoryBase<MyDbContext, User>, IUserDAL
    {
    }
}
