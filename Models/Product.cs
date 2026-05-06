using Sporta.Data;
using Sporta.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sporta.Models
{
    public class Product : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set;}
        public string Style { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Picture4 { get; set; }
        public string Picture5 { get; set; }
        public string Picture6 { get; set; }
    }
}
