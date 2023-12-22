using Core.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IRoleUserService
    {
        List<OperationClaim> GetClaims(RoleUser roleUser);
        void Add(RoleUser roleUser);
        RoleUser GetByMail(string email);
    }
}
