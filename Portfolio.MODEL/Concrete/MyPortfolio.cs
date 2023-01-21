using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.MODEL.Concrete
{
    public class MyPortfolio
    {
        [Key]
        public int MyPortfolioID { get; set; }
        [Required (ErrorMessage = "Zorunlu Alan")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string SmallImageUrl { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string ProjectUrl { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan")]
        public bool Status { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan")]
        public int Progress { get; set; }
    }
}
