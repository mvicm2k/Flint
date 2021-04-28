using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Flint.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public  string Name { get; set; }

        [DisplayName("Display Order")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Display order must be greater than 0")]
        public  int DisplayOrder { get; set; }
    }
}
