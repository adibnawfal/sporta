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
    public class NewProductVM
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Product category is required")]
        public ProductCategory ProductCategory { get; set; }

        [Display(Name = "Price in RM")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Color Shown")]
        [Required(ErrorMessage = "Color is required")]
        public string Color { get; set; }

        [Display(Name = "Style")]
        [Required(ErrorMessage = "Style is required")]
        public string Style { get; set; }

        [Display(Name = "Picture 1 URL")]
        [Required(ErrorMessage = "Picture 1 is required")]
        public string Picture1 { get; set; }

        [Display(Name = "Picture 2 URL")]
        [Required(ErrorMessage = "Picture 2 is required")]
        public string Picture2 { get; set; }

        [Display(Name = "Picture 3 URL")]
        [Required(ErrorMessage = "Picture 3 is required")]
        public string Picture3 { get; set; }

        [Display(Name = "Picture 4 URL")]
        [Required(ErrorMessage = "Picture 4 is required")]
        public string Picture4 { get; set; }

        [Display(Name = "Picture 5 URL")]
        [Required(ErrorMessage = "Picture 5 is required")]
        public string Picture5 { get; set; }

        [Display(Name = "Picture 6 URL")]
        [Required(ErrorMessage = "Picture 6 is required")]
        public string Picture6 { get; set; }
    }
}
