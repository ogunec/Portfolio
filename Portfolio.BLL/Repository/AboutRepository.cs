using Portfolio.BLL.Abstract;
using Portfolio.DAL.Concrete;
using Portfolio.MODEL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BLL.Repository
{
    public class AboutRepository : Repository<About>, IAboutRepository
    {
        public AboutRepository(Context db) : base(db)
        {
        }
    }
}
