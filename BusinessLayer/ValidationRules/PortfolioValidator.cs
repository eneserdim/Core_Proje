using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator :AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen Bu Alanı Boş Bırakmayınız!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Lütfen Bu Alanı Boş Bırakmayınız!");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Lütfen Bu Alanı Boş Bırakmayınız!");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje Adı En Az 5 Karakterden Oluşmalıdır!");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Proje Adı En Fazla 50 Karakterden Oluşmalıdır!");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Lütfen Bu Alanı Boş Bırakmayınız!");
            RuleFor(x => x.Platform).MinimumLength(5).WithMessage("Lütfen Bu Alanı Boş Bırakmayınız!");
            RuleFor(x => x.PlatformUrl).MaximumLength(50).WithMessage("Lütfen Bu Alanı Boş Bırakmayınız!");
        }
    }
}
