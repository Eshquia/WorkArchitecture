using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Shared.Entities.Abstract;

namespace Works.Entities.Concrete
{
   public class User:EntityBase,IEntity
    {

        public string Name { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Work> Works { get; set; }
        public ICollection<Assignment> Assignments { get; set; }

    }
}
