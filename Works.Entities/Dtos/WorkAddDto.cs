using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Entities.Concrete;

namespace Works.Entities.Dtos
{
   public class WorkAddDto
    {

        public string WorkName { get; set; }
        public DateTime DeadLineTime { get; set; }
        public int AssignmentId { get; set; }
        public int CategoryId { get; set; }
        public Assignment Assignment { get; set; }
        public Category Category { get; set; }
        public bool IsDeleted { get; set; }
    }
}
