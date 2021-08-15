using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TODO.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string BugTitle { get; set; }
        public string BugDetail { get; set; }
        public Bug()
        {
            // needs to be empty
        }
    }
}
