using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Data.Abstract;
using Works.Data.Concrete.EntityFramework;

namespace Works.Data.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WorkContext _context;
        private EFAssignmentRepository _assignmentRepository;
        private EFCategoryRepository _categoryRepository;
        private EFWorkRepository _workRepository;
        private EFRoleRepository _roleRepository;
        private EFUserRepository _userRepository;

        public UnitOfWork(WorkContext context)
        {
            _context = context;
        }

        public IAssignmentRepository Assignments => _assignmentRepository ?? new EFAssignmentRepository(_context);
        public ICategoryRepository Categories => _categoryRepository ?? new EFCategoryRepository(_context);
        public IWorkRepository Works => _workRepository ?? new EFWorkRepository(_context);
        public IRoleRepository Roles => _roleRepository ?? new EFRoleRepository(_context);
        public IUserRepository Users => _userRepository ?? new EFUserRepository(_context);


        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
