using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2API.Models
{
    [Table("Table1" )]
    public class Table1
    {

        [key]

        public int customerID { get; set; }

        [Required]

        public string companyname { get; set; }

        [Required]

        public string contactname { get; set; }
    }
}
