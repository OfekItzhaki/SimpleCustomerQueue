using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Server.Models
{
    public class Customer
    {

        [Key]
        public int QueueNumber { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string Time { get; set; }
    }
}
