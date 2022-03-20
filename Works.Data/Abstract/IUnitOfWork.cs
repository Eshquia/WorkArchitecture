using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Works.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IWorkRepository Works { get; } 
        ICategoryRepository Categories { get; }
        IAssignmentRepository Assignments { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }
     
        Task<int> SaveAsync();
    }
}
