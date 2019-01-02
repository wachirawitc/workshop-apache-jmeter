using FluentValidation;
using SessionWorkshop.ViewModels;

namespace SessionWorkshop.Validations
{
	public class LoginViewModelValidation : AbstractValidator<LoginViewModel>
	{
		public LoginViewModelValidation()
		{
			RuleFor(x => x.Username)
				.NotEmpty()
				.MinimumLength(5);

			RuleFor(x => x.Password)
				.NotEmpty()
				.MinimumLength(5);
		}
	}
}