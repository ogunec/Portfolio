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
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
