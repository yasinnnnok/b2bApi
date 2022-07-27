using Entities.Dtos;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AuthValidator : AbstractValidator<RegisterAuthDto>
    {
        public AuthValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Mail adresi boş olamaz");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Geçerli bir mail adresi yazın");
            RuleFor(p => p.Image.FileName).NotEmpty().WithMessage("Kullanıcı resmi boş olamaz");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre boş olamaz");
            //rulefor(p => p.password).minimumlength(6).withmessage("şifre en az 6 karakter olmalıdır");
            //rulefor(p => p.password).matches("[a-z]").withmessage("şifreniz en az 1 adet büyük harf içermelidir");
            //rulefor(p => p.password).matches("[a-z]").withmessage("şifreniz en az 1 adet küçük harf içermelidir");
            //rulefor(p => p.password).matches("[0-9]").withmessage("şifreniz en az 1 adet sayı içermelidir");
            //rulefor(p => p.password).matches("[^a-za-z0-9]").withmessage("şifreniz en az 1 adet özel karakter içermelidir");
        }
    }
}
