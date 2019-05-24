using System;
using FluentValidation;

namespace MGG.Crud.Domain.Models
{
    public class Product : Entity<Product>
    {
        protected Product() { }

        public Product(string name, string description, DateTime registerDate)
        {
            Name = name;
            Description = description;
            RegisterDate = registerDate;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime RegisterDate { get; private set; }


        public override bool IsValid()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("O campo Nome não pode ser vazio.")
                .MaximumLength(120).WithMessage("O campo Nome deve ter no máximo 120 caracteres.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("O campo Descrição não pode ser vazio.")
                .MaximumLength(500).WithMessage("O campo Descrição deve ter no máximo 500 caracteres.");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}