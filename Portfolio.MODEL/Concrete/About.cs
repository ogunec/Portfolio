using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.MODEL.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Age { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }
    }
}
