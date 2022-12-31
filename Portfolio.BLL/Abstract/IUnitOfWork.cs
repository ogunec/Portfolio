using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BLL.Abstract
{
    public interface IUnitOfWork
    {
        IAboutRepository About { get; }
        IContactRepository Contact { get; }
        IExperienceRepository Experience { get; }
        IFeatureRepository Feature { get; }
        IMessageRepository Message { get; }
        IMyPortfolioRepository MyPortfolio { get; }
        IServiceRepository Service { get; }
        ISkillRepository Skill { get; }
        ISocialMediaRepository SocialMedia { get; }
        ITestimonialRepository Testimonial { get; }
        void Save();
    }
}
