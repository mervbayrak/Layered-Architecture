using LayeredArchitectureExample.Core.DataAccess;
using LayeredArchitectureExample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureExample.DAL.Abstract
{
    public interface IUserDAL : IEntityResponsitory<User>
    {
    }
}
