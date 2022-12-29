using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.MODEL.Concrete
{
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }
        public string ClientName { get; set; }
        public string Company { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
