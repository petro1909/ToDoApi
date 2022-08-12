using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Model
{
    public class ToDoTask
    {
        public int Id { set; get; }
        public int UserId { set; get; }
        public User User { set; get; }
        public int ProjectId { set; get; }
        public Project Project { set; get; }
        public int ParentTaskId { set; get; }
        public ToDoTask ParentTask { set; get; }
        public string Text { set; get; }
        public bool IsDone { set; get; }
        public List<ToDoTask> ChildTasks { set; get; }

        public ToDoTask(string text)
        {
            Text = text;
            IsDone = false;
        }

        public override string ToString()
        {
            return $"Task :\n\t{Text}\n\t{IsDone}\n";
        }
    }
}
