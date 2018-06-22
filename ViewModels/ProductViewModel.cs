using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KCell_Solutions.ViewModels
{
    public class ProductViewModel
    {
    [Required(ErrorMessage = "NameRequired")]
    [StringLength(20, ErrorMessage = "NameLength", MinimumLength = 6)]
    [Display(Name = "Name")]
    public string Name { get; set; }
    [Required(ErrorMessage = "PriceRequired")]
    [Range(10, 100, ErrorMessage = "PriceRange")]
    [Display(Name = "Email")]
    public int Email { get; set; }
}
}
