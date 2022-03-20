using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Entities.Concrete;
using Works.Shared.Data.Abstract;

namespace Works.Data.Abstract
{
    public interface IRoleRepository:IEntityRepository<Role>
    {
    }
}
