using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Entities.Concrete;

namespace Works.Entities.Dtos
{
   public class WorkListDto
    {
        public IList<Work> Works { get; set; }
    }
}
