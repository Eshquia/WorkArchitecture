using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Shared.Entities.Abstract;

namespace Works.Entities.Concrete
{
    public class Role:EntityBase,IEntity
    {
   
        public string RoleName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
