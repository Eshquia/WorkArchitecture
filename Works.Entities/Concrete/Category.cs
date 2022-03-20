using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Shared.Entities.Abstract;

namespace Works.Entities.Concrete
{
   public class Category:EntityBase,IEntity
    {
       
        public int CategoryName { get; set; }
        public ICollection<Work> Works { get; set; }
    }
}
