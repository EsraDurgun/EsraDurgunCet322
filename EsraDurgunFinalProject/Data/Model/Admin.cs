using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsraDurgunFinalProject.Data.Model
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AdminRole { get; set; }
    }
}