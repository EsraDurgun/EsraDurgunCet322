using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EsraDurgunFinalProject.Data.Model
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }

        [Required(ErrorMessage ="This field can not be emty")]
        public string CatName { get; set; }
        public string CatDes { get; set; }
        public List<Dress> dresses { get; set; }
        
    }
}
