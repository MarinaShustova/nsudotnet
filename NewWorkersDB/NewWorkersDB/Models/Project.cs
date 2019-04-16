using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWorkersDB.Models {
    public class Project {
        public int ProjectID { get; set; }
        public int WorkerID { get; set; }
        public int Premium { get; set; }
        public String ProjectName { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
