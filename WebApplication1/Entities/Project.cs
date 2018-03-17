using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; } 

        public string ProjectName { get; set; }

        public virtual IList<Task> Tasks { get; set; }


        //public virtual User Admin { get; set; }

        //public virtual IList<User> TeamMembers { get; set; }
    }
}