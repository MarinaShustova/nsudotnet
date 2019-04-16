using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWorkersDB.Models {
    public class Worker {
        public int ID { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
