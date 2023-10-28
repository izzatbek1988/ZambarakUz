using FluentValidation;
using ZambarakUz.DataAccess.Entites;

namespace ZambarakUz.Services.Validators.UserValidator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.ALIAS).NotEmpty().WithMessage("ALIAS boş olamaz.");
            RuleFor(user => user.PASSWORD).NotEmpty().WithMessage("PASSWORD boş olamaz.");

            RuleFor(user => user.UID).NotEmpty();
            RuleFor(user => user.GROUP_UID).NotEmpty();
            RuleFor(user => user.CLIENT_UID).NotEmpty();
            RuleFor(user => user.ALIAS).NotEmpty();
            RuleFor(user => user.FONT_SIZE).NotEmpty().GreaterThanOrEqualTo(0);
            RuleFor(user => user.DATE_IN).NotEmpty();
            RuleFor(user => user.DATE_OUT).NotEmpty();
            RuleFor(user => user.IS_KICKED).NotNull();
            RuleFor(user => user.IS_DELETED).NotNull();
            RuleFor(user => user.SECTION_UID).NotEmpty();

            // Diğer doğrulama kuralları buraya eklenebilir.
        }
    }
}
