using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Data.Abstract;
using Works.Entities.Concrete;
using Works.Shared.Data.Concrete.EntityFramework;

namespace Works.Data.Concrete.EntityFramework
{
    public class EFAssignmentRepository : EfEntityRepositoryBase<Assignment>, IAssignmentRepository
    {
        public EFAssignmentRepository(DbContext context) : base(context)
        {
        }
    }
}
