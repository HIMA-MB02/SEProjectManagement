using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskStatus { get; set; }

        public virtual Project Project { get; set; }

        //public virtual User UserAssigned { get; set; }
    }
}