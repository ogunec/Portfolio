using Portfolio.BLL.Abstract;
using Portfolio.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BLL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private Context _db;
        public UnitOfWork(Context db)
        {
            _db = db;
            About = new AboutRepository(_db);
            Contact = new ContactRepository(_db);
            Experience = new ExperienceRepository(_db);
            Feature = new FeatureRepository(_db);
            Message = new MessageRepository(_db);
            MyPortfolio = new MyPortfolioRepository(_db);
            Service = new ServiceRepository(_db);
            Skill = new SkillRepository(_db);
            SocialMedia = new SocialMediaRepository(_db);
            Testimonial = new TestimonialRepository(_db);
        }

        public IAboutRepository About { get; private set; }
        public IContactRepository Contact { get; private set; }
        public IExperienceRepository Experience { get; private set; }
        public IFeatureRepository Feature { get; private set; }
        public IMessageRepository Message { get; private set; }
        public IMyPortfolioRepository MyPortfolio { get; private set; }
        public IServiceRepository Service { get; private set; }
        public ISkillRepository Skill { get; private set; }
        public ISocialMediaRepository SocialMedia { get; private set; }
        public ITestimonialRepository Testimonial { get; private set; }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
