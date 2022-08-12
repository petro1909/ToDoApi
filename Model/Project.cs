using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Model
{
    public class Project
    {
        public User User { set; get; }
        public int UserId { set; get; }
        public string Name { set; get; }
        public List<ToDoTask> Tasks { set; get; }
        

    }
}
