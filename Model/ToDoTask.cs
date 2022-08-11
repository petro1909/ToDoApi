using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Model
{
    public class ToDoTask
    {
        public int Id { set; get; }
        public ToDoTask ParentTask { set; get; }
        public int ParentTaskId { set; get; }
        public string Text { set; get; }
        public bool IsDone { set; get; }
        public List<ToDoTask> Tasks { set; get; }

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
