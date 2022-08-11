using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Model
{
    public class User
    {
        public int Id { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public List<Project> Projects { set; get; }
        public List<ToDoTask> Tasks { set; get; }

        public User() { }
        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
            Projects = new List<Project>();
            Tasks = new List<ToDoTask>();
        }

    }
}
