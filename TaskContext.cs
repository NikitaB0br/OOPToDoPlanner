using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBobr
{
    class TaskContext: DbContext
    {
        private static TaskContext _instance = null;
        private static readonly object _lock = new object();
        public static TaskContext Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new TaskContext();
                    }
                    return _instance;
                }
            }
        }
        public TaskContext() : base("DbConnection")
        {
        }
        public DbSet<Task> Tasks { get; set; }
    }
}
