using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Shared.Entities.Abstract;

namespace Works.Entities.Concrete
{
    public class Work: EntityBase,IEntity
    {

        public string WorkName { get; set; }
        public DateTime DeadLineTime { get; set; }
        public int AssignmentId { get; set; }
        public int CategoryId { get; set; }
        public Assignment Assignment { get; set; }
        public Category Category { get; set; }
    }
}
