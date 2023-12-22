using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IRoleUserDal : IEntityRepository<RoleUser>
    {
        List<OperationClaim> GetClaims(RoleUser roleUser);
    }
}
