using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public ToDo()
        {
            Title = "default";
            IsDone = false;
        }
        public ToDo(string title, bool isDone)
        {
            Title = title;
            IsDone = isDone;
        }
    }
}
