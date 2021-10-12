using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Lab3.Models
{
    public class Person
    {
        [Required]
        [StringLength(255)]
        
        public string fname
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        public string lname
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        public string age
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        public string email
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        public string date
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        public string pwd
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        public string dis
        {
            get;
            set;
        }


    }
}
