using FluentValidation;

namespace MQS.Domain.Entity.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia.")
                .NotNull()
                .WithMessage("Os itens não podem serem nulos!");

            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("O nome não pode ser nulo.")
                .NotEmpty()
                .WithMessage("O nome não pode ser vazio.")
                .MinimumLength(4)
                .WithMessage("O nome deve ter no mínimo de 4 caracteres.")
                .MaximumLength(100)
                .WithMessage("O nome deve ter no máximo de 100 caracteres.");

            RuleFor(x => x.Email)
                .NotNull()
                .WithMessage("O email não pode ser nulo.")
                .NotEmpty()
                .WithMessage("O email não pode ser vazio.")
                .MinimumLength(60)
                .WithMessage("O email no mínimo de 60 caracteres.")
                .MaximumLength(200)
                .WithMessage("O email no máximo de 500 caracteres.")
                .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                .WithMessage("O email informado não é válido.");

            RuleFor(x => x.Password)
               .NotNull()
               .WithMessage("A senha não pode ser nula.")

               .NotEmpty()
               .WithMessage("A senha não pode ser vazia.")

               .MinimumLength(6)
               .WithMessage("A senha deve ter no mínimo 6 caracteres.")

               .MaximumLength(80)
               .WithMessage("A senha deve ter no máximo 30 caracteres.");
        }
    }
}
