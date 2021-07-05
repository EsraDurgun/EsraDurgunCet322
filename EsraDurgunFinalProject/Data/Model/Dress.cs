using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EsraDurgunFinalProject.Data.Model
{
    public class Dress
    {
        [Key]
        public int DressId { get; set; }
        public string DressName { get; set; }
        public string DressDes { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int Stocak { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}