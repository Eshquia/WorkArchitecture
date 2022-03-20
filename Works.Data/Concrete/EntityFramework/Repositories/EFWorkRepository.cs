using Microsoft.EntityFrameworkCore;
using Works.Data.Abstract;
using Works.Entities.Concrete;
using Works.Shared.Data.Concrete.EntityFramework;

namespace Works.Data.Concrete.EntityFramework
{
    public class EFWorkRepository : EfEntityRepositoryBase<Work>, IWorkRepository
    {
        public EFWorkRepository(DbContext context) : base(context)
        {
        }
    }
}
